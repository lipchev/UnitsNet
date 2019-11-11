// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.UnitSystems;

namespace UnitsNet
{
    /// <summary>
    ///     A unit system defined by a combination of base units.
    ///     This is typically used to define the "working units" for consistently creating and presenting quantities in the
    ///     selected base units,
    ///     such as <see cref="SI" /> to use SI base units such as meters, kilograms and seconds.
    /// </summary>
    public class UnitSystem
    {
        // the array used for storing the default units in the current UnitSystem, ordered by QuantityType (excluding QuantityType.Undefined)
        private readonly Lazy<UnitSystemInfo[]> _systemUnits;

        /// <summary>
        ///     Creates an instance of a unit system with the specified base units.
        /// </summary>
        /// <param name="baseUnits">The base units for the unit system.</param>
        public UnitSystem(BaseUnits baseUnits)
        {
            if (baseUnits is null)
            {
                throw new ArgumentNullException(nameof(baseUnits));
            }

            // default implementation (does not fix the prefixed entities matching issue)
            _systemUnits = new Lazy<UnitSystemInfo[]>(() => Quantity.Infos.Select(i =>
            {
                UnitInfo[] commonUnits = i.GetUnitInfosFor(baseUnits).ToArray();
                UnitInfo defaultInfo = commonUnits.FirstOrDefault(); // respecting the original behavior
                return defaultInfo == null ? null : new UnitSystemInfo(defaultInfo, commonUnits);
            }).ToArray());
        }

        /// <summary>
        ///     Creates an instance of a unit system with the specified base units and default unit associations.
        /// </summary>
        /// <param name="systemUnits">The default/common units associated with each quantity type</param>
        protected UnitSystem(UnitSystemInfo[] systemUnits) : this(new Lazy<UnitSystemInfo[]>(() => systemUnits))
        {
            if (systemUnits.Length != Quantity.Infos.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(systemUnits), $"Array size mismatch: expected {Quantity.Infos.Length} items, found: {systemUnits.Length}");
            }
        }

        /// <summary>
        ///     Creates an instance of a unit system with the specified base units and default unit associations (lazy-loaded).
        /// </summary>
        /// <param name="systemUnits">The default/common units associated with each quantity type (lazy-loaded)</param>
        protected UnitSystem(Lazy<UnitSystemInfo[]> systemUnits)
        {
            if (systemUnits is null)
            {
                throw new ArgumentNullException(nameof(systemUnits));
            }
            _systemUnits = systemUnits;
        }

        /// <summary>
        ///     Gets the SI unit system.
        /// </summary>
        public static SI SI { get; } = new SI();


        /// <summary>
        ///     Gets the default unit information for the given quantity type, associated with the current unit system.
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
            {
                throw new ArgumentException("Quantity type can not be undefined.", nameof(quantityType));
            }
            return _systemUnits.Value[(int) quantityType - 1]?.BaseUnit; // valid QuantityTypes start from 1 (0 == Undefined)
        }

        /// <summary>
        ///     Gets the list of commonly used (derived or named) units for the given quantity type, associated with the current unit system.
        ///     For example: the default unit of length in SI is the 'meter' abbreviated with the letter 'm'.
        ///     It is possible to customize the associations by creating derived UnitSystems (immutable) using the method
        ///     <see cref="WithDefaultUnit" />.
        /// </summary>
        /// <param name="quantityType">The quantity type of interest.</param>
        /// <returns>
        ///     The array of UnitInfo for the given quantity type, if such an association exists,
        ///     and <see langword="null" /> otherwise.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     Quantity type can not be undefined.
        /// </exception>
        public UnitInfo[] GetCommonUnitsInfo(QuantityType quantityType)
        {
            if (quantityType == QuantityType.Undefined)
            {
                throw new ArgumentException("Quantity type can not be undefined.", nameof(quantityType));
            }
            return _systemUnits.Value[(int) quantityType - 1]?.DerivedUnits; // valid QuantityTypes start from 1 (0 == Undefined)
        }

        /// <summary>
        ///     Create a derived unit system by specifying a default unit for a given quantity type.
        ///     It is possible to configure multiple associations by chaining calls to this method:
        ///     SI.WithDefaultUnit(..).WithDefaultUnit(..)...
        /// </summary>
        /// <param name="quantityType">The quantity type of interest.</param>
        /// <param name="defaultUnitInfo">The default UnitInfo to associate with the given quantity type.</param>
        /// <param name="derivedUnitInfos">Optionally provide a new definition for the derived units of the new unit system.</param>
        /// <returns>
        ///     A new UnitSystem that defines <paramref name="defaultUnitInfo" /> as the default unit for
        ///     <paramref name="quantityType" />
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     Quantity type can not be undefined and must be compatible with the new default unit (e.g. cannot associate MassUnit
        ///     with 'Meter')
        /// </exception>
        public UnitSystem WithDefaultUnit(QuantityType quantityType, UnitInfo defaultUnitInfo, UnitInfo[] derivedUnitInfos = null)
        {
            if (quantityType == QuantityType.Undefined) // redundant with the following test
            {
                throw new ArgumentException("Quantity type can not be undefined.", nameof(quantityType));
            }

            if (defaultUnitInfo != null && !Quantity.GetInfo(quantityType).UnitInfos.Contains(defaultUnitInfo))
            {
                throw new ArgumentException("The unit provided was not found in the list of units for the specified quantity type");
            }

            if (derivedUnitInfos != null && derivedUnitInfos.Except(Quantity.GetInfo(quantityType).UnitInfos).Any())
            {
                throw new ArgumentException("One or more of the provided derived units were not found in the list of units for the specified quantity type");
            }

            // create a copy of the current mappings, updating only the provided association
            UnitSystemInfo[] newDefaultUnits = _systemUnits.Value.ToArray();
            int qtyIndex = (int) quantityType - 1; // valid QuantityTypes start from 1 (0 == Undefined)
            if (defaultUnitInfo == null)
            {
                // removes the quantity from the unit system
                newDefaultUnits[qtyIndex] = null;
            }
            else if (derivedUnitInfos == null)
            {
                UnitSystemInfo exInfo = newDefaultUnits[qtyIndex];
                if (exInfo == null)
                {
                    newDefaultUnits[qtyIndex] = new UnitSystemInfo(defaultUnitInfo, new[] {defaultUnitInfo});
                }
                else
                {
                    newDefaultUnits[qtyIndex] = new UnitSystemInfo(defaultUnitInfo, exInfo.DerivedUnits.Union(new[] {defaultUnitInfo}).ToArray());
                }
            }
            else
            {
                newDefaultUnits[qtyIndex] = new UnitSystemInfo(defaultUnitInfo, derivedUnitInfos);
            }
            return new UnitSystem(newDefaultUnits);
        }
    }
}
