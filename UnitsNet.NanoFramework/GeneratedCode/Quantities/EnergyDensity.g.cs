//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     
    /// </summary>
    public struct  EnergyDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly EnergyDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public EnergyDensityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public EnergyDensity(double value, EnergyDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of EnergyDensity, which is Second. All conversions go via this value.
        /// </summary>
        public static EnergyDensityUnit BaseUnit { get; } = EnergyDensityUnit.JoulePerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of EnergyDensity.
        /// </summary>
        public static EnergyDensity MaxValue { get; } = new EnergyDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of EnergyDensity.
        /// </summary>
        public static EnergyDensity MinValue { get; } = new EnergyDensity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static EnergyDensity Zero { get; } = new EnergyDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.GigajoulePerCubicMeter"/>
        /// </summary>
        public double GigajoulesPerCubicMeter => As(EnergyDensityUnit.GigajoulePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.GigawattHourPerCubicMeter"/>
        /// </summary>
        public double GigawattHoursPerCubicMeter => As(EnergyDensityUnit.GigawattHourPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.JoulePerCubicMeter"/>
        /// </summary>
        public double JoulesPerCubicMeter => As(EnergyDensityUnit.JoulePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.KilojoulePerCubicMeter"/>
        /// </summary>
        public double KilojoulesPerCubicMeter => As(EnergyDensityUnit.KilojoulePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.KilowattHourPerCubicMeter"/>
        /// </summary>
        public double KilowattHoursPerCubicMeter => As(EnergyDensityUnit.KilowattHourPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.MegajoulePerCubicMeter"/>
        /// </summary>
        public double MegajoulesPerCubicMeter => As(EnergyDensityUnit.MegajoulePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.MegawattHourPerCubicMeter"/>
        /// </summary>
        public double MegawattHoursPerCubicMeter => As(EnergyDensityUnit.MegawattHourPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.PetajoulePerCubicMeter"/>
        /// </summary>
        public double PetajoulesPerCubicMeter => As(EnergyDensityUnit.PetajoulePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.PetawattHourPerCubicMeter"/>
        /// </summary>
        public double PetawattHoursPerCubicMeter => As(EnergyDensityUnit.PetawattHourPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.TerajoulePerCubicMeter"/>
        /// </summary>
        public double TerajoulesPerCubicMeter => As(EnergyDensityUnit.TerajoulePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.TerawattHourPerCubicMeter"/>
        /// </summary>
        public double TerawattHoursPerCubicMeter => As(EnergyDensityUnit.TerawattHourPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyDensityUnit.WattHourPerCubicMeter"/>
        /// </summary>
        public double WattHoursPerCubicMeter => As(EnergyDensityUnit.WattHourPerCubicMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.GigajoulePerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromGigajoulesPerCubicMeter(double gigajoulespercubicmeter) => new EnergyDensity(gigajoulespercubicmeter, EnergyDensityUnit.GigajoulePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.GigawattHourPerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromGigawattHoursPerCubicMeter(double gigawatthourspercubicmeter) => new EnergyDensity(gigawatthourspercubicmeter, EnergyDensityUnit.GigawattHourPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.JoulePerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromJoulesPerCubicMeter(double joulespercubicmeter) => new EnergyDensity(joulespercubicmeter, EnergyDensityUnit.JoulePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.KilojoulePerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromKilojoulesPerCubicMeter(double kilojoulespercubicmeter) => new EnergyDensity(kilojoulespercubicmeter, EnergyDensityUnit.KilojoulePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.KilowattHourPerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromKilowattHoursPerCubicMeter(double kilowatthourspercubicmeter) => new EnergyDensity(kilowatthourspercubicmeter, EnergyDensityUnit.KilowattHourPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.MegajoulePerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromMegajoulesPerCubicMeter(double megajoulespercubicmeter) => new EnergyDensity(megajoulespercubicmeter, EnergyDensityUnit.MegajoulePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.MegawattHourPerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromMegawattHoursPerCubicMeter(double megawatthourspercubicmeter) => new EnergyDensity(megawatthourspercubicmeter, EnergyDensityUnit.MegawattHourPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.PetajoulePerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromPetajoulesPerCubicMeter(double petajoulespercubicmeter) => new EnergyDensity(petajoulespercubicmeter, EnergyDensityUnit.PetajoulePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.PetawattHourPerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromPetawattHoursPerCubicMeter(double petawatthourspercubicmeter) => new EnergyDensity(petawatthourspercubicmeter, EnergyDensityUnit.PetawattHourPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.TerajoulePerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromTerajoulesPerCubicMeter(double terajoulespercubicmeter) => new EnergyDensity(terajoulespercubicmeter, EnergyDensityUnit.TerajoulePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.TerawattHourPerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromTerawattHoursPerCubicMeter(double terawatthourspercubicmeter) => new EnergyDensity(terawatthourspercubicmeter, EnergyDensityUnit.TerawattHourPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="EnergyDensity"/> from <see cref="EnergyDensityUnit.WattHourPerCubicMeter"/>.
        /// </summary>
        public static EnergyDensity FromWattHoursPerCubicMeter(double watthourspercubicmeter) => new EnergyDensity(watthourspercubicmeter, EnergyDensityUnit.WattHourPerCubicMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EnergyDensityUnit" /> to <see cref="EnergyDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>EnergyDensity unit value.</returns>
        public static EnergyDensity From(double value, EnergyDensityUnit fromUnit)
        {
            return new EnergyDensity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(EnergyDensityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this EnergyDensity to another EnergyDensity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A EnergyDensity with the specified unit.</returns>
                public EnergyDensity ToUnit(EnergyDensityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new EnergyDensity(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        EnergyDensityUnit.GigajoulePerCubicMeter => (_value) * 1e9d,
                        EnergyDensityUnit.GigawattHourPerCubicMeter => (_value * 3.6e+3) * 1e9d,
                        EnergyDensityUnit.JoulePerCubicMeter => _value,
                        EnergyDensityUnit.KilojoulePerCubicMeter => (_value) * 1e3d,
                        EnergyDensityUnit.KilowattHourPerCubicMeter => (_value * 3.6e+3) * 1e3d,
                        EnergyDensityUnit.MegajoulePerCubicMeter => (_value) * 1e6d,
                        EnergyDensityUnit.MegawattHourPerCubicMeter => (_value * 3.6e+3) * 1e6d,
                        EnergyDensityUnit.PetajoulePerCubicMeter => (_value) * 1e15d,
                        EnergyDensityUnit.PetawattHourPerCubicMeter => (_value * 3.6e+3) * 1e15d,
                        EnergyDensityUnit.TerajoulePerCubicMeter => (_value) * 1e12d,
                        EnergyDensityUnit.TerawattHourPerCubicMeter => (_value * 3.6e+3) * 1e12d,
                        EnergyDensityUnit.WattHourPerCubicMeter => _value * 3.6e+3,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(EnergyDensityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        EnergyDensityUnit.GigajoulePerCubicMeter => (baseUnitValue) / 1e9d,
                        EnergyDensityUnit.GigawattHourPerCubicMeter => (baseUnitValue / 3.6e+3) / 1e9d,
                        EnergyDensityUnit.JoulePerCubicMeter => baseUnitValue,
                        EnergyDensityUnit.KilojoulePerCubicMeter => (baseUnitValue) / 1e3d,
                        EnergyDensityUnit.KilowattHourPerCubicMeter => (baseUnitValue / 3.6e+3) / 1e3d,
                        EnergyDensityUnit.MegajoulePerCubicMeter => (baseUnitValue) / 1e6d,
                        EnergyDensityUnit.MegawattHourPerCubicMeter => (baseUnitValue / 3.6e+3) / 1e6d,
                        EnergyDensityUnit.PetajoulePerCubicMeter => (baseUnitValue) / 1e15d,
                        EnergyDensityUnit.PetawattHourPerCubicMeter => (baseUnitValue / 3.6e+3) / 1e15d,
                        EnergyDensityUnit.TerajoulePerCubicMeter => (baseUnitValue) / 1e12d,
                        EnergyDensityUnit.TerawattHourPerCubicMeter => (baseUnitValue / 3.6e+3) / 1e12d,
                        EnergyDensityUnit.WattHourPerCubicMeter => baseUnitValue / 3.6e+3,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

