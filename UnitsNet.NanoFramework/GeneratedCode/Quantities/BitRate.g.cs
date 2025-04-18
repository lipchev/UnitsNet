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
    ///     In telecommunications and computing, bit rate is the number of bits that are conveyed or processed per unit of time.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Bit_rate
    /// </remarks>
    public struct  BitRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly BitRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public BitRateUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public BitRate(double value, BitRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of BitRate, which is Second. All conversions go via this value.
        /// </summary>
        public static BitRateUnit BaseUnit { get; } = BitRateUnit.BitPerSecond;

        /// <summary>
        /// Represents the largest possible value of BitRate.
        /// </summary>
        public static BitRate MaxValue { get; } = new BitRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of BitRate.
        /// </summary>
        public static BitRate MinValue { get; } = new BitRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static BitRate Zero { get; } = new BitRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.BitPerSecond"/>
        /// </summary>
        public double BitsPerSecond => As(BitRateUnit.BitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.BytePerSecond"/>
        /// </summary>
        public double BytesPerSecond => As(BitRateUnit.BytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.ExabitPerSecond"/>
        /// </summary>
        public double ExabitsPerSecond => As(BitRateUnit.ExabitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.ExabytePerSecond"/>
        /// </summary>
        public double ExabytesPerSecond => As(BitRateUnit.ExabytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.ExbibitPerSecond"/>
        /// </summary>
        public double ExbibitsPerSecond => As(BitRateUnit.ExbibitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.ExbibytePerSecond"/>
        /// </summary>
        public double ExbibytesPerSecond => As(BitRateUnit.ExbibytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.GibibitPerSecond"/>
        /// </summary>
        public double GibibitsPerSecond => As(BitRateUnit.GibibitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.GibibytePerSecond"/>
        /// </summary>
        public double GibibytesPerSecond => As(BitRateUnit.GibibytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.GigabitPerSecond"/>
        /// </summary>
        public double GigabitsPerSecond => As(BitRateUnit.GigabitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.GigabytePerSecond"/>
        /// </summary>
        public double GigabytesPerSecond => As(BitRateUnit.GigabytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.KibibitPerSecond"/>
        /// </summary>
        public double KibibitsPerSecond => As(BitRateUnit.KibibitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.KibibytePerSecond"/>
        /// </summary>
        public double KibibytesPerSecond => As(BitRateUnit.KibibytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.KilobitPerSecond"/>
        /// </summary>
        public double KilobitsPerSecond => As(BitRateUnit.KilobitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.KilobytePerSecond"/>
        /// </summary>
        public double KilobytesPerSecond => As(BitRateUnit.KilobytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.MebibitPerSecond"/>
        /// </summary>
        public double MebibitsPerSecond => As(BitRateUnit.MebibitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.MebibytePerSecond"/>
        /// </summary>
        public double MebibytesPerSecond => As(BitRateUnit.MebibytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.MegabitPerSecond"/>
        /// </summary>
        public double MegabitsPerSecond => As(BitRateUnit.MegabitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.MegabytePerSecond"/>
        /// </summary>
        public double MegabytesPerSecond => As(BitRateUnit.MegabytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.PebibitPerSecond"/>
        /// </summary>
        public double PebibitsPerSecond => As(BitRateUnit.PebibitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.PebibytePerSecond"/>
        /// </summary>
        public double PebibytesPerSecond => As(BitRateUnit.PebibytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.PetabitPerSecond"/>
        /// </summary>
        public double PetabitsPerSecond => As(BitRateUnit.PetabitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.PetabytePerSecond"/>
        /// </summary>
        public double PetabytesPerSecond => As(BitRateUnit.PetabytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.TebibitPerSecond"/>
        /// </summary>
        public double TebibitsPerSecond => As(BitRateUnit.TebibitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.TebibytePerSecond"/>
        /// </summary>
        public double TebibytesPerSecond => As(BitRateUnit.TebibytePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.TerabitPerSecond"/>
        /// </summary>
        public double TerabitsPerSecond => As(BitRateUnit.TerabitPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="BitRateUnit.TerabytePerSecond"/>
        /// </summary>
        public double TerabytesPerSecond => As(BitRateUnit.TerabytePerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.BitPerSecond"/>.
        /// </summary>
        public static BitRate FromBitsPerSecond(double bitspersecond) => new BitRate(bitspersecond, BitRateUnit.BitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.BytePerSecond"/>.
        /// </summary>
        public static BitRate FromBytesPerSecond(double bytespersecond) => new BitRate(bytespersecond, BitRateUnit.BytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.ExabitPerSecond"/>.
        /// </summary>
        public static BitRate FromExabitsPerSecond(double exabitspersecond) => new BitRate(exabitspersecond, BitRateUnit.ExabitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.ExabytePerSecond"/>.
        /// </summary>
        public static BitRate FromExabytesPerSecond(double exabytespersecond) => new BitRate(exabytespersecond, BitRateUnit.ExabytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.ExbibitPerSecond"/>.
        /// </summary>
        public static BitRate FromExbibitsPerSecond(double exbibitspersecond) => new BitRate(exbibitspersecond, BitRateUnit.ExbibitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.ExbibytePerSecond"/>.
        /// </summary>
        public static BitRate FromExbibytesPerSecond(double exbibytespersecond) => new BitRate(exbibytespersecond, BitRateUnit.ExbibytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.GibibitPerSecond"/>.
        /// </summary>
        public static BitRate FromGibibitsPerSecond(double gibibitspersecond) => new BitRate(gibibitspersecond, BitRateUnit.GibibitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.GibibytePerSecond"/>.
        /// </summary>
        public static BitRate FromGibibytesPerSecond(double gibibytespersecond) => new BitRate(gibibytespersecond, BitRateUnit.GibibytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.GigabitPerSecond"/>.
        /// </summary>
        public static BitRate FromGigabitsPerSecond(double gigabitspersecond) => new BitRate(gigabitspersecond, BitRateUnit.GigabitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.GigabytePerSecond"/>.
        /// </summary>
        public static BitRate FromGigabytesPerSecond(double gigabytespersecond) => new BitRate(gigabytespersecond, BitRateUnit.GigabytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.KibibitPerSecond"/>.
        /// </summary>
        public static BitRate FromKibibitsPerSecond(double kibibitspersecond) => new BitRate(kibibitspersecond, BitRateUnit.KibibitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.KibibytePerSecond"/>.
        /// </summary>
        public static BitRate FromKibibytesPerSecond(double kibibytespersecond) => new BitRate(kibibytespersecond, BitRateUnit.KibibytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.KilobitPerSecond"/>.
        /// </summary>
        public static BitRate FromKilobitsPerSecond(double kilobitspersecond) => new BitRate(kilobitspersecond, BitRateUnit.KilobitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.KilobytePerSecond"/>.
        /// </summary>
        public static BitRate FromKilobytesPerSecond(double kilobytespersecond) => new BitRate(kilobytespersecond, BitRateUnit.KilobytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.MebibitPerSecond"/>.
        /// </summary>
        public static BitRate FromMebibitsPerSecond(double mebibitspersecond) => new BitRate(mebibitspersecond, BitRateUnit.MebibitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.MebibytePerSecond"/>.
        /// </summary>
        public static BitRate FromMebibytesPerSecond(double mebibytespersecond) => new BitRate(mebibytespersecond, BitRateUnit.MebibytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.MegabitPerSecond"/>.
        /// </summary>
        public static BitRate FromMegabitsPerSecond(double megabitspersecond) => new BitRate(megabitspersecond, BitRateUnit.MegabitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.MegabytePerSecond"/>.
        /// </summary>
        public static BitRate FromMegabytesPerSecond(double megabytespersecond) => new BitRate(megabytespersecond, BitRateUnit.MegabytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.PebibitPerSecond"/>.
        /// </summary>
        public static BitRate FromPebibitsPerSecond(double pebibitspersecond) => new BitRate(pebibitspersecond, BitRateUnit.PebibitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.PebibytePerSecond"/>.
        /// </summary>
        public static BitRate FromPebibytesPerSecond(double pebibytespersecond) => new BitRate(pebibytespersecond, BitRateUnit.PebibytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.PetabitPerSecond"/>.
        /// </summary>
        public static BitRate FromPetabitsPerSecond(double petabitspersecond) => new BitRate(petabitspersecond, BitRateUnit.PetabitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.PetabytePerSecond"/>.
        /// </summary>
        public static BitRate FromPetabytesPerSecond(double petabytespersecond) => new BitRate(petabytespersecond, BitRateUnit.PetabytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.TebibitPerSecond"/>.
        /// </summary>
        public static BitRate FromTebibitsPerSecond(double tebibitspersecond) => new BitRate(tebibitspersecond, BitRateUnit.TebibitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.TebibytePerSecond"/>.
        /// </summary>
        public static BitRate FromTebibytesPerSecond(double tebibytespersecond) => new BitRate(tebibytespersecond, BitRateUnit.TebibytePerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.TerabitPerSecond"/>.
        /// </summary>
        public static BitRate FromTerabitsPerSecond(double terabitspersecond) => new BitRate(terabitspersecond, BitRateUnit.TerabitPerSecond);

        /// <summary>
        ///     Creates a <see cref="BitRate"/> from <see cref="BitRateUnit.TerabytePerSecond"/>.
        /// </summary>
        public static BitRate FromTerabytesPerSecond(double terabytespersecond) => new BitRate(terabytespersecond, BitRateUnit.TerabytePerSecond);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="BitRateUnit" /> to <see cref="BitRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>BitRate unit value.</returns>
        public static BitRate From(double value, BitRateUnit fromUnit)
        {
            return new BitRate(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(BitRateUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this BitRate to another BitRate with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A BitRate with the specified unit.</returns>
                public BitRate ToUnit(BitRateUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new BitRate(convertedValue, unit);
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
                        BitRateUnit.BitPerSecond => _value,
                        BitRateUnit.BytePerSecond => _value * 8,
                        BitRateUnit.ExabitPerSecond => (_value) * 1e18d,
                        BitRateUnit.ExabytePerSecond => (_value * 8) * 1e18d,
                        BitRateUnit.ExbibitPerSecond => (_value) * (1024d * 1024 * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.ExbibytePerSecond => (_value * 8) * (1024d * 1024 * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.GibibitPerSecond => (_value) * (1024d * 1024 * 1024),
                        BitRateUnit.GibibytePerSecond => (_value * 8) * (1024d * 1024 * 1024),
                        BitRateUnit.GigabitPerSecond => (_value) * 1e9d,
                        BitRateUnit.GigabytePerSecond => (_value * 8) * 1e9d,
                        BitRateUnit.KibibitPerSecond => (_value) * 1024d,
                        BitRateUnit.KibibytePerSecond => (_value * 8) * 1024d,
                        BitRateUnit.KilobitPerSecond => (_value) * 1e3d,
                        BitRateUnit.KilobytePerSecond => (_value * 8) * 1e3d,
                        BitRateUnit.MebibitPerSecond => (_value) * (1024d * 1024),
                        BitRateUnit.MebibytePerSecond => (_value * 8) * (1024d * 1024),
                        BitRateUnit.MegabitPerSecond => (_value) * 1e6d,
                        BitRateUnit.MegabytePerSecond => (_value * 8) * 1e6d,
                        BitRateUnit.PebibitPerSecond => (_value) * (1024d * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.PebibytePerSecond => (_value * 8) * (1024d * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.PetabitPerSecond => (_value) * 1e15d,
                        BitRateUnit.PetabytePerSecond => (_value * 8) * 1e15d,
                        BitRateUnit.TebibitPerSecond => (_value) * (1024d * 1024 * 1024 * 1024),
                        BitRateUnit.TebibytePerSecond => (_value * 8) * (1024d * 1024 * 1024 * 1024),
                        BitRateUnit.TerabitPerSecond => (_value) * 1e12d,
                        BitRateUnit.TerabytePerSecond => (_value * 8) * 1e12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(BitRateUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        BitRateUnit.BitPerSecond => baseUnitValue,
                        BitRateUnit.BytePerSecond => baseUnitValue / 8,
                        BitRateUnit.ExabitPerSecond => (baseUnitValue) / 1e18d,
                        BitRateUnit.ExabytePerSecond => (baseUnitValue / 8) / 1e18d,
                        BitRateUnit.ExbibitPerSecond => (baseUnitValue) / (1024d * 1024 * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.ExbibytePerSecond => (baseUnitValue / 8) / (1024d * 1024 * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.GibibitPerSecond => (baseUnitValue) / (1024d * 1024 * 1024),
                        BitRateUnit.GibibytePerSecond => (baseUnitValue / 8) / (1024d * 1024 * 1024),
                        BitRateUnit.GigabitPerSecond => (baseUnitValue) / 1e9d,
                        BitRateUnit.GigabytePerSecond => (baseUnitValue / 8) / 1e9d,
                        BitRateUnit.KibibitPerSecond => (baseUnitValue) / 1024d,
                        BitRateUnit.KibibytePerSecond => (baseUnitValue / 8) / 1024d,
                        BitRateUnit.KilobitPerSecond => (baseUnitValue) / 1e3d,
                        BitRateUnit.KilobytePerSecond => (baseUnitValue / 8) / 1e3d,
                        BitRateUnit.MebibitPerSecond => (baseUnitValue) / (1024d * 1024),
                        BitRateUnit.MebibytePerSecond => (baseUnitValue / 8) / (1024d * 1024),
                        BitRateUnit.MegabitPerSecond => (baseUnitValue) / 1e6d,
                        BitRateUnit.MegabytePerSecond => (baseUnitValue / 8) / 1e6d,
                        BitRateUnit.PebibitPerSecond => (baseUnitValue) / (1024d * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.PebibytePerSecond => (baseUnitValue / 8) / (1024d * 1024 * 1024 * 1024 * 1024),
                        BitRateUnit.PetabitPerSecond => (baseUnitValue) / 1e15d,
                        BitRateUnit.PetabytePerSecond => (baseUnitValue / 8) / 1e15d,
                        BitRateUnit.TebibitPerSecond => (baseUnitValue) / (1024d * 1024 * 1024 * 1024),
                        BitRateUnit.TebibytePerSecond => (baseUnitValue / 8) / (1024d * 1024 * 1024 * 1024),
                        BitRateUnit.TerabitPerSecond => (baseUnitValue) / 1e12d,
                        BitRateUnit.TerabytePerSecond => (baseUnitValue / 8) / 1e12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

