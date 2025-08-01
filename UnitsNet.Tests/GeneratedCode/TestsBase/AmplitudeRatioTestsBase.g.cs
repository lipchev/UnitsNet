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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.Helpers;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of AmplitudeRatio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AmplitudeRatioTestsBase : QuantityTestsBase
    {
        protected abstract double DecibelMicrovoltsInOneDecibelVolt { get; }
        protected abstract double DecibelMillivoltsInOneDecibelVolt { get; }
        protected abstract double DecibelsUnloadedInOneDecibelVolt { get; }
        protected abstract double DecibelVoltsInOneDecibelVolt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecibelMicrovoltsTolerance { get { return 1e-5; } }
        protected virtual double DecibelMillivoltsTolerance { get { return 1e-5; } }
        protected virtual double DecibelsUnloadedTolerance { get { return 1e-5; } }
        protected virtual double DecibelVoltsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(AmplitudeRatioUnit unit)
        {
            return unit switch
            {
                AmplitudeRatioUnit.DecibelMicrovolt => (DecibelMicrovoltsInOneDecibelVolt, DecibelMicrovoltsTolerance),
                AmplitudeRatioUnit.DecibelMillivolt => (DecibelMillivoltsInOneDecibelVolt, DecibelMillivoltsTolerance),
                AmplitudeRatioUnit.DecibelUnloaded => (DecibelsUnloadedInOneDecibelVolt, DecibelsUnloadedTolerance),
                AmplitudeRatioUnit.DecibelVolt => (DecibelVoltsInOneDecibelVolt, DecibelVoltsTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { AmplitudeRatioUnit.DecibelMicrovolt },
            new object[] { AmplitudeRatioUnit.DecibelMillivolt },
            new object[] { AmplitudeRatioUnit.DecibelUnloaded },
            new object[] { AmplitudeRatioUnit.DecibelVolt },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AmplitudeRatio();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AmplitudeRatioUnit.DecibelVolt, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new AmplitudeRatio(double.PositiveInfinity, AmplitudeRatioUnit.DecibelVolt));
            var exception2 = Record.Exception(() => new AmplitudeRatio(double.NegativeInfinity, AmplitudeRatioUnit.DecibelVolt));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new AmplitudeRatio(double.NaN, AmplitudeRatioUnit.DecibelVolt));

            Assert.Null(exception);
        }

        [Fact]
        public void AmplitudeRatio_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelVolt);

            QuantityInfo<AmplitudeRatioUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AmplitudeRatio.Zero, quantityInfo.Zero);
            Assert.Equal("AmplitudeRatio", quantityInfo.Name);

            var units = Enum.GetValues<AmplitudeRatioUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void DecibelVoltToAmplitudeRatioUnits()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            AssertEx.EqualTolerance(DecibelMicrovoltsInOneDecibelVolt, decibelvolt.DecibelMicrovolts, DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(DecibelMillivoltsInOneDecibelVolt, decibelvolt.DecibelMillivolts, DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(DecibelsUnloadedInOneDecibelVolt, decibelvolt.DecibelsUnloaded, DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(DecibelVoltsInOneDecibelVolt, decibelvolt.DecibelVolts, DecibelVoltsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelMicrovolt);
            AssertEx.EqualTolerance(1, quantity00.DecibelMicrovolts, DecibelMicrovoltsTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelMicrovolt, quantity00.Unit);

            var quantity01 = AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelMillivolt);
            AssertEx.EqualTolerance(1, quantity01.DecibelMillivolts, DecibelMillivoltsTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelMillivolt, quantity01.Unit);

            var quantity02 = AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelUnloaded);
            AssertEx.EqualTolerance(1, quantity02.DecibelsUnloaded, DecibelsUnloadedTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelUnloaded, quantity02.Unit);

            var quantity03 = AmplitudeRatio.From(1, AmplitudeRatioUnit.DecibelVolt);
            AssertEx.EqualTolerance(1, quantity03.DecibelVolts, DecibelVoltsTolerance);
            Assert.Equal(AmplitudeRatioUnit.DecibelVolt, quantity03.Unit);

        }

        [Fact]
        public void FromDecibelVolts_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => AmplitudeRatio.FromDecibelVolts(double.PositiveInfinity));
            var exception2 = Record.Exception(() => AmplitudeRatio.FromDecibelVolts(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromDecibelVolts_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => AmplitudeRatio.FromDecibelVolts(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            AssertEx.EqualTolerance(DecibelMicrovoltsInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelMicrovolt), DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(DecibelMillivoltsInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelMillivolt), DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(DecibelsUnloadedInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelUnloaded), DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(DecibelVoltsInOneDecibelVolt, decibelvolt.As(AmplitudeRatioUnit.DecibelVolt), DecibelVoltsTolerance);
        }

        [Fact]
        public void As_UnitSystem_ReturnsValueInDimensionlessUnit()
        {
            var quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatioUnit.DecibelVolt);

            var convertedValue = quantity.As(UnitSystem.SI);

            Assert.Equal(quantity.Value, convertedValue);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentNullExceptionIfNull()
        {
            var quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatio.BaseUnit);
            UnitSystem nullUnitSystem = null!;
            Assert.Throws<ArgumentNullException>(() => quantity.As(nullUnitSystem));
        }

        [Fact]
        public void ToUnitSystem_ReturnsValueInDimensionlessUnit()
        {
            Assert.Multiple(() =>
            {
                var quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatioUnit.DecibelVolt);

                AmplitudeRatio convertedQuantity = quantity.ToUnit(UnitSystem.SI);

                Assert.Equal(AmplitudeRatioUnit.DecibelVolt, convertedQuantity.Unit);
                Assert.Equal(quantity.Value, convertedQuantity.Value);
            }, () =>
            {
                IQuantity<AmplitudeRatioUnit> quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatioUnit.DecibelVolt);

                IQuantity<AmplitudeRatioUnit> convertedQuantity = quantity.ToUnit(UnitSystem.SI);

                Assert.Equal(AmplitudeRatioUnit.DecibelVolt, convertedQuantity.Unit);
                Assert.Equal(quantity.Value, convertedQuantity.Value);
            }, () =>
            {
                IQuantity quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatioUnit.DecibelVolt);

                IQuantity convertedQuantity = quantity.ToUnit(UnitSystem.SI);

                Assert.Equal(AmplitudeRatioUnit.DecibelVolt, convertedQuantity.Unit);
                Assert.Equal(quantity.Value, convertedQuantity.Value);
            });
        }

        [Fact]
        public void ToUnit_UnitSystem_ThrowsArgumentNullExceptionIfNull()
        {
            UnitSystem nullUnitSystem = null!;
            Assert.Multiple(() =>
            {
                var quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatio.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            }, () =>
            {
                IQuantity<AmplitudeRatioUnit> quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatio.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            }, () =>
            {
                IQuantity quantity = new AmplitudeRatio(value: 1, unit: AmplitudeRatio.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            });
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = AmplitudeRatio.Parse("1 dBµV", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelMicrovolts, DecibelMicrovoltsTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelMicrovolt, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = AmplitudeRatio.Parse("1 dBmV", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelMillivolts, DecibelMillivoltsTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelMillivolt, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = AmplitudeRatio.Parse("1 dBu", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelsUnloaded, DecibelsUnloadedTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelUnloaded, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = AmplitudeRatio.Parse("1 dBV", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecibelVolts, DecibelVoltsTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelVolt, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(AmplitudeRatio.TryParse("1 dBµV", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelMicrovolts, DecibelMicrovoltsTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelMicrovolt, parsed.Unit);
            }

            {
                Assert.True(AmplitudeRatio.TryParse("1 dBmV", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelMillivolts, DecibelMillivoltsTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelMillivolt, parsed.Unit);
            }

            {
                Assert.True(AmplitudeRatio.TryParse("1 dBu", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelsUnloaded, DecibelsUnloadedTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelUnloaded, parsed.Unit);
            }

            {
                Assert.True(AmplitudeRatio.TryParse("1 dBV", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecibelVolts, DecibelVoltsTolerance);
                Assert.Equal(AmplitudeRatioUnit.DecibelVolt, parsed.Unit);
            }

        }

        [Theory]
        [InlineData("dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void ParseUnit_WithUsEnglishCurrentCulture(string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            // Fallback culture "en-US" is always localized
            using var _ = new CultureScope("en-US");
            AmplitudeRatioUnit parsedUnit = AmplitudeRatio.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void ParseUnit_WithUnsupportedCurrentCulture_FallsBackToUsEnglish(string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            // Currently, no abbreviations are localized for Icelandic, so it should fall back to "en-US" when parsing.
            using var _ = new CultureScope("is-IS");
            AmplitudeRatioUnit parsedUnit = AmplitudeRatio.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("en-US", "dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("en-US", "dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("en-US", "dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void ParseUnit_WithCurrentCulture(string culture, string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            using var _ = new CultureScope(culture);
            AmplitudeRatioUnit parsedUnit = AmplitudeRatio.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("en-US", "dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("en-US", "dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("en-US", "dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void ParseUnit_WithCulture(string culture, string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            AmplitudeRatioUnit parsedUnit = AmplitudeRatio.ParseUnit(abbreviation, CultureInfo.GetCultureInfo(culture));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void TryParseUnit_WithUsEnglishCurrentCulture(string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            // Fallback culture "en-US" is always localized
            using var _ = new CultureScope("en-US");
            Assert.True(AmplitudeRatio.TryParseUnit(abbreviation, out AmplitudeRatioUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void TryParseUnit_WithUnsupportedCurrentCulture_FallsBackToUsEnglish(string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            // Currently, no abbreviations are localized for Icelandic, so it should fall back to "en-US" when parsing.
            using var _ = new CultureScope("is-IS");
            Assert.True(AmplitudeRatio.TryParseUnit(abbreviation, out AmplitudeRatioUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("en-US", "dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("en-US", "dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("en-US", "dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void TryParseUnit_WithCurrentCulture(string culture, string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            using var _ = new CultureScope(culture);
            Assert.True(AmplitudeRatio.TryParseUnit(abbreviation, out AmplitudeRatioUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "dBµV", AmplitudeRatioUnit.DecibelMicrovolt)]
        [InlineData("en-US", "dBmV", AmplitudeRatioUnit.DecibelMillivolt)]
        [InlineData("en-US", "dBu", AmplitudeRatioUnit.DecibelUnloaded)]
        [InlineData("en-US", "dBV", AmplitudeRatioUnit.DecibelVolt)]
        public void TryParseUnit_WithCulture(string culture, string abbreviation, AmplitudeRatioUnit expectedUnit)
        {
            Assert.True(AmplitudeRatio.TryParseUnit(abbreviation, CultureInfo.GetCultureInfo(culture), out AmplitudeRatioUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(AmplitudeRatioUnit unit)
        {
            var inBaseUnits = AmplitudeRatio.From(1.0, AmplitudeRatio.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(AmplitudeRatioUnit unit)
        {
            var quantity = AmplitudeRatio.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(AmplitudeRatioUnit unit)
        {
            Assert.All(AmplitudeRatio.Units.Where(u => u != AmplitudeRatio.BaseUnit), fromUnit =>
            {
                var quantity = AmplitudeRatio.From(3.0, fromUnit);
                var converted = quantity.ToUnit(unit);
                Assert.Equal(converted.Unit, unit);
            });
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(AmplitudeRatioUnit unit)
        {
            var quantity = default(AmplitudeRatio);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromIQuantity_ReturnsTheExpectedIQuantity(AmplitudeRatioUnit unit)
        {
            var quantity = AmplitudeRatio.From(3, AmplitudeRatio.BaseUnit);
            AmplitudeRatio expectedQuantity = quantity.ToUnit(unit);
            Assert.Multiple(() =>
            {
                IQuantity<AmplitudeRatioUnit> quantityToConvert = quantity;
                IQuantity<AmplitudeRatioUnit> convertedQuantity = quantityToConvert.ToUnit(unit);
                Assert.Equal(unit, convertedQuantity.Unit);
            }, () =>
            {
                IQuantity quantityToConvert = quantity;
                IQuantity convertedQuantity = quantityToConvert.ToUnit(unit);
                Assert.Equal(unit, convertedQuantity.Unit);
            });
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelMicrovolts(decibelvolt.DecibelMicrovolts).DecibelVolts, DecibelMicrovoltsTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelMillivolts(decibelvolt.DecibelMillivolts).DecibelVolts, DecibelMillivoltsTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelsUnloaded(decibelvolt.DecibelsUnloaded).DecibelVolts, DecibelsUnloadedTolerance);
            AssertEx.EqualTolerance(1, AmplitudeRatio.FromDecibelVolts(decibelvolt.DecibelVolts).DecibelVolts, DecibelVoltsTolerance);
        }

        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            AmplitudeRatio v = AmplitudeRatio.FromDecibelVolts(40);
            AssertEx.EqualTolerance(-40, -v.DecibelVolts, DecibelVoltsTolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).DecibelVolts, DecibelVoltsTolerance);
            AssertEx.EqualTolerance(50, (10*v).DecibelVolts, DecibelVoltsTolerance);
            AssertEx.EqualTolerance(35, (v/5).DecibelVolts, DecibelVoltsTolerance);
            AssertEx.EqualTolerance(35, v/AmplitudeRatio.FromDecibelVolts(5), DecibelVoltsTolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

        [Fact]
        public void ComparisonOperators()
        {
            AmplitudeRatio oneDecibelVolt = AmplitudeRatio.FromDecibelVolts(1);
            AmplitudeRatio twoDecibelVolts = AmplitudeRatio.FromDecibelVolts(2);

            Assert.True(oneDecibelVolt < twoDecibelVolts);
            Assert.True(oneDecibelVolt <= twoDecibelVolts);
            Assert.True(twoDecibelVolts > oneDecibelVolt);
            Assert.True(twoDecibelVolts >= oneDecibelVolt);

            Assert.False(oneDecibelVolt > twoDecibelVolts);
            Assert.False(oneDecibelVolt >= twoDecibelVolts);
            Assert.False(twoDecibelVolts < oneDecibelVolt);
            Assert.False(twoDecibelVolts <= oneDecibelVolt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Equal(0, decibelvolt.CompareTo(decibelvolt));
            Assert.True(decibelvolt.CompareTo(AmplitudeRatio.Zero) > 0);
            Assert.True(AmplitudeRatio.Zero.CompareTo(decibelvolt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Throws<ArgumentException>(() => decibelvolt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Throws<ArgumentNullException>(() => decibelvolt.CompareTo(null));
        }

        [Theory]
        [InlineData(1, AmplitudeRatioUnit.DecibelVolt, 1, AmplitudeRatioUnit.DecibelVolt, true)]  // Same value and unit.
        [InlineData(1, AmplitudeRatioUnit.DecibelVolt, 2, AmplitudeRatioUnit.DecibelVolt, false)] // Different value.
        [InlineData(2, AmplitudeRatioUnit.DecibelVolt, 1, AmplitudeRatioUnit.DecibelMicrovolt, false)] // Different value and unit.
        [InlineData(1, AmplitudeRatioUnit.DecibelVolt, 1, AmplitudeRatioUnit.DecibelMicrovolt, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, AmplitudeRatioUnit unitA, double valueB, AmplitudeRatioUnit unitB, bool expectEqual)
        {
            var a = new AmplitudeRatio(valueA, unitA);
            var b = new AmplitudeRatio(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = AmplitudeRatio.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = AmplitudeRatio.FromDecibelVolts(1);
            Assert.True(v.Equals(AmplitudeRatio.FromDecibelVolts(1), DecibelVoltsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AmplitudeRatio.Zero, DecibelVoltsTolerance, ComparisonType.Relative));
            Assert.True(AmplitudeRatio.FromDecibelVolts(100).Equals(AmplitudeRatio.FromDecibelVolts(120), 0.3, ComparisonType.Relative));
            Assert.False(AmplitudeRatio.FromDecibelVolts(100).Equals(AmplitudeRatio.FromDecibelVolts(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = AmplitudeRatio.FromDecibelVolts(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(AmplitudeRatio.FromDecibelVolts(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.False(decibelvolt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AmplitudeRatio decibelvolt = AmplitudeRatio.FromDecibelVolts(1);
            Assert.False(decibelvolt.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues<AmplitudeRatioUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AmplitudeRatio.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 dBµV", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelMicrovolt).ToString());
            Assert.Equal("1 dBmV", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelMillivolt).ToString());
            Assert.Equal("1 dBu", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelUnloaded).ToString());
            Assert.Equal("1 dBV", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelVolt).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 dBµV", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelMicrovolt).ToString(swedishCulture));
            Assert.Equal("1 dBmV", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelMillivolt).ToString(swedishCulture));
            Assert.Equal("1 dBu", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelUnloaded).ToString(swedishCulture));
            Assert.Equal("1 dBV", new AmplitudeRatio(1, AmplitudeRatioUnit.DecibelVolt).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s1"));
            Assert.Equal("0.12 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s2"));
            Assert.Equal("0.123 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s3"));
            Assert.Equal("0.1235 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s1", culture));
            Assert.Equal("0.12 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s2", culture));
            Assert.Equal("0.123 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s3", culture));
            Assert.Equal("0.1235 dBV", new AmplitudeRatio(0.123456, AmplitudeRatioUnit.DecibelVolt).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = AmplitudeRatio.FromDecibelVolts(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("G", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = AmplitudeRatio.FromDecibelVolts(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = AmplitudeRatio.FromDecibelVolts(1.0);
            Assert.Equal(new {AmplitudeRatio.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = AmplitudeRatio.FromDecibelVolts(value);
            Assert.Equal(AmplitudeRatio.FromDecibelVolts(-value), -quantity);
        }
    }
}
