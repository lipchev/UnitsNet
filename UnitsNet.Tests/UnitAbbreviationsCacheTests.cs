﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using UnitsNet.Tests.CustomQuantities;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    [Collection(nameof(UnitAbbreviationsCacheFixture))]
    public class UnitAbbreviationsCacheTests
    {
        private const string AmericanCultureName = "en-US";
        private const string RussianCultureName = "ru-RU";
        private const string NorwegianCultureName = "nb-NO";

        private static readonly IFormatProvider AmericanCulture = CultureInfo.GetCultureInfo(AmericanCultureName);
        private static readonly IFormatProvider NorwegianCulture = CultureInfo.GetCultureInfo(NorwegianCultureName);
        private static readonly IFormatProvider RussianCulture = CultureInfo.GetCultureInfo(RussianCultureName);

        // The default, parameterless ToString() method uses 2 significant digits after the radix point.
        [Theory]
        [InlineData(0, "0 m")]
        [InlineData(0.1, "0.1 m")]
        [InlineData(0.11, "0.11 m")]
        [InlineData(0.111234, "0.11 m")]
        [InlineData(0.115, "0.12 m")]
        public void DefaultToStringFormatting(double value, string expected)
        {
            string actual = Length.FromMeters(value).ToUnit(LengthUnit.Meter).ToString(AmericanCulture);
            Assert.Equal(expected, actual);
        }

        private enum CustomUnit
        {
            // ReSharper disable UnusedMember.Local
            Undefined = 0,
            Unit1,
            Unit2
            // ReSharper restore UnusedMember.Local
        }

        [Theory]
        [InlineData("de-DE")]
        [InlineData("da-DK")]
        [InlineData("es-AR")]
        [InlineData("es-ES")]
        [InlineData("it-IT")]
        [InlineData("en-CA")]
        [InlineData("en-US")]
        [InlineData("ar-EG")]
        [InlineData("en-GB")]
        [InlineData("es-MX")]
        public void RadixPointCultureFormatting(string cultureName)
        {
            CultureInfo culture = GetCulture(cultureName);
            string ds = culture.NumberFormat.NumberDecimalSeparator;
            Assert.Equal($"0{ds}12 m", Length.FromMeters(0.12).ToUnit(LengthUnit.Meter).ToString(culture));
        }

        [Theory]
        [InlineData("en-CA")]
        [InlineData("en-GB")]
        [InlineData("en-US")]
        [InlineData("ar-EG")]
        [InlineData("es-MX")]
        [InlineData("nn-NO")]
        [InlineData("fr-FR")]
        [InlineData("de-DE")]
        [InlineData("da-DK")]
        [InlineData("es-AR")]
        [InlineData("es-ES")]
        [InlineData("it-IT")]
        public void DigitGroupingCultureFormatting(string cultureName)
        {
            CultureInfo culture = GetCulture(cultureName);
            string gs = culture.NumberFormat.NumberGroupSeparator;

            Assert.Equal($"1{gs}111 m", Length.FromMeters(1111).ToUnit(LengthUnit.Meter).ToString(culture));

            // Feet/Inch and Stone/Pound combinations are only used (customarily) in the US, UK and maybe Ireland - all English speaking countries.
            // FeetInches returns a whole number of feet, with the remainder expressed (rounded) in inches. Same for StonePounds.
            Assert.Equal($"2{gs}222 ft 3 in",
                Length.FromFeetInches(2222, 3).FeetInches.ToString(culture));
            Assert.Equal($"3{gs}333 st 7 lb",
                Mass.FromStonePounds(3333, 7).StonePounds.ToString(culture));
        }

        // Due to rounding, the values will result in the same string representation regardless of the number of significant digits (up to a certain point)
        [Theory]
        [InlineData(0.819999999999, "s2", "0.82 m")]
        [InlineData(0.819999999999, "s4", "0.82 m")]
        [InlineData(0.00299999999, "s2", "0.003 m")]
        [InlineData(0.00299999999, "s4", "0.003 m")]
        [InlineData(0.0003000001, "s2", "3e-04 m")]
        [InlineData(0.0003000001, "s4", "3e-04 m")]
        public void RoundingErrorsWithSignificantDigitsAfterRadixFormatting(double value,
            string significantDigitsAfterRadixFormatString, string expected)
        {
            string actual = Length.FromMeters(value).ToUnit(LengthUnit.Meter).ToString(significantDigitsAfterRadixFormatString, AmericanCulture);
            Assert.Equal(expected, actual);
        }

        // Any value in the interval (-inf ≤ x < 1e-03] is formatted in scientific notation
        [Theory]
        [InlineData(double.MinValue, "-1.8e+308 m")]
        [InlineData(1.23e-120, "1.23e-120 m")]
        [InlineData(0.0000111, "1.11e-05 m")]
        [InlineData(1.99e-4, "1.99e-04 m")]
        public void ScientificNotationLowerInterval(double value, string expected)
        {
            string actual = Length.FromMeters(value).ToUnit(LengthUnit.Meter).ToString(AmericanCulture);
            Assert.Equal(expected, actual);
        }

        // Any value in the interval [1e-03 ≤ x < 1e+03] is formatted in fixed point notation.
        [Theory]
        [InlineData(1e-3, "0.001 m")]
        [InlineData(1.1, "1.1 m")]
        [InlineData(999.99, "999.99 m")]
        public void FixedPointNotationIntervalFormatting(double value, string expected)
        {
            string actual = Length.FromMeters(value).ToUnit(LengthUnit.Meter).ToString(AmericanCulture);
            Assert.Equal(expected, actual);
        }

        // Any value in the interval [1e+03 ≤ x < 1e+06] is formatted in fixed point notation with digit grouping.
        [Theory]
        [InlineData(1000, "1,000 m")]
        [InlineData(11000, "11,000 m")]
        [InlineData(111000, "111,000 m")]
        [InlineData(999999.99, "999,999.99 m")]
        public void FixedPointNotationWithDigitGroupingIntervalFormatting(double value, string expected)
        {
            string actual = Length.FromMeters(value).ToUnit(LengthUnit.Meter).ToString(AmericanCulture);
            Assert.Equal(expected, actual);
        }

        // Any value in the interval [1e+06 ≤ x ≤ +inf) is formatted in scientific notation.
        [Theory]
        [InlineData(1e6, "1e+06 m")]
        [InlineData(11100000, "1.11e+07 m")]
        [InlineData(double.MaxValue, "1.8e+308 m")]
        public void ScientificNotationUpperIntervalFormatting(double value, string expected)
        {
            string actual = Length.FromMeters(value).ToUnit(LengthUnit.Meter).ToString(AmericanCulture);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllUnitsImplementToStringForInvariantCulture()
        {
            Assert.Equal("1 °", Angle.FromDegrees(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 m²", Area.FromSquareMeters(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 V", ElectricPotential.FromVolts(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 N", Force.FromNewtons(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 m", Length.FromMeters(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 kg", Mass.FromKilograms(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 Pa", Pressure.FromPascals(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 rad/s", RotationalSpeed.FromRadiansPerSecond(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 K", Temperature.FromKelvins(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 N·m", Torque.FromNewtonMeters(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 m³", Volume.FromCubicMeters(1).ToString(CultureInfo.InvariantCulture));
            Assert.Equal("1 m³/s", VolumeFlow.FromCubicMetersPerSecond(1).ToString(CultureInfo.InvariantCulture));

            Assert.Equal("2 ft 3 in", Length.FromFeetInches(2, 3).FeetInches.ToString(CultureInfo.InvariantCulture));
            Assert.Equal("3 st 7 lb", Mass.FromStonePounds(3, 7).StonePounds.ToString(CultureInfo.InvariantCulture));
        }

        [Fact]
        public void ToString_WithNorwegianCulture()
        {
            Assert.Equal("1 °", Angle.FromDegrees(1).ToUnit(AngleUnit.Degree).ToString(NorwegianCulture));
            Assert.Equal("1 m²", Area.FromSquareMeters(1).ToUnit(AreaUnit.SquareMeter).ToString(NorwegianCulture));
            Assert.Equal("1 V", ElectricPotential.FromVolts(1).ToUnit(ElectricPotentialUnit.Volt).ToString(NorwegianCulture));
            Assert.Equal("1 m³/s", VolumeFlow.FromCubicMetersPerSecond(1).ToUnit(VolumeFlowUnit.CubicMeterPerSecond).ToString(NorwegianCulture));
            Assert.Equal("1 N", Force.FromNewtons(1).ToUnit(ForceUnit.Newton).ToString(NorwegianCulture));
            Assert.Equal("1 m", Length.FromMeters(1).ToUnit(LengthUnit.Meter).ToString(NorwegianCulture));
            Assert.Equal("1 kg", Mass.FromKilograms(1).ToUnit(MassUnit.Kilogram).ToString(NorwegianCulture));
            Assert.Equal("1 Pa", Pressure.FromPascals(1).ToUnit(PressureUnit.Pascal).ToString(NorwegianCulture));
            Assert.Equal("1 rad/s", RotationalSpeed.FromRadiansPerSecond(1).ToUnit(RotationalSpeedUnit.RadianPerSecond).ToString(NorwegianCulture));
            Assert.Equal("1 K", Temperature.FromKelvins(1).ToUnit(TemperatureUnit.Kelvin).ToString(NorwegianCulture));
            Assert.Equal("1 N·m", Torque.FromNewtonMeters(1).ToUnit(TorqueUnit.NewtonMeter).ToString(NorwegianCulture));
            Assert.Equal("1 m³", Volume.FromCubicMeters(1).ToUnit(VolumeUnit.CubicMeter).ToString(NorwegianCulture));
        }

        [Fact]
        public void ToString_WithRussianCulture()
        {
            Assert.Equal("1 °", Angle.FromDegrees(1).ToUnit(AngleUnit.Degree).ToString(RussianCulture));
            Assert.Equal("1 м²", Area.FromSquareMeters(1).ToUnit(AreaUnit.SquareMeter).ToString(RussianCulture));
            Assert.Equal("1 В", ElectricPotential.FromVolts(1).ToUnit(ElectricPotentialUnit.Volt).ToString(RussianCulture));
            Assert.Equal("1 м³/с", VolumeFlow.FromCubicMetersPerSecond(1).ToUnit(VolumeFlowUnit.CubicMeterPerSecond).ToString(RussianCulture));
            Assert.Equal("1 Н", Force.FromNewtons(1).ToUnit(ForceUnit.Newton).ToString(RussianCulture));
            Assert.Equal("1 м", Length.FromMeters(1).ToUnit(LengthUnit.Meter).ToString(RussianCulture));
            Assert.Equal("1 кг", Mass.FromKilograms(1).ToUnit(MassUnit.Kilogram).ToString(RussianCulture));
            Assert.Equal("1 Па", Pressure.FromPascals(1).ToUnit(PressureUnit.Pascal).ToString(RussianCulture));
            Assert.Equal("1 рад/с", RotationalSpeed.FromRadiansPerSecond(1).ToUnit(RotationalSpeedUnit.RadianPerSecond).ToString(RussianCulture));
            Assert.Equal("1 K", Temperature.FromKelvins(1).ToUnit(TemperatureUnit.Kelvin).ToString(RussianCulture));
            Assert.Equal("1 Н·м", Torque.FromNewtonMeters(1).ToUnit(TorqueUnit.NewtonMeter).ToString(RussianCulture));
            Assert.Equal("1 м³", Volume.FromCubicMeters(1).ToUnit(VolumeUnit.CubicMeter).ToString(RussianCulture));
        }

        [Fact]
        public void GetDefaultAbbreviationThrowsNotImplementedExceptionIfNoneExist()
        {
            var unitAbbreviationCache = new UnitAbbreviationsCache();
            Assert.Throws<NotImplementedException>(() => unitAbbreviationCache.GetDefaultAbbreviation(CustomUnit.Unit1));
        }

        [Fact]
        public void GetDefaultAbbreviationFallsBackToUsEnglishCulture()
        {
            // CurrentCulture affects number formatting, such as comma or dot as decimal separator.
            // CurrentCulture also affects localization of unit abbreviations.
            // Zulu (South Africa)
            var zuluCulture = CultureInfo.GetCultureInfo("zu-ZA");
            // CultureInfo.CurrentCulture = zuluCulture;

            var abbreviationsCache = new UnitAbbreviationsCache();
            abbreviationsCache.MapUnitToAbbreviation(CustomUnit.Unit1, AmericanCulture, "US english abbreviation for Unit1");

            // Act
            string abbreviation = abbreviationsCache.GetDefaultAbbreviation(CustomUnit.Unit1, zuluCulture);

            // Assert
            Assert.Equal("US english abbreviation for Unit1", abbreviation);
        }

        [Fact]
        public void MapUnitToAbbreviation_DoesNotAffectOtherCacheInstances()
        {
            var culture = AmericanCulture;
            var unit = AreaUnit.SquareMeter;

            var cache1 = UnitAbbreviationsCache.CreateDefault();
            cache1.MapUnitToAbbreviation(unit, culture, "m^2");

            var cache2 = UnitAbbreviationsCache.CreateDefault();
            cache2.MapUnitToAbbreviation(unit, culture, "m2");

            Assert.Equal(new[] { "m²", "m^2" }, cache1.GetUnitAbbreviations(unit, culture));
            Assert.Equal(new[] { "m²", "m2" }, cache2.GetUnitAbbreviations(unit, culture));
            Assert.Equal("m²", cache1.GetDefaultAbbreviation(unit, culture));
            Assert.Equal("m²", cache2.GetDefaultAbbreviation(unit, culture));
        }

        [Fact]
        public void MapUnitToAbbreviation_AddCustomUnit_DoesNotOverrideDefaultAbbreviationForAlreadyMappedUnits()
        {
            var cache = UnitAbbreviationsCache.CreateDefault();
            cache.MapUnitToAbbreviation(AreaUnit.SquareMeter, AmericanCulture, "m^2");

            Assert.Equal("m²", cache.GetDefaultAbbreviation(AreaUnit.SquareMeter, AmericanCulture));
        }

        [Fact]
        public void MapUnitToDefaultAbbreviation_GivenUnitAndCulture_SetsDefaultAbbreviationForUnitAndCulture()
        {
            var cache = new UnitAbbreviationsCache();
            cache.MapUnitToDefaultAbbreviation(AreaUnit.SquareMeter, AmericanCulture, "m^2");

            Assert.Equal("m^2", cache.GetDefaultAbbreviation(AreaUnit.SquareMeter, AmericanCulture));
        }

        [Fact]
        public void MapUnitToDefaultAbbreviation_GivenCustomAbbreviation_SetsAbbreviationUsedByQuantityToString()
        {
            // Use a distinct culture here so that we don't mess up other tests that may rely on the default cache.
            var newZealandCulture = GetCulture("en-NZ");
            UnitsNetSetup.Default.UnitAbbreviations.MapUnitToDefaultAbbreviation(AreaUnit.SquareMeter, newZealandCulture, "m^2");

            Assert.Equal("1 m^2", Area.FromSquareMeters(1).ToString(newZealandCulture));
        }

        [Fact]
        public void MapUnitToAbbreviation_DoesNotInsertDuplicates()
        {
            var cache = new UnitAbbreviationsCache();

            cache.MapUnitToAbbreviation(HowMuchUnit.Some, "sm");
            cache.MapUnitToAbbreviation(HowMuchUnit.Some, "sm");
            cache.MapUnitToAbbreviation(HowMuchUnit.Some, "sm");

            Assert.Equal("sm", cache.GetDefaultAbbreviation(HowMuchUnit.Some));
            Assert.Equal(new[] { "sm" }, cache.GetUnitAbbreviations(HowMuchUnit.Some));
            Assert.Equal(new[] { "sm" }, cache.GetAllUnitAbbreviationsForQuantity(typeof(HowMuchUnit)));
        }

        [Fact]
        public void MapUnitToDefaultAbbreviation_Twice_SetsNewDefaultAndKeepsOrderOfExistingAbbreviations()
        {
            var cache = new UnitAbbreviationsCache();

            cache.MapUnitToAbbreviation(HowMuchUnit.Some, "sm");
            cache.MapUnitToDefaultAbbreviation(HowMuchUnit.Some, "1st default");
            cache.MapUnitToDefaultAbbreviation(HowMuchUnit.Some, "2nd default");

            Assert.Equal("2nd default", cache.GetDefaultAbbreviation(HowMuchUnit.Some));
            Assert.Equal(new[] { "2nd default", "1st default", "sm" }, cache.GetUnitAbbreviations(HowMuchUnit.Some));
        }

        /// <summary>
        /// Test that lookup works when specifying unit enum value both as cast to <see cref="Enum"/> and as specific enum value type.
        /// We have had subtle bugs when <see cref="Enum"/> is passed to generic methods with constraint TUnitEnum : Enum,
        /// which the Enum type satisfies, but trying to use typeof(TUnitEnum) no longer represent the actual enum type so unitEnumValue.GetType() should be used.
        /// </summary>
        [Fact]
        public void MapAndLookup_WithSpecificEnumType()
        {
            UnitAbbreviationsCache defaultUnitAbbreviations = UnitsNetSetup.Default.UnitAbbreviations;
            defaultUnitAbbreviations.MapUnitToDefaultAbbreviation(HowMuchUnit.Some, "sm");
            Assert.Equal("sm", defaultUnitAbbreviations.GetDefaultAbbreviation(HowMuchUnit.Some));
        }

        /// <inheritdoc cref="MapAndLookup_WithSpecificEnumType"/>
        [Fact]
        public void MapAndLookup_WithEnumType()
        {
            Enum valueAsEnumType = HowMuchUnit.Some;
            UnitAbbreviationsCache defaultUnitAbbreviations = UnitsNetSetup.Default.UnitAbbreviations;
            defaultUnitAbbreviations.MapUnitToDefaultAbbreviation(valueAsEnumType, "sm");
            Assert.Equal("sm", defaultUnitAbbreviations.GetDefaultAbbreviation(valueAsEnumType));
        }

        /// <inheritdoc cref="MapAndLookup_WithSpecificEnumType"/>
        [Fact]
        public void MapAndLookup_MapWithSpecificEnumType_LookupWithEnumType()
        {
            UnitAbbreviationsCache defaultUnitAbbreviations = UnitsNetSetup.Default.UnitAbbreviations;
            defaultUnitAbbreviations.MapUnitToDefaultAbbreviation(HowMuchUnit.Some, "sm");
            Assert.Equal("sm", defaultUnitAbbreviations.GetDefaultAbbreviation((Enum)HowMuchUnit.Some));
        }

        /// <summary>
        ///     Convenience method to the proper culture parameter type.
        /// </summary>
        private static CultureInfo GetCulture(string cultureName)
        {
            return CultureInfo.GetCultureInfo(cultureName);
        }
    }
}
