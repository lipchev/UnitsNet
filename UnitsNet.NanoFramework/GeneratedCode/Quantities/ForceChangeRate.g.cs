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
    ///     Force change rate is the ratio of the force change to the time during which the change occurred (value of force changes per unit time).
    /// </summary>
    public struct  ForceChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ForceChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ForceChangeRateUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ForceChangeRate(double value, ForceChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ForceChangeRate, which is Second. All conversions go via this value.
        /// </summary>
        public static ForceChangeRateUnit BaseUnit { get; } = ForceChangeRateUnit.NewtonPerSecond;

        /// <summary>
        /// Represents the largest possible value of ForceChangeRate.
        /// </summary>
        public static ForceChangeRate MaxValue { get; } = new ForceChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ForceChangeRate.
        /// </summary>
        public static ForceChangeRate MinValue { get; } = new ForceChangeRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ForceChangeRate Zero { get; } = new ForceChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.CentinewtonPerSecond"/>
        /// </summary>
        public double CentinewtonsPerSecond => As(ForceChangeRateUnit.CentinewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.DecanewtonPerMinute"/>
        /// </summary>
        public double DecanewtonsPerMinute => As(ForceChangeRateUnit.DecanewtonPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.DecanewtonPerSecond"/>
        /// </summary>
        public double DecanewtonsPerSecond => As(ForceChangeRateUnit.DecanewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.DecinewtonPerSecond"/>
        /// </summary>
        public double DecinewtonsPerSecond => As(ForceChangeRateUnit.DecinewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.KilonewtonPerMinute"/>
        /// </summary>
        public double KilonewtonsPerMinute => As(ForceChangeRateUnit.KilonewtonPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.KilonewtonPerSecond"/>
        /// </summary>
        public double KilonewtonsPerSecond => As(ForceChangeRateUnit.KilonewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.KilopoundForcePerMinute"/>
        /// </summary>
        public double KilopoundsForcePerMinute => As(ForceChangeRateUnit.KilopoundForcePerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.KilopoundForcePerSecond"/>
        /// </summary>
        public double KilopoundsForcePerSecond => As(ForceChangeRateUnit.KilopoundForcePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.MicronewtonPerSecond"/>
        /// </summary>
        public double MicronewtonsPerSecond => As(ForceChangeRateUnit.MicronewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.MillinewtonPerSecond"/>
        /// </summary>
        public double MillinewtonsPerSecond => As(ForceChangeRateUnit.MillinewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.NanonewtonPerSecond"/>
        /// </summary>
        public double NanonewtonsPerSecond => As(ForceChangeRateUnit.NanonewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.NewtonPerMinute"/>
        /// </summary>
        public double NewtonsPerMinute => As(ForceChangeRateUnit.NewtonPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.NewtonPerSecond"/>
        /// </summary>
        public double NewtonsPerSecond => As(ForceChangeRateUnit.NewtonPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.PoundForcePerMinute"/>
        /// </summary>
        public double PoundsForcePerMinute => As(ForceChangeRateUnit.PoundForcePerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ForceChangeRateUnit.PoundForcePerSecond"/>
        /// </summary>
        public double PoundsForcePerSecond => As(ForceChangeRateUnit.PoundForcePerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.CentinewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromCentinewtonsPerSecond(double centinewtonspersecond) => new ForceChangeRate(centinewtonspersecond, ForceChangeRateUnit.CentinewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.DecanewtonPerMinute"/>.
        /// </summary>
        public static ForceChangeRate FromDecanewtonsPerMinute(double decanewtonsperminute) => new ForceChangeRate(decanewtonsperminute, ForceChangeRateUnit.DecanewtonPerMinute);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.DecanewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromDecanewtonsPerSecond(double decanewtonspersecond) => new ForceChangeRate(decanewtonspersecond, ForceChangeRateUnit.DecanewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.DecinewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromDecinewtonsPerSecond(double decinewtonspersecond) => new ForceChangeRate(decinewtonspersecond, ForceChangeRateUnit.DecinewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.KilonewtonPerMinute"/>.
        /// </summary>
        public static ForceChangeRate FromKilonewtonsPerMinute(double kilonewtonsperminute) => new ForceChangeRate(kilonewtonsperminute, ForceChangeRateUnit.KilonewtonPerMinute);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.KilonewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromKilonewtonsPerSecond(double kilonewtonspersecond) => new ForceChangeRate(kilonewtonspersecond, ForceChangeRateUnit.KilonewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.KilopoundForcePerMinute"/>.
        /// </summary>
        public static ForceChangeRate FromKilopoundsForcePerMinute(double kilopoundsforceperminute) => new ForceChangeRate(kilopoundsforceperminute, ForceChangeRateUnit.KilopoundForcePerMinute);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.KilopoundForcePerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromKilopoundsForcePerSecond(double kilopoundsforcepersecond) => new ForceChangeRate(kilopoundsforcepersecond, ForceChangeRateUnit.KilopoundForcePerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.MicronewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromMicronewtonsPerSecond(double micronewtonspersecond) => new ForceChangeRate(micronewtonspersecond, ForceChangeRateUnit.MicronewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.MillinewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromMillinewtonsPerSecond(double millinewtonspersecond) => new ForceChangeRate(millinewtonspersecond, ForceChangeRateUnit.MillinewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.NanonewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromNanonewtonsPerSecond(double nanonewtonspersecond) => new ForceChangeRate(nanonewtonspersecond, ForceChangeRateUnit.NanonewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.NewtonPerMinute"/>.
        /// </summary>
        public static ForceChangeRate FromNewtonsPerMinute(double newtonsperminute) => new ForceChangeRate(newtonsperminute, ForceChangeRateUnit.NewtonPerMinute);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.NewtonPerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromNewtonsPerSecond(double newtonspersecond) => new ForceChangeRate(newtonspersecond, ForceChangeRateUnit.NewtonPerSecond);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.PoundForcePerMinute"/>.
        /// </summary>
        public static ForceChangeRate FromPoundsForcePerMinute(double poundsforceperminute) => new ForceChangeRate(poundsforceperminute, ForceChangeRateUnit.PoundForcePerMinute);

        /// <summary>
        ///     Creates a <see cref="ForceChangeRate"/> from <see cref="ForceChangeRateUnit.PoundForcePerSecond"/>.
        /// </summary>
        public static ForceChangeRate FromPoundsForcePerSecond(double poundsforcepersecond) => new ForceChangeRate(poundsforcepersecond, ForceChangeRateUnit.PoundForcePerSecond);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ForceChangeRateUnit" /> to <see cref="ForceChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ForceChangeRate unit value.</returns>
        public static ForceChangeRate From(double value, ForceChangeRateUnit fromUnit)
        {
            return new ForceChangeRate(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ForceChangeRateUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ForceChangeRate to another ForceChangeRate with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ForceChangeRate with the specified unit.</returns>
                public ForceChangeRate ToUnit(ForceChangeRateUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ForceChangeRate(convertedValue, unit);
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
                        ForceChangeRateUnit.CentinewtonPerSecond => (_value) * 1e-2d,
                        ForceChangeRateUnit.DecanewtonPerMinute => (_value / 60) * 1e1d,
                        ForceChangeRateUnit.DecanewtonPerSecond => (_value) * 1e1d,
                        ForceChangeRateUnit.DecinewtonPerSecond => (_value) * 1e-1d,
                        ForceChangeRateUnit.KilonewtonPerMinute => (_value / 60) * 1e3d,
                        ForceChangeRateUnit.KilonewtonPerSecond => (_value) * 1e3d,
                        ForceChangeRateUnit.KilopoundForcePerMinute => (_value * 4.4482216152605 / 60) * 1e3d,
                        ForceChangeRateUnit.KilopoundForcePerSecond => (_value * 4.4482216152605) * 1e3d,
                        ForceChangeRateUnit.MicronewtonPerSecond => (_value) * 1e-6d,
                        ForceChangeRateUnit.MillinewtonPerSecond => (_value) * 1e-3d,
                        ForceChangeRateUnit.NanonewtonPerSecond => (_value) * 1e-9d,
                        ForceChangeRateUnit.NewtonPerMinute => _value / 60,
                        ForceChangeRateUnit.NewtonPerSecond => _value,
                        ForceChangeRateUnit.PoundForcePerMinute => _value * 4.4482216152605 / 60,
                        ForceChangeRateUnit.PoundForcePerSecond => _value * 4.4482216152605,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ForceChangeRateUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ForceChangeRateUnit.CentinewtonPerSecond => (baseUnitValue) / 1e-2d,
                        ForceChangeRateUnit.DecanewtonPerMinute => (baseUnitValue * 60) / 1e1d,
                        ForceChangeRateUnit.DecanewtonPerSecond => (baseUnitValue) / 1e1d,
                        ForceChangeRateUnit.DecinewtonPerSecond => (baseUnitValue) / 1e-1d,
                        ForceChangeRateUnit.KilonewtonPerMinute => (baseUnitValue * 60) / 1e3d,
                        ForceChangeRateUnit.KilonewtonPerSecond => (baseUnitValue) / 1e3d,
                        ForceChangeRateUnit.KilopoundForcePerMinute => (baseUnitValue / 4.4482216152605 * 60) / 1e3d,
                        ForceChangeRateUnit.KilopoundForcePerSecond => (baseUnitValue / 4.4482216152605) / 1e3d,
                        ForceChangeRateUnit.MicronewtonPerSecond => (baseUnitValue) / 1e-6d,
                        ForceChangeRateUnit.MillinewtonPerSecond => (baseUnitValue) / 1e-3d,
                        ForceChangeRateUnit.NanonewtonPerSecond => (baseUnitValue) / 1e-9d,
                        ForceChangeRateUnit.NewtonPerMinute => baseUnitValue * 60,
                        ForceChangeRateUnit.NewtonPerSecond => baseUnitValue,
                        ForceChangeRateUnit.PoundForcePerMinute => baseUnitValue / 4.4482216152605 * 60,
                        ForceChangeRateUnit.PoundForcePerSecond => baseUnitValue / 4.4482216152605,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

