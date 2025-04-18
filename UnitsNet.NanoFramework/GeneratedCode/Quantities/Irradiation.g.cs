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
    ///     Irradiation is the process by which an object is exposed to radiation. The exposure can originate from various sources, including natural sources.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Irradiation
    /// </remarks>
    public struct  Irradiation
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly IrradiationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public IrradiationUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Irradiation(double value, IrradiationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Irradiation, which is Second. All conversions go via this value.
        /// </summary>
        public static IrradiationUnit BaseUnit { get; } = IrradiationUnit.JoulePerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Irradiation.
        /// </summary>
        public static Irradiation MaxValue { get; } = new Irradiation(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Irradiation.
        /// </summary>
        public static Irradiation MinValue { get; } = new Irradiation(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Irradiation Zero { get; } = new Irradiation(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.BtuPerSquareFoot"/>
        /// </summary>
        public double BtusPerSquareFoot => As(IrradiationUnit.BtuPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.JoulePerSquareCentimeter"/>
        /// </summary>
        public double JoulesPerSquareCentimeter => As(IrradiationUnit.JoulePerSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.JoulePerSquareMeter"/>
        /// </summary>
        public double JoulesPerSquareMeter => As(IrradiationUnit.JoulePerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.JoulePerSquareMillimeter"/>
        /// </summary>
        public double JoulesPerSquareMillimeter => As(IrradiationUnit.JoulePerSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.KilobtuPerSquareFoot"/>
        /// </summary>
        public double KilobtusPerSquareFoot => As(IrradiationUnit.KilobtuPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.KilojoulePerSquareMeter"/>
        /// </summary>
        public double KilojoulesPerSquareMeter => As(IrradiationUnit.KilojoulePerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.KilowattHourPerSquareMeter"/>
        /// </summary>
        public double KilowattHoursPerSquareMeter => As(IrradiationUnit.KilowattHourPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.MillijoulePerSquareCentimeter"/>
        /// </summary>
        public double MillijoulesPerSquareCentimeter => As(IrradiationUnit.MillijoulePerSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="IrradiationUnit.WattHourPerSquareMeter"/>
        /// </summary>
        public double WattHoursPerSquareMeter => As(IrradiationUnit.WattHourPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.BtuPerSquareFoot"/>.
        /// </summary>
        public static Irradiation FromBtusPerSquareFoot(double btuspersquarefoot) => new Irradiation(btuspersquarefoot, IrradiationUnit.BtuPerSquareFoot);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.JoulePerSquareCentimeter"/>.
        /// </summary>
        public static Irradiation FromJoulesPerSquareCentimeter(double joulespersquarecentimeter) => new Irradiation(joulespersquarecentimeter, IrradiationUnit.JoulePerSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.JoulePerSquareMeter"/>.
        /// </summary>
        public static Irradiation FromJoulesPerSquareMeter(double joulespersquaremeter) => new Irradiation(joulespersquaremeter, IrradiationUnit.JoulePerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.JoulePerSquareMillimeter"/>.
        /// </summary>
        public static Irradiation FromJoulesPerSquareMillimeter(double joulespersquaremillimeter) => new Irradiation(joulespersquaremillimeter, IrradiationUnit.JoulePerSquareMillimeter);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.KilobtuPerSquareFoot"/>.
        /// </summary>
        public static Irradiation FromKilobtusPerSquareFoot(double kilobtuspersquarefoot) => new Irradiation(kilobtuspersquarefoot, IrradiationUnit.KilobtuPerSquareFoot);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.KilojoulePerSquareMeter"/>.
        /// </summary>
        public static Irradiation FromKilojoulesPerSquareMeter(double kilojoulespersquaremeter) => new Irradiation(kilojoulespersquaremeter, IrradiationUnit.KilojoulePerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.KilowattHourPerSquareMeter"/>.
        /// </summary>
        public static Irradiation FromKilowattHoursPerSquareMeter(double kilowatthourspersquaremeter) => new Irradiation(kilowatthourspersquaremeter, IrradiationUnit.KilowattHourPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.MillijoulePerSquareCentimeter"/>.
        /// </summary>
        public static Irradiation FromMillijoulesPerSquareCentimeter(double millijoulespersquarecentimeter) => new Irradiation(millijoulespersquarecentimeter, IrradiationUnit.MillijoulePerSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="Irradiation"/> from <see cref="IrradiationUnit.WattHourPerSquareMeter"/>.
        /// </summary>
        public static Irradiation FromWattHoursPerSquareMeter(double watthourspersquaremeter) => new Irradiation(watthourspersquaremeter, IrradiationUnit.WattHourPerSquareMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="IrradiationUnit" /> to <see cref="Irradiation" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Irradiation unit value.</returns>
        public static Irradiation From(double value, IrradiationUnit fromUnit)
        {
            return new Irradiation(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(IrradiationUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Irradiation to another Irradiation with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Irradiation with the specified unit.</returns>
                public Irradiation ToUnit(IrradiationUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Irradiation(convertedValue, unit);
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
                        IrradiationUnit.BtuPerSquareFoot => _value * 1055.05585262 / 9.290304e-2,
                        IrradiationUnit.JoulePerSquareCentimeter => _value * 1e4,
                        IrradiationUnit.JoulePerSquareMeter => _value,
                        IrradiationUnit.JoulePerSquareMillimeter => _value * 1e6,
                        IrradiationUnit.KilobtuPerSquareFoot => (_value * 1055.05585262 / 9.290304e-2) * 1e3d,
                        IrradiationUnit.KilojoulePerSquareMeter => (_value) * 1e3d,
                        IrradiationUnit.KilowattHourPerSquareMeter => (_value * 3600d) * 1e3d,
                        IrradiationUnit.MillijoulePerSquareCentimeter => (_value * 1e4) * 1e-3d,
                        IrradiationUnit.WattHourPerSquareMeter => _value * 3600d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(IrradiationUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        IrradiationUnit.BtuPerSquareFoot => baseUnitValue * 9.290304e-2 / 1055.05585262,
                        IrradiationUnit.JoulePerSquareCentimeter => baseUnitValue / 1e4,
                        IrradiationUnit.JoulePerSquareMeter => baseUnitValue,
                        IrradiationUnit.JoulePerSquareMillimeter => baseUnitValue / 1e6,
                        IrradiationUnit.KilobtuPerSquareFoot => (baseUnitValue * 9.290304e-2 / 1055.05585262) / 1e3d,
                        IrradiationUnit.KilojoulePerSquareMeter => (baseUnitValue) / 1e3d,
                        IrradiationUnit.KilowattHourPerSquareMeter => (baseUnitValue / 3600d) / 1e3d,
                        IrradiationUnit.MillijoulePerSquareCentimeter => (baseUnitValue / 1e4) / 1e-3d,
                        IrradiationUnit.WattHourPerSquareMeter => baseUnitValue / 3600d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

