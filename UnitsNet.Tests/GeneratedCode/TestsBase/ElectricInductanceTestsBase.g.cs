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
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricInductance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricInductanceTestsBase : QuantityTestsBase
    {
        protected abstract double HenriesInOneHenry { get; }
        protected abstract double MicrohenriesInOneHenry { get; }
        protected abstract double MillihenriesInOneHenry { get; }
        protected abstract double NanohenriesInOneHenry { get; }
        protected abstract double PicohenriesInOneHenry { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HenriesTolerance { get { return 1e-5; } }
        protected virtual double MicrohenriesTolerance { get { return 1e-5; } }
        protected virtual double MillihenriesTolerance { get { return 1e-5; } }
        protected virtual double NanohenriesTolerance { get { return 1e-5; } }
        protected virtual double PicohenriesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricInductanceUnit unit)
        {
            return unit switch
            {
                ElectricInductanceUnit.Henry => (HenriesInOneHenry, HenriesTolerance),
                ElectricInductanceUnit.Microhenry => (MicrohenriesInOneHenry, MicrohenriesTolerance),
                ElectricInductanceUnit.Millihenry => (MillihenriesInOneHenry, MillihenriesTolerance),
                ElectricInductanceUnit.Nanohenry => (NanohenriesInOneHenry, NanohenriesTolerance),
                ElectricInductanceUnit.Picohenry => (PicohenriesInOneHenry, PicohenriesTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricInductanceUnit.Henry },
            new object[] { ElectricInductanceUnit.Microhenry },
            new object[] { ElectricInductanceUnit.Millihenry },
            new object[] { ElectricInductanceUnit.Nanohenry },
            new object[] { ElectricInductanceUnit.Picohenry },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricInductance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricInductanceUnit.Henry, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new ElectricInductance(double.PositiveInfinity, ElectricInductanceUnit.Henry));
            var exception2 = Record.Exception(() => new ElectricInductance(double.NegativeInfinity, ElectricInductanceUnit.Henry));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new ElectricInductance(double.NaN, ElectricInductanceUnit.Henry));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricInductance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            if (SupportsSIUnitSystem)
            {
                var quantity = new ElectricInductance(value: 1, unitSystem: UnitSystem.SI);
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(() => new ElectricInductance(value: 1, unitSystem: UnitSystem.SI));
            }
        }

        [Fact]
        public void ElectricInductance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricInductance(1, ElectricInductanceUnit.Henry);

            QuantityInfo<ElectricInductanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricInductance.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricInductance", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricInductanceUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void HenryToElectricInductanceUnits()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(HenriesInOneHenry, henry.Henries, HenriesTolerance);
            AssertEx.EqualTolerance(MicrohenriesInOneHenry, henry.Microhenries, MicrohenriesTolerance);
            AssertEx.EqualTolerance(MillihenriesInOneHenry, henry.Millihenries, MillihenriesTolerance);
            AssertEx.EqualTolerance(NanohenriesInOneHenry, henry.Nanohenries, NanohenriesTolerance);
            AssertEx.EqualTolerance(PicohenriesInOneHenry, henry.Picohenries, PicohenriesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricInductance.From(1, ElectricInductanceUnit.Henry);
            Assert.Equal(1, quantity00.Henries);
            Assert.Equal(ElectricInductanceUnit.Henry, quantity00.Unit);

            var quantity01 = ElectricInductance.From(1, ElectricInductanceUnit.Microhenry);
            Assert.Equal(1, quantity01.Microhenries);
            Assert.Equal(ElectricInductanceUnit.Microhenry, quantity01.Unit);

            var quantity02 = ElectricInductance.From(1, ElectricInductanceUnit.Millihenry);
            Assert.Equal(1, quantity02.Millihenries);
            Assert.Equal(ElectricInductanceUnit.Millihenry, quantity02.Unit);

            var quantity03 = ElectricInductance.From(1, ElectricInductanceUnit.Nanohenry);
            Assert.Equal(1, quantity03.Nanohenries);
            Assert.Equal(ElectricInductanceUnit.Nanohenry, quantity03.Unit);

            var quantity04 = ElectricInductance.From(1, ElectricInductanceUnit.Picohenry);
            Assert.Equal(1, quantity04.Picohenries);
            Assert.Equal(ElectricInductanceUnit.Picohenry, quantity04.Unit);

        }

        [Fact]
        public void FromHenries_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => ElectricInductance.FromHenries(double.PositiveInfinity));
            var exception2 = Record.Exception(() => ElectricInductance.FromHenries(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromHenries_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => ElectricInductance.FromHenries(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(HenriesInOneHenry, henry.As(ElectricInductanceUnit.Henry), HenriesTolerance);
            AssertEx.EqualTolerance(MicrohenriesInOneHenry, henry.As(ElectricInductanceUnit.Microhenry), MicrohenriesTolerance);
            AssertEx.EqualTolerance(MillihenriesInOneHenry, henry.As(ElectricInductanceUnit.Millihenry), MillihenriesTolerance);
            AssertEx.EqualTolerance(NanohenriesInOneHenry, henry.As(ElectricInductanceUnit.Nanohenry), NanohenriesTolerance);
            AssertEx.EqualTolerance(PicohenriesInOneHenry, henry.As(ElectricInductanceUnit.Picohenry), PicohenriesTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricInductance(value: 1, unit: ElectricInductance.BaseUnit);
            if (SupportsSIUnitSystem)
            {
                Assert.Equal(1, quantity.As(UnitSystem.SI));
            }
            else
            {
                Assert.Throws<ArgumentException>(() => quantity.As(UnitSystem.SI));
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = ElectricInductance.Parse("1 H", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(1, parsed.Henries);
                Assert.Equal(ElectricInductanceUnit.Henry, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricInductance.Parse("1 µH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(1, parsed.Microhenries);
                Assert.Equal(ElectricInductanceUnit.Microhenry, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricInductance.Parse("1 mH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(1, parsed.Millihenries);
                Assert.Equal(ElectricInductanceUnit.Millihenry, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricInductance.Parse("1 nH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(1, parsed.Nanohenries);
                Assert.Equal(ElectricInductanceUnit.Nanohenry, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricInductance.Parse("1 pH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(1, parsed.Picohenries);
                Assert.Equal(ElectricInductanceUnit.Picohenry, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricInductance.TryParse("1 H", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                Assert.Equal(1, parsed.Henries);
                Assert.Equal(ElectricInductanceUnit.Henry, parsed.Unit);
            }

            {
                Assert.True(ElectricInductance.TryParse("1 µH", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                Assert.Equal(1, parsed.Microhenries);
                Assert.Equal(ElectricInductanceUnit.Microhenry, parsed.Unit);
            }

            {
                Assert.True(ElectricInductance.TryParse("1 mH", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                Assert.Equal(1, parsed.Millihenries);
                Assert.Equal(ElectricInductanceUnit.Millihenry, parsed.Unit);
            }

            {
                Assert.True(ElectricInductance.TryParse("1 nH", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                Assert.Equal(1, parsed.Nanohenries);
                Assert.Equal(ElectricInductanceUnit.Nanohenry, parsed.Unit);
            }

            {
                Assert.True(ElectricInductance.TryParse("1 pH", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                Assert.Equal(1, parsed.Picohenries);
                Assert.Equal(ElectricInductanceUnit.Picohenry, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricInductance.ParseUnit("H", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricInductanceUnit.Henry, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricInductance.ParseUnit("µH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricInductanceUnit.Microhenry, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricInductance.ParseUnit("mH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricInductanceUnit.Millihenry, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricInductance.ParseUnit("nH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricInductanceUnit.Nanohenry, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricInductance.ParseUnit("pH", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricInductanceUnit.Picohenry, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricInductance.TryParseUnit("H", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricInductanceUnit.Henry, parsedUnit);
            }

            {
                Assert.True(ElectricInductance.TryParseUnit("µH", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricInductanceUnit.Microhenry, parsedUnit);
            }

            {
                Assert.True(ElectricInductance.TryParseUnit("mH", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricInductanceUnit.Millihenry, parsedUnit);
            }

            {
                Assert.True(ElectricInductance.TryParseUnit("nH", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricInductanceUnit.Nanohenry, parsedUnit);
            }

            {
                Assert.True(ElectricInductance.TryParseUnit("pH", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricInductanceUnit.Picohenry, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricInductanceUnit unit)
        {
            var inBaseUnits = ElectricInductance.From(1.0, ElectricInductance.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricInductanceUnit unit)
        {
            var quantity = ElectricInductance.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricInductanceUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricInductance.Units.First(u => u != ElectricInductance.BaseUnit);

            var quantity = ElectricInductance.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricInductanceUnit unit)
        {
            var quantity = default(ElectricInductance);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Equal(1, ElectricInductance.FromHenries(henry.Henries).Henries);
            Assert.Equal(1, ElectricInductance.FromMicrohenries(henry.Microhenries).Henries);
            Assert.Equal(1, ElectricInductance.FromMillihenries(henry.Millihenries).Henries);
            Assert.Equal(1, ElectricInductance.FromNanohenries(henry.Nanohenries).Henries);
            Assert.Equal(1, ElectricInductance.FromPicohenries(henry.Picohenries).Henries);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricInductance v = ElectricInductance.FromHenries(1);
            Assert.Equal(-1, -v.Henries);
            Assert.Equal(2, (ElectricInductance.FromHenries(3) - v).Henries);
            Assert.Equal(2, (v + v).Henries);
            Assert.Equal(10, (v * 10).Henries);
            Assert.Equal(10, (10 * v).Henries);
            Assert.Equal(2, (ElectricInductance.FromHenries(10) / 5).Henries);
            Assert.Equal(2, ElectricInductance.FromHenries(10) / ElectricInductance.FromHenries(5));
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricInductance oneHenry = ElectricInductance.FromHenries(1);
            ElectricInductance twoHenries = ElectricInductance.FromHenries(2);

            Assert.True(oneHenry < twoHenries);
            Assert.True(oneHenry <= twoHenries);
            Assert.True(twoHenries > oneHenry);
            Assert.True(twoHenries >= oneHenry);

            Assert.False(oneHenry > twoHenries);
            Assert.False(oneHenry >= twoHenries);
            Assert.False(twoHenries < oneHenry);
            Assert.False(twoHenries <= oneHenry);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Equal(0, henry.CompareTo(henry));
            Assert.True(henry.CompareTo(ElectricInductance.Zero) > 0);
            Assert.True(ElectricInductance.Zero.CompareTo(henry) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Throws<ArgumentException>(() => henry.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Throws<ArgumentNullException>(() => henry.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricInductanceUnit.Henry, 1, ElectricInductanceUnit.Henry, true)]  // Same value and unit.
        [InlineData(1, ElectricInductanceUnit.Henry, 2, ElectricInductanceUnit.Henry, false)] // Different value.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricInductanceUnit unitA, double valueB, ElectricInductanceUnit unitB, bool expectEqual)
        {
            var a = new ElectricInductance(valueA, unitA);
            var b = new ElectricInductance(valueB, unitB);

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
            var a = ElectricInductance.Zero;

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
        public void Equals_WithTolerance_IsImplemented()
        {
            var v = ElectricInductance.FromHenries(1);
            Assert.True(v.Equals(ElectricInductance.FromHenries(1), ElectricInductance.FromHenries(0)));
            Assert.True(v.Equals(ElectricInductance.FromHenries(1), ElectricInductance.FromHenries(0.001m)));
            Assert.True(v.Equals(ElectricInductance.FromHenries(0.9999), ElectricInductance.FromHenries(0.001m)));
            Assert.False(v.Equals(ElectricInductance.FromHenries(0.99), ElectricInductance.FromHenries(0.001m)));
            Assert.False(v.Equals(ElectricInductance.Zero, ElectricInductance.FromHenries(0.001m)));
        }

        [Fact]
        public void Equals_WithNegativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricInductance.FromHenries(1);
            var negativeTolerance = ElectricInductance.FromHenries(-1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricInductance.FromHenries(1), negativeTolerance));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.False(henry.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.False(henry.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricInductanceUnit)).Cast<ElectricInductanceUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricInductance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 H", new ElectricInductance(1, ElectricInductanceUnit.Henry).ToString());
                Assert.Equal("1 µH", new ElectricInductance(1, ElectricInductanceUnit.Microhenry).ToString());
                Assert.Equal("1 mH", new ElectricInductance(1, ElectricInductanceUnit.Millihenry).ToString());
                Assert.Equal("1 nH", new ElectricInductance(1, ElectricInductanceUnit.Nanohenry).ToString());
                Assert.Equal("1 pH", new ElectricInductance(1, ElectricInductanceUnit.Picohenry).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 H", new ElectricInductance(1, ElectricInductanceUnit.Henry).ToString(swedishCulture));
            Assert.Equal("1 µH", new ElectricInductance(1, ElectricInductanceUnit.Microhenry).ToString(swedishCulture));
            Assert.Equal("1 mH", new ElectricInductance(1, ElectricInductanceUnit.Millihenry).ToString(swedishCulture));
            Assert.Equal("1 nH", new ElectricInductance(1, ElectricInductanceUnit.Nanohenry).ToString(swedishCulture));
            Assert.Equal("1 pH", new ElectricInductance(1, ElectricInductanceUnit.Picohenry).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s1"));
                Assert.Equal("0.12 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s2"));
                Assert.Equal("0.123 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s3"));
                Assert.Equal("0.1235 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s1", culture));
            Assert.Equal("0.12 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s2", culture));
            Assert.Equal("0.123 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s3", culture));
            Assert.Equal("0.1235 H", new ElectricInductance(0.123456, ElectricInductanceUnit.Henry).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricInductance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricInductanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal(ElectricInductance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Equal(ElectricInductance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricInductance.FromHenries(1.0);
            #if NET7_0_OR_GREATER
            var expected = HashCode.Combine(ElectricInductance.Info.Name, quantity.Henries);
            #else
            var expected = new {ElectricInductance.Info.Name, valueInBaseUnit = quantity.Henries}.GetHashCode();
            #endif
            Assert.Equal(expected, quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricInductance.FromHenries(value);
            Assert.Equal(ElectricInductance.FromHenries(-value), -quantity);
        }
    }
}
