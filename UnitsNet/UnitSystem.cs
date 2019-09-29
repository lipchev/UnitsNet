// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     A unit system defined by a combination of base units.
    ///     This is typically used to define the "working units" for consistently creating and presenting quantities in the selected base units,
    ///     such as <see cref="SI"/> to use SI base units such as meters, kilograms and seconds.
    /// </summary>
    public sealed class UnitSystem : IEquatable<UnitSystem>
    {
        // the array used for storing the default units in the current UnitSystem, ordered by QuantityType (excluding QuantityType.Undefined)
        private readonly Lazy<UnitInfo[]> _defaultUnits;

        /// <summary>
        /// Creates an instance of a unit system with the specified base units.
        /// </summary>
        /// <param name="baseUnits">The base units for the unit system.</param>
        public UnitSystem(BaseUnits baseUnits)
        {
            if(baseUnits is null)
                throw new ArgumentNullException(nameof(baseUnits));

            if(!baseUnits.IsFullyDefined)
                throw new ArgumentException("A unit system must have all base units defined.", nameof(baseUnits));

            BaseUnits = baseUnits;

            // default implementation (does not fix the prefixed entities matching issue)
            _defaultUnits = new Lazy<UnitInfo[]>(() => Quantity.Infos.Select(i => i.GetUnitInfosFor(baseUnits).FirstOrDefault()).ToArray());
        }

        /// <summary>
        /// Creates an instance of a unit system with the specified base units and default unit associations.
        /// </summary>
        /// <param name="baseUnits">The base units for the unit system.</param>
        /// <param name="defaultUnits">The default units associated with each quantity type</param>
        private UnitSystem(BaseUnits baseUnits, UnitInfo[] defaultUnits)
        {
            if(baseUnits is null)
                throw new ArgumentNullException(nameof(baseUnits));

            if(!baseUnits.IsFullyDefined)
                throw new ArgumentException("A unit system must have all base units defined.", nameof(baseUnits));

            BaseUnits = baseUnits;

            _defaultUnits = new Lazy<UnitInfo[]>(() => defaultUnits);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is UnitSystem))
                return false;

            return Equals((UnitSystem)obj);
        }

        /// <inheritdoc />
        public bool Equals(UnitSystem other)
        {
            if(other is null)
                return false;

            return BaseUnits.Equals(other.BaseUnits);
        }

        /// <summary>
        /// Checks if this instance is equal to another.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>True if equal, otherwise false.</returns>
        /// <seealso cref="Equals(UnitSystem)"/>
        public static bool operator ==(UnitSystem left, UnitSystem right)
        {
            return left is null ? right is null : left.Equals(right);
        }

        /// <summary>
        /// Checks if this instance is equal to another.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>True if equal, otherwise false.</returns>
        /// <seealso cref="Equals(UnitSystem)"/>
        public static bool operator !=(UnitSystem left, UnitSystem right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return new {BaseUnits}.GetHashCode();
        }

        /// <summary>
        ///     The base units of this unit system.
        /// </summary>
        public BaseUnits BaseUnits{ get; }

        private static readonly BaseUnits SIBaseUnits = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
            ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

        /// <summary>
        /// Gets the SI unit system.
        /// </summary>
        public static UnitSystem SI { get; } = new UnitSystem(SIBaseUnits);

        /// <summary>
        ///     Gets the default unit information for the given quantity type associated with the current unit system.
        ///     For example: the default unit of length in SI is the 'meter' abbreviated with the letter 'm'.
        ///     It is possible to customize the associations by creating derived UnitSystems (immutable) using the method
        ///     <see cref="WithDefaultUnit" />.
        /// </summary>
        /// <param name="quantityType">The quantity type of interest.</param>
        /// <returns>
        ///     The default UnitInfo for the given quantity type, if such an association exists,
        ///     and <see langword="null" /> otherwise.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     Quantity type can not be undefined.
        /// </exception>
        public UnitInfo GetDefaultUnitInfo(QuantityType quantityType)
        {
            if (quantityType == QuantityType.Undefined)
                throw new ArgumentException("Quantity type can not be undefined.", nameof(quantityType));
            return _defaultUnits.Value[(int) quantityType - 1]; // valid QuantityTypes start from 1 (0 == Undefined)
        }

        /// <summary>
        ///     Create a derived unit system by specifying a default unit for a given quantity type.
        ///     It is possible to configure multiple associations by chaining calls to this method:
        ///     SI.WithDefaultUnit(..).WithDefaultUnit(..)...
        /// </summary>
        /// <param name="quantityType">The quantity type of interest.</param>
        /// <param name="defaultUnitInfo">The default UnitInfo to associate with the given quantity type.</param>
        /// <param name="baseUnits">Optionally provide a new definition for the base units of the new unit system.</param>
        /// <returns>
        ///     A new UnitSystem that defines <paramref name="defaultUnitInfo" /> as the default unit for
        ///     <paramref name="quantityType" />
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     Quantity type can not be undefined and must be compatible with the new default unit (e.g. cannot associate MassUnit with 'Meter')
        /// </exception>
        public UnitSystem WithDefaultUnit(QuantityType quantityType, UnitInfo defaultUnitInfo, BaseUnits baseUnits = null)
        {
            if (quantityType == QuantityType.Undefined) // redundant with the following test
                throw new ArgumentException("Quantity type can not be undefined.", nameof(quantityType));

            if (defaultUnitInfo != null && !Quantity.GetInfo(quantityType).UnitInfos.Contains(defaultUnitInfo))
                throw new ArgumentException("The unit provided was not found in the list of units for the specified quantity type");
            
            var newBaseUnits = baseUnits ?? BaseUnits;

            // create a copy of the current mappings, updating only the provided association
            var newDefaultUnits = _defaultUnits.Value.ToArray();
            newDefaultUnits[(int) quantityType - 1] = defaultUnitInfo;  // valid QuantityTypes start from 1 (0 == Undefined)

            return new UnitSystem(newBaseUnits, newDefaultUnits);
        }
    }
}
