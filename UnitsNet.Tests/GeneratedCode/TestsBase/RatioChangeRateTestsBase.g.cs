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
    /// Test of RatioChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioChangeRateTestsBase : QuantityTestsBase
    {
        protected abstract double DecimalFractionsPerSecondInOneDecimalFractionPerSecond { get; }
        protected abstract double PercentsPerSecondInOneDecimalFractionPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PercentsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(RatioChangeRateUnit unit)
        {
            return unit switch
            {
                RatioChangeRateUnit.DecimalFractionPerSecond => (DecimalFractionsPerSecondInOneDecimalFractionPerSecond, DecimalFractionsPerSecondTolerance),
                RatioChangeRateUnit.PercentPerSecond => (PercentsPerSecondInOneDecimalFractionPerSecond, PercentsPerSecondTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { RatioChangeRateUnit.DecimalFractionPerSecond },
            new object[] { RatioChangeRateUnit.PercentPerSecond },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RatioChangeRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new RatioChangeRate(double.PositiveInfinity, RatioChangeRateUnit.DecimalFractionPerSecond));
            var exception2 = Record.Exception(() => new RatioChangeRate(double.NegativeInfinity, RatioChangeRateUnit.DecimalFractionPerSecond));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new RatioChangeRate(double.NaN, RatioChangeRateUnit.DecimalFractionPerSecond));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RatioChangeRate(value: 1, unitSystem: null));
        }

        [Fact]
        public virtual void Ctor_SIUnitSystem_ReturnsQuantityWithSIUnits()
        {
            var quantity = new RatioChangeRate(value: 1, unitSystem: UnitSystem.SI);
            Assert.Equal(1, quantity.Value);
            Assert.True(quantity.QuantityInfo.UnitInfos.First(x => x.Value == quantity.Unit).BaseUnits.IsSubsetOf(UnitSystem.SI.BaseUnits));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var unsupportedUnitSystem = new UnitSystem(UnsupportedBaseUnits);
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(value: 1, unitSystem: unsupportedUnitSystem));
        }

        [Fact]
        public void RatioChangeRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RatioChangeRate(1, RatioChangeRateUnit.DecimalFractionPerSecond);

            QuantityInfo<RatioChangeRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RatioChangeRate.Zero, quantityInfo.Zero);
            Assert.Equal("RatioChangeRate", quantityInfo.Name);

            var units = Enum.GetValues<RatioChangeRateUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void DecimalFractionPerSecondToRatioChangeRateUnits()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RatioChangeRate.From(1, RatioChangeRateUnit.DecimalFractionPerSecond);
            AssertEx.EqualTolerance(1, quantity00.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, quantity00.Unit);

            var quantity01 = RatioChangeRate.From(1, RatioChangeRateUnit.PercentPerSecond);
            AssertEx.EqualTolerance(1, quantity01.PercentsPerSecond, PercentsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.PercentPerSecond, quantity01.Unit);

        }

        [Fact]
        public void FromDecimalFractionsPerSecond_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => RatioChangeRate.FromDecimalFractionsPerSecond(double.PositiveInfinity));
            var exception2 = Record.Exception(() => RatioChangeRate.FromDecimalFractionsPerSecond(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromDecimalFractionsPerSecond_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => RatioChangeRate.FromDecimalFractionsPerSecond(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.As(RatioChangeRateUnit.DecimalFractionPerSecond), DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.As(RatioChangeRateUnit.PercentPerSecond), PercentsPerSecondTolerance);
        }

        [Fact]
        public virtual void BaseUnit_HasSIBase()
        {
            var baseUnitInfo = RatioChangeRate.Info.BaseUnitInfo;
            Assert.True(baseUnitInfo.BaseUnits.IsSubsetOf(UnitSystem.SI.BaseUnits));
        }

        [Fact]
        public virtual void As_UnitSystem_SI_ReturnsQuantityInSIUnits()
        {
            var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
            var expectedValue = quantity.As(RatioChangeRate.Info.GetDefaultUnit(UnitSystem.SI));

            var convertedValue = quantity.As(UnitSystem.SI);

            Assert.Equal(expectedValue, convertedValue);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentNullExceptionIfNull()
        {
            var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
            UnitSystem nullUnitSystem = null!;
            Assert.Throws<ArgumentNullException>(() => quantity.As(nullUnitSystem));
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
            var unsupportedUnitSystem = new UnitSystem(UnsupportedBaseUnits);
            Assert.Throws<ArgumentException>(() => quantity.As(unsupportedUnitSystem));
        }

        [Fact]
        public virtual void ToUnit_UnitSystem_SI_ReturnsQuantityInSIUnits()
        {
            var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
            var expectedUnit = RatioChangeRate.Info.GetDefaultUnit(UnitSystem.SI);
            var expectedValue = quantity.As(expectedUnit);

            Assert.Multiple(() =>
            {
                RatioChangeRate quantityToConvert = quantity;

                RatioChangeRate convertedQuantity = quantityToConvert.ToUnit(UnitSystem.SI);

                Assert.Equal(expectedUnit, convertedQuantity.Unit);
                Assert.Equal(expectedValue, convertedQuantity.Value);
            }, () =>
            {
                IQuantity<RatioChangeRateUnit> quantityToConvert = quantity;

                IQuantity<RatioChangeRateUnit> convertedQuantity = quantityToConvert.ToUnit(UnitSystem.SI);

                Assert.Equal(expectedUnit, convertedQuantity.Unit);
                Assert.Equal(expectedValue, convertedQuantity.Value);
            }, () =>
            {
                IQuantity quantityToConvert = quantity;

                IQuantity convertedQuantity = quantityToConvert.ToUnit(UnitSystem.SI);

                Assert.Equal(expectedUnit, convertedQuantity.Unit);
                Assert.Equal(expectedValue, convertedQuantity.Value);
            });
        }

        [Fact]
        public void ToUnit_UnitSystem_ThrowsArgumentNullExceptionIfNull()
        {
            UnitSystem nullUnitSystem = null!;
            Assert.Multiple(() =>
            {
                var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            }, () =>
            {
                IQuantity<RatioChangeRateUnit> quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            }, () =>
            {
                IQuantity quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            });
        }

        [Fact]
        public void ToUnit_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var unsupportedUnitSystem = new UnitSystem(UnsupportedBaseUnits);
            Assert.Multiple(() =>
            {
                var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
                Assert.Throws<ArgumentException>(() => quantity.ToUnit(unsupportedUnitSystem));
            }, () =>
            {
                IQuantity<RatioChangeRateUnit> quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
                Assert.Throws<ArgumentException>(() => quantity.ToUnit(unsupportedUnitSystem));
            }, () =>
            {
                IQuantity quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.BaseUnit);
                Assert.Throws<ArgumentException>(() => quantity.ToUnit(unsupportedUnitSystem));
            });
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = RatioChangeRate.Parse("1 /s", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
                Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = RatioChangeRate.Parse("1 %/s", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PercentsPerSecond, PercentsPerSecondTolerance);
                Assert.Equal(RatioChangeRateUnit.PercentPerSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(RatioChangeRate.TryParse("1 /s", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
                Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, parsed.Unit);
            }

            {
                Assert.True(RatioChangeRate.TryParse("1 %/s", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PercentsPerSecond, PercentsPerSecondTolerance);
                Assert.Equal(RatioChangeRateUnit.PercentPerSecond, parsed.Unit);
            }

        }

        [Theory]
        [InlineData("/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void ParseUnit_WithUsEnglishCurrentCulture(string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            // Fallback culture "en-US" is always localized
            using var _ = new CultureScope("en-US");
            RatioChangeRateUnit parsedUnit = RatioChangeRate.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void ParseUnit_WithUnsupportedCurrentCulture_FallsBackToUsEnglish(string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            // Currently, no abbreviations are localized for Icelandic, so it should fall back to "en-US" when parsing.
            using var _ = new CultureScope("is-IS");
            RatioChangeRateUnit parsedUnit = RatioChangeRate.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("en-US", "%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void ParseUnit_WithCurrentCulture(string culture, string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            using var _ = new CultureScope(culture);
            RatioChangeRateUnit parsedUnit = RatioChangeRate.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("en-US", "%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void ParseUnit_WithCulture(string culture, string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            RatioChangeRateUnit parsedUnit = RatioChangeRate.ParseUnit(abbreviation, CultureInfo.GetCultureInfo(culture));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void TryParseUnit_WithUsEnglishCurrentCulture(string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            // Fallback culture "en-US" is always localized
            using var _ = new CultureScope("en-US");
            Assert.True(RatioChangeRate.TryParseUnit(abbreviation, out RatioChangeRateUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void TryParseUnit_WithUnsupportedCurrentCulture_FallsBackToUsEnglish(string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            // Currently, no abbreviations are localized for Icelandic, so it should fall back to "en-US" when parsing.
            using var _ = new CultureScope("is-IS");
            Assert.True(RatioChangeRate.TryParseUnit(abbreviation, out RatioChangeRateUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("en-US", "%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void TryParseUnit_WithCurrentCulture(string culture, string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            using var _ = new CultureScope(culture);
            Assert.True(RatioChangeRate.TryParseUnit(abbreviation, out RatioChangeRateUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "/s", RatioChangeRateUnit.DecimalFractionPerSecond)]
        [InlineData("en-US", "%/s", RatioChangeRateUnit.PercentPerSecond)]
        public void TryParseUnit_WithCulture(string culture, string abbreviation, RatioChangeRateUnit expectedUnit)
        {
            Assert.True(RatioChangeRate.TryParseUnit(abbreviation, CultureInfo.GetCultureInfo(culture), out RatioChangeRateUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(RatioChangeRateUnit unit)
        {
            var inBaseUnits = RatioChangeRate.From(1.0, RatioChangeRate.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(RatioChangeRateUnit unit)
        {
            var quantity = RatioChangeRate.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(RatioChangeRateUnit unit)
        {
            Assert.All(RatioChangeRate.Units.Where(u => u != RatioChangeRate.BaseUnit), fromUnit =>
            {
                var quantity = RatioChangeRate.From(3.0, fromUnit);
                var converted = quantity.ToUnit(unit);
                Assert.Equal(converted.Unit, unit);
            });
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(RatioChangeRateUnit unit)
        {
            var quantity = default(RatioChangeRate);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromIQuantity_ReturnsTheExpectedIQuantity(RatioChangeRateUnit unit)
        {
            var quantity = RatioChangeRate.From(3, RatioChangeRate.BaseUnit);
            RatioChangeRate expectedQuantity = quantity.ToUnit(unit);
            Assert.Multiple(() =>
            {
                IQuantity<RatioChangeRateUnit> quantityToConvert = quantity;
                IQuantity<RatioChangeRateUnit> convertedQuantity = quantityToConvert.ToUnit(unit);
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
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromDecimalFractionsPerSecond(decimalfractionpersecond.DecimalFractionsPerSecond).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromPercentsPerSecond(decimalfractionpersecond.PercentsPerSecond).DecimalFractionsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RatioChangeRate v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromDecimalFractionsPerSecond(3)-v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromDecimalFractionsPerSecond(10)/5).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, RatioChangeRate.FromDecimalFractionsPerSecond(10)/RatioChangeRate.FromDecimalFractionsPerSecond(5), DecimalFractionsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RatioChangeRate oneDecimalFractionPerSecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            RatioChangeRate twoDecimalFractionsPerSecond = RatioChangeRate.FromDecimalFractionsPerSecond(2);

            Assert.True(oneDecimalFractionPerSecond < twoDecimalFractionsPerSecond);
            Assert.True(oneDecimalFractionPerSecond <= twoDecimalFractionsPerSecond);
            Assert.True(twoDecimalFractionsPerSecond > oneDecimalFractionPerSecond);
            Assert.True(twoDecimalFractionsPerSecond >= oneDecimalFractionPerSecond);

            Assert.False(oneDecimalFractionPerSecond > twoDecimalFractionsPerSecond);
            Assert.False(oneDecimalFractionPerSecond >= twoDecimalFractionsPerSecond);
            Assert.False(twoDecimalFractionsPerSecond < oneDecimalFractionPerSecond);
            Assert.False(twoDecimalFractionsPerSecond <= oneDecimalFractionPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Equal(0, decimalfractionpersecond.CompareTo(decimalfractionpersecond));
            Assert.True(decimalfractionpersecond.CompareTo(RatioChangeRate.Zero) > 0);
            Assert.True(RatioChangeRate.Zero.CompareTo(decimalfractionpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentException>(() => decimalfractionpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => decimalfractionpersecond.CompareTo(null));
        }

        [Theory]
        [InlineData(1, RatioChangeRateUnit.DecimalFractionPerSecond, 1, RatioChangeRateUnit.DecimalFractionPerSecond, true)]  // Same value and unit.
        [InlineData(1, RatioChangeRateUnit.DecimalFractionPerSecond, 2, RatioChangeRateUnit.DecimalFractionPerSecond, false)] // Different value.
        [InlineData(2, RatioChangeRateUnit.DecimalFractionPerSecond, 1, RatioChangeRateUnit.PercentPerSecond, false)] // Different value and unit.
        [InlineData(1, RatioChangeRateUnit.DecimalFractionPerSecond, 1, RatioChangeRateUnit.PercentPerSecond, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, RatioChangeRateUnit unitA, double valueB, RatioChangeRateUnit unitB, bool expectEqual)
        {
            var a = new RatioChangeRate(valueA, unitA);
            var b = new RatioChangeRate(valueB, unitB);

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
            var a = RatioChangeRate.Zero;

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
            var v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.True(v.Equals(RatioChangeRate.FromDecimalFractionsPerSecond(1), DecimalFractionsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RatioChangeRate.Zero, DecimalFractionsPerSecondTolerance, ComparisonType.Relative));
            Assert.True(RatioChangeRate.FromDecimalFractionsPerSecond(100).Equals(RatioChangeRate.FromDecimalFractionsPerSecond(120), 0.3, ComparisonType.Relative));
            Assert.False(RatioChangeRate.FromDecimalFractionsPerSecond(100).Equals(RatioChangeRate.FromDecimalFractionsPerSecond(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(RatioChangeRate.FromDecimalFractionsPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.False(decimalfractionpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.False(decimalfractionpersecond.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues<RatioChangeRateUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RatioChangeRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 /s", new RatioChangeRate(1, RatioChangeRateUnit.DecimalFractionPerSecond).ToString());
            Assert.Equal("1 %/s", new RatioChangeRate(1, RatioChangeRateUnit.PercentPerSecond).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 /s", new RatioChangeRate(1, RatioChangeRateUnit.DecimalFractionPerSecond).ToString(swedishCulture));
            Assert.Equal("1 %/s", new RatioChangeRate(1, RatioChangeRateUnit.PercentPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s1"));
            Assert.Equal("0.12 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s2"));
            Assert.Equal("0.123 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s3"));
            Assert.Equal("0.1235 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
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
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(new {RatioChangeRate.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(value);
            Assert.Equal(RatioChangeRate.FromDecimalFractionsPerSecond(-value), -quantity);
        }
    }
}
