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
    /// Test of ElectricSurfaceChargeDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricSurfaceChargeDensityTestsBase : QuantityTestsBase
    {
        protected abstract double CoulombsPerSquareCentimeterInOneCoulombPerSquareMeter { get; }
        protected abstract double CoulombsPerSquareInchInOneCoulombPerSquareMeter { get; }
        protected abstract double CoulombsPerSquareMeterInOneCoulombPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CoulombsPerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double CoulombsPerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double CoulombsPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricSurfaceChargeDensityUnit unit)
        {
            return unit switch
            {
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter => (CoulombsPerSquareCentimeterInOneCoulombPerSquareMeter, CoulombsPerSquareCentimeterTolerance),
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch => (CoulombsPerSquareInchInOneCoulombPerSquareMeter, CoulombsPerSquareInchTolerance),
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter => (CoulombsPerSquareMeterInOneCoulombPerSquareMeter, CoulombsPerSquareMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter },
            new object[] { ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch },
            new object[] { ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricSurfaceChargeDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new ElectricSurfaceChargeDensity(double.PositiveInfinity, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter));
            var exception2 = Record.Exception(() => new ElectricSurfaceChargeDensity(double.NegativeInfinity, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new ElectricSurfaceChargeDensity(double.NaN, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricSurfaceChargeDensity(value: 1, unitSystem: null));
        }

        [Fact]
        public virtual void Ctor_SIUnitSystem_ReturnsQuantityWithSIUnits()
        {
            var quantity = new ElectricSurfaceChargeDensity(value: 1, unitSystem: UnitSystem.SI);
            Assert.Equal(1, quantity.Value);
            Assert.True(quantity.QuantityInfo.UnitInfos.First(x => x.Value == quantity.Unit).BaseUnits.IsSubsetOf(UnitSystem.SI.BaseUnits));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var unsupportedUnitSystem = new UnitSystem(UnsupportedBaseUnits);
            Assert.Throws<ArgumentException>(() => new ElectricSurfaceChargeDensity(value: 1, unitSystem: unsupportedUnitSystem));
        }

        [Fact]
        public void ElectricSurfaceChargeDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);

            QuantityInfo<ElectricSurfaceChargeDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricSurfaceChargeDensity.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricSurfaceChargeDensity", quantityInfo.Name);

            var units = Enum.GetValues<ElectricSurfaceChargeDensityUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void CoulombPerSquareMeterToElectricSurfaceChargeDensityUnits()
        {
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            AssertEx.EqualTolerance(CoulombsPerSquareCentimeterInOneCoulombPerSquareMeter, coulombpersquaremeter.CoulombsPerSquareCentimeter, CoulombsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(CoulombsPerSquareInchInOneCoulombPerSquareMeter, coulombpersquaremeter.CoulombsPerSquareInch, CoulombsPerSquareInchTolerance);
            AssertEx.EqualTolerance(CoulombsPerSquareMeterInOneCoulombPerSquareMeter, coulombpersquaremeter.CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricSurfaceChargeDensity.From(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);
            AssertEx.EqualTolerance(1, quantity00.CoulombsPerSquareCentimeter, CoulombsPerSquareCentimeterTolerance);
            Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, quantity00.Unit);

            var quantity01 = ElectricSurfaceChargeDensity.From(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);
            AssertEx.EqualTolerance(1, quantity01.CoulombsPerSquareInch, CoulombsPerSquareInchTolerance);
            Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch, quantity01.Unit);

            var quantity02 = ElectricSurfaceChargeDensity.From(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity02.CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, quantity02.Unit);

        }

        [Fact]
        public void FromCoulombsPerSquareMeter_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(double.PositiveInfinity));
            var exception2 = Record.Exception(() => ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromCoulombsPerSquareMeter_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            AssertEx.EqualTolerance(CoulombsPerSquareCentimeterInOneCoulombPerSquareMeter, coulombpersquaremeter.As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter), CoulombsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(CoulombsPerSquareInchInOneCoulombPerSquareMeter, coulombpersquaremeter.As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch), CoulombsPerSquareInchTolerance);
            AssertEx.EqualTolerance(CoulombsPerSquareMeterInOneCoulombPerSquareMeter, coulombpersquaremeter.As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter), CoulombsPerSquareMeterTolerance);
        }

        [Fact]
        public virtual void BaseUnit_HasSIBase()
        {
            var baseUnitInfo = ElectricSurfaceChargeDensity.Info.BaseUnitInfo;
            Assert.True(baseUnitInfo.BaseUnits.IsSubsetOf(UnitSystem.SI.BaseUnits));
        }

        [Fact]
        public virtual void As_UnitSystem_SI_ReturnsQuantityInSIUnits()
        {
            var quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
            var expectedValue = quantity.As(ElectricSurfaceChargeDensity.Info.GetDefaultUnit(UnitSystem.SI));

            var convertedValue = quantity.As(UnitSystem.SI);

            Assert.Equal(expectedValue, convertedValue);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentNullExceptionIfNull()
        {
            var quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
            UnitSystem nullUnitSystem = null!;
            Assert.Throws<ArgumentNullException>(() => quantity.As(nullUnitSystem));
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
            var unsupportedUnitSystem = new UnitSystem(UnsupportedBaseUnits);
            Assert.Throws<ArgumentException>(() => quantity.As(unsupportedUnitSystem));
        }

        [Fact]
        public virtual void ToUnit_UnitSystem_SI_ReturnsQuantityInSIUnits()
        {
            var quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
            var expectedUnit = ElectricSurfaceChargeDensity.Info.GetDefaultUnit(UnitSystem.SI);
            var expectedValue = quantity.As(expectedUnit);

            Assert.Multiple(() =>
            {
                ElectricSurfaceChargeDensity quantityToConvert = quantity;

                ElectricSurfaceChargeDensity convertedQuantity = quantityToConvert.ToUnit(UnitSystem.SI);

                Assert.Equal(expectedUnit, convertedQuantity.Unit);
                Assert.Equal(expectedValue, convertedQuantity.Value);
            }, () =>
            {
                IQuantity<ElectricSurfaceChargeDensityUnit> quantityToConvert = quantity;

                IQuantity<ElectricSurfaceChargeDensityUnit> convertedQuantity = quantityToConvert.ToUnit(UnitSystem.SI);

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
                var quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            }, () =>
            {
                IQuantity<ElectricSurfaceChargeDensityUnit> quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            }, () =>
            {
                IQuantity quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
                Assert.Throws<ArgumentNullException>(() => quantity.ToUnit(nullUnitSystem));
            });
        }

        [Fact]
        public void ToUnit_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var unsupportedUnitSystem = new UnitSystem(UnsupportedBaseUnits);
            Assert.Multiple(() =>
            {
                var quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
                Assert.Throws<ArgumentException>(() => quantity.ToUnit(unsupportedUnitSystem));
            }, () =>
            {
                IQuantity<ElectricSurfaceChargeDensityUnit> quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
                Assert.Throws<ArgumentException>(() => quantity.ToUnit(unsupportedUnitSystem));
            }, () =>
            {
                IQuantity quantity = new ElectricSurfaceChargeDensity(value: 1, unit: ElectricSurfaceChargeDensity.BaseUnit);
                Assert.Throws<ArgumentException>(() => quantity.ToUnit(unsupportedUnitSystem));
            });
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = ElectricSurfaceChargeDensity.Parse("1 C/cm²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerSquareCentimeter, CoulombsPerSquareCentimeterTolerance);
                Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricSurfaceChargeDensity.Parse("1 C/in²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerSquareInch, CoulombsPerSquareInchTolerance);
                Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricSurfaceChargeDensity.Parse("1 C/m²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
                Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricSurfaceChargeDensity.TryParse("1 C/cm²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerSquareCentimeter, CoulombsPerSquareCentimeterTolerance);
                Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, parsed.Unit);
            }

            {
                Assert.True(ElectricSurfaceChargeDensity.TryParse("1 C/in²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerSquareInch, CoulombsPerSquareInchTolerance);
                Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch, parsed.Unit);
            }

            {
                Assert.True(ElectricSurfaceChargeDensity.TryParse("1 C/m²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
                Assert.Equal(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, parsed.Unit);
            }

        }

        [Theory]
        [InlineData("C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void ParseUnit_WithUsEnglishCurrentCulture(string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            // Fallback culture "en-US" is always localized
            using var _ = new CultureScope("en-US");
            ElectricSurfaceChargeDensityUnit parsedUnit = ElectricSurfaceChargeDensity.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void ParseUnit_WithUnsupportedCurrentCulture_FallsBackToUsEnglish(string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            // Currently, no abbreviations are localized for Icelandic, so it should fall back to "en-US" when parsing.
            using var _ = new CultureScope("is-IS");
            ElectricSurfaceChargeDensityUnit parsedUnit = ElectricSurfaceChargeDensity.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("en-US", "C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("en-US", "C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void ParseUnit_WithCurrentCulture(string culture, string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            using var _ = new CultureScope(culture);
            ElectricSurfaceChargeDensityUnit parsedUnit = ElectricSurfaceChargeDensity.ParseUnit(abbreviation);
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("en-US", "C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("en-US", "C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void ParseUnit_WithCulture(string culture, string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            ElectricSurfaceChargeDensityUnit parsedUnit = ElectricSurfaceChargeDensity.ParseUnit(abbreviation, CultureInfo.GetCultureInfo(culture));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void TryParseUnit_WithUsEnglishCurrentCulture(string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            // Fallback culture "en-US" is always localized
            using var _ = new CultureScope("en-US");
            Assert.True(ElectricSurfaceChargeDensity.TryParseUnit(abbreviation, out ElectricSurfaceChargeDensityUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void TryParseUnit_WithUnsupportedCurrentCulture_FallsBackToUsEnglish(string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            // Currently, no abbreviations are localized for Icelandic, so it should fall back to "en-US" when parsing.
            using var _ = new CultureScope("is-IS");
            Assert.True(ElectricSurfaceChargeDensity.TryParseUnit(abbreviation, out ElectricSurfaceChargeDensityUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("en-US", "C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("en-US", "C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void TryParseUnit_WithCurrentCulture(string culture, string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            using var _ = new CultureScope(culture);
            Assert.True(ElectricSurfaceChargeDensity.TryParseUnit(abbreviation, out ElectricSurfaceChargeDensityUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [InlineData("en-US", "C/cm²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter)]
        [InlineData("en-US", "C/in²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch)]
        [InlineData("en-US", "C/m²", ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter)]
        public void TryParseUnit_WithCulture(string culture, string abbreviation, ElectricSurfaceChargeDensityUnit expectedUnit)
        {
            Assert.True(ElectricSurfaceChargeDensity.TryParseUnit(abbreviation, CultureInfo.GetCultureInfo(culture), out ElectricSurfaceChargeDensityUnit parsedUnit));
            Assert.Equal(expectedUnit, parsedUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricSurfaceChargeDensityUnit unit)
        {
            var inBaseUnits = ElectricSurfaceChargeDensity.From(1.0, ElectricSurfaceChargeDensity.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricSurfaceChargeDensityUnit unit)
        {
            var quantity = ElectricSurfaceChargeDensity.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricSurfaceChargeDensityUnit unit)
        {
            Assert.All(ElectricSurfaceChargeDensity.Units.Where(u => u != ElectricSurfaceChargeDensity.BaseUnit), fromUnit =>
            {
                var quantity = ElectricSurfaceChargeDensity.From(3.0, fromUnit);
                var converted = quantity.ToUnit(unit);
                Assert.Equal(converted.Unit, unit);
            });
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricSurfaceChargeDensityUnit unit)
        {
            var quantity = default(ElectricSurfaceChargeDensity);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromIQuantity_ReturnsTheExpectedIQuantity(ElectricSurfaceChargeDensityUnit unit)
        {
            var quantity = ElectricSurfaceChargeDensity.From(3, ElectricSurfaceChargeDensity.BaseUnit);
            ElectricSurfaceChargeDensity expectedQuantity = quantity.ToUnit(unit);
            Assert.Multiple(() =>
            {
                IQuantity<ElectricSurfaceChargeDensityUnit> quantityToConvert = quantity;
                IQuantity<ElectricSurfaceChargeDensityUnit> convertedQuantity = quantityToConvert.ToUnit(unit);
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
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            AssertEx.EqualTolerance(1, ElectricSurfaceChargeDensity.FromCoulombsPerSquareCentimeter(coulombpersquaremeter.CoulombsPerSquareCentimeter).CoulombsPerSquareMeter, CoulombsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, ElectricSurfaceChargeDensity.FromCoulombsPerSquareInch(coulombpersquaremeter.CoulombsPerSquareInch).CoulombsPerSquareMeter, CoulombsPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(coulombpersquaremeter.CoulombsPerSquareMeter).CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricSurfaceChargeDensity v = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(3)-v).CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(10)/5).CoulombsPerSquareMeter, CoulombsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(10)/ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(5), CoulombsPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricSurfaceChargeDensity oneCoulombPerSquareMeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            ElectricSurfaceChargeDensity twoCoulombsPerSquareMeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(2);

            Assert.True(oneCoulombPerSquareMeter < twoCoulombsPerSquareMeter);
            Assert.True(oneCoulombPerSquareMeter <= twoCoulombsPerSquareMeter);
            Assert.True(twoCoulombsPerSquareMeter > oneCoulombPerSquareMeter);
            Assert.True(twoCoulombsPerSquareMeter >= oneCoulombPerSquareMeter);

            Assert.False(oneCoulombPerSquareMeter > twoCoulombsPerSquareMeter);
            Assert.False(oneCoulombPerSquareMeter >= twoCoulombsPerSquareMeter);
            Assert.False(twoCoulombsPerSquareMeter < oneCoulombPerSquareMeter);
            Assert.False(twoCoulombsPerSquareMeter <= oneCoulombPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.Equal(0, coulombpersquaremeter.CompareTo(coulombpersquaremeter));
            Assert.True(coulombpersquaremeter.CompareTo(ElectricSurfaceChargeDensity.Zero) > 0);
            Assert.True(ElectricSurfaceChargeDensity.Zero.CompareTo(coulombpersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => coulombpersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => coulombpersquaremeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, 1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, true)]  // Same value and unit.
        [InlineData(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, 2, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, false)] // Different value.
        [InlineData(2, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, 1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, false)] // Different value and unit.
        [InlineData(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, 1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricSurfaceChargeDensityUnit unitA, double valueB, ElectricSurfaceChargeDensityUnit unitB, bool expectEqual)
        {
            var a = new ElectricSurfaceChargeDensity(valueA, unitA);
            var b = new ElectricSurfaceChargeDensity(valueB, unitB);

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
            var a = ElectricSurfaceChargeDensity.Zero;

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
            var v = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.True(v.Equals(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1), CoulombsPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricSurfaceChargeDensity.Zero, CoulombsPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.True(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(100).Equals(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(120), 0.3, ComparisonType.Relative));
            Assert.False(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(100).Equals(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.False(coulombpersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricSurfaceChargeDensity coulombpersquaremeter = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1);
            Assert.False(coulombpersquaremeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues<ElectricSurfaceChargeDensityUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricSurfaceChargeDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 C/cm²", new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter).ToString());
            Assert.Equal("1 C/in²", new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch).ToString());
            Assert.Equal("1 C/m²", new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 C/cm²", new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter).ToString(swedishCulture));
            Assert.Equal("1 C/in²", new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch).ToString(swedishCulture));
            Assert.Equal("1 C/m²", new ElectricSurfaceChargeDensity(1, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s1"));
            Assert.Equal("0.12 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s2"));
            Assert.Equal("0.123 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s3"));
            Assert.Equal("0.1235 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 C/m²", new ElectricSurfaceChargeDensity(0.123456, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1.0);
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
            var quantity = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(1.0);
            Assert.Equal(new {ElectricSurfaceChargeDensity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(value);
            Assert.Equal(ElectricSurfaceChargeDensity.FromCoulombsPerSquareMeter(-value), -quantity);
        }
    }
}
