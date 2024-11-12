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
    /// Test of VitaminA.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VitaminATestsBase : QuantityTestsBase
    {
        protected abstract double InternationalUnitsInOneInternationalUnit { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double InternationalUnitsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(VitaminAUnit unit)
        {
            return unit switch
            {
                VitaminAUnit.InternationalUnit => (InternationalUnitsInOneInternationalUnit, InternationalUnitsTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { VitaminAUnit.InternationalUnit },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new VitaminA();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(VitaminAUnit.InternationalUnit, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new VitaminA(double.PositiveInfinity, VitaminAUnit.InternationalUnit));
            var exception2 = Record.Exception(() => new VitaminA(double.NegativeInfinity, VitaminAUnit.InternationalUnit));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new VitaminA(double.NaN, VitaminAUnit.InternationalUnit));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new VitaminA(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            if (SupportsSIUnitSystem)
            {
                var quantity = new VitaminA(value: 1, unitSystem: UnitSystem.SI);
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(() => new VitaminA(value: 1, unitSystem: UnitSystem.SI));
            }
        }

        [Fact]
        public void VitaminA_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new VitaminA(1, VitaminAUnit.InternationalUnit);

            QuantityInfo<VitaminAUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(VitaminA.Zero, quantityInfo.Zero);
            Assert.Equal("VitaminA", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<VitaminAUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void InternationalUnitToVitaminAUnits()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, internationalunit.InternationalUnits, InternationalUnitsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = VitaminA.From(1, VitaminAUnit.InternationalUnit);
            Assert.Equal(1, quantity00.InternationalUnits);
            Assert.Equal(VitaminAUnit.InternationalUnit, quantity00.Unit);

        }

        [Fact]
        public void FromInternationalUnits_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => VitaminA.FromInternationalUnits(double.PositiveInfinity));
            var exception2 = Record.Exception(() => VitaminA.FromInternationalUnits(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromInternationalUnits_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => VitaminA.FromInternationalUnits(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, internationalunit.As(VitaminAUnit.InternationalUnit), InternationalUnitsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new VitaminA(value: 1, unit: VitaminA.BaseUnit);
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
                var parsed = VitaminA.Parse("1 IU", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(1, parsed.InternationalUnits);
                Assert.Equal(VitaminAUnit.InternationalUnit, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(VitaminA.TryParse("1 IU", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                Assert.Equal(1, parsed.InternationalUnits);
                Assert.Equal(VitaminAUnit.InternationalUnit, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = VitaminA.ParseUnit("IU", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(VitaminAUnit.InternationalUnit, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(VitaminA.TryParseUnit("IU", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(VitaminAUnit.InternationalUnit, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(VitaminAUnit unit)
        {
            var inBaseUnits = VitaminA.From(1.0, VitaminA.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(VitaminAUnit unit)
        {
            var quantity = VitaminA.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory(Skip = "Multiple units required")]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(VitaminAUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = VitaminA.Units.First(u => u != VitaminA.BaseUnit);

            var quantity = VitaminA.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(VitaminAUnit unit)
        {
            var quantity = default(VitaminA);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Equal(1, VitaminA.FromInternationalUnits(internationalunit.InternationalUnits).InternationalUnits);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VitaminA v = VitaminA.FromInternationalUnits(1);
            Assert.Equal(-1, -v.InternationalUnits);
            Assert.Equal(2, (VitaminA.FromInternationalUnits(3) - v).InternationalUnits);
            Assert.Equal(2, (v + v).InternationalUnits);
            Assert.Equal(10, (v * 10).InternationalUnits);
            Assert.Equal(10, (10 * v).InternationalUnits);
            Assert.Equal(2, (VitaminA.FromInternationalUnits(10) / 5).InternationalUnits);
            Assert.Equal(2, VitaminA.FromInternationalUnits(10) / VitaminA.FromInternationalUnits(5));
        }

        [Fact]
        public void ComparisonOperators()
        {
            VitaminA oneInternationalUnit = VitaminA.FromInternationalUnits(1);
            VitaminA twoInternationalUnits = VitaminA.FromInternationalUnits(2);

            Assert.True(oneInternationalUnit < twoInternationalUnits);
            Assert.True(oneInternationalUnit <= twoInternationalUnits);
            Assert.True(twoInternationalUnits > oneInternationalUnit);
            Assert.True(twoInternationalUnits >= oneInternationalUnit);

            Assert.False(oneInternationalUnit > twoInternationalUnits);
            Assert.False(oneInternationalUnit >= twoInternationalUnits);
            Assert.False(twoInternationalUnits < oneInternationalUnit);
            Assert.False(twoInternationalUnits <= oneInternationalUnit);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Equal(0, internationalunit.CompareTo(internationalunit));
            Assert.True(internationalunit.CompareTo(VitaminA.Zero) > 0);
            Assert.True(VitaminA.Zero.CompareTo(internationalunit) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentException>(() => internationalunit.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentNullException>(() => internationalunit.CompareTo(null));
        }

        [Theory]
        [InlineData(1, VitaminAUnit.InternationalUnit, 1, VitaminAUnit.InternationalUnit, true)]  // Same value and unit.
        [InlineData(1, VitaminAUnit.InternationalUnit, 2, VitaminAUnit.InternationalUnit, false)] // Different value.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, VitaminAUnit unitA, double valueB, VitaminAUnit unitB, bool expectEqual)
        {
            var a = new VitaminA(valueA, unitA);
            var b = new VitaminA(valueB, unitB);

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
            var a = VitaminA.Zero;

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
            var v = VitaminA.FromInternationalUnits(1);
            Assert.True(v.Equals(VitaminA.FromInternationalUnits(1), VitaminA.FromInternationalUnits(0)));
            Assert.True(v.Equals(VitaminA.FromInternationalUnits(1), VitaminA.FromInternationalUnits(0.001m)));
            Assert.True(v.Equals(VitaminA.FromInternationalUnits(0.9999), VitaminA.FromInternationalUnits(0.001m)));
            Assert.False(v.Equals(VitaminA.FromInternationalUnits(0.99), VitaminA.FromInternationalUnits(0.001m)));
            Assert.False(v.Equals(VitaminA.Zero, VitaminA.FromInternationalUnits(0.001m)));
        }

        [Fact]
        public void Equals_WithNegativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = VitaminA.FromInternationalUnits(1);
            var negativeTolerance = VitaminA.FromInternationalUnits(-1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(VitaminA.FromInternationalUnits(1), negativeTolerance));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.False(internationalunit.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.False(internationalunit.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(VitaminAUnit)).Cast<VitaminAUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(VitaminA.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 IU", new VitaminA(1, VitaminAUnit.InternationalUnit).ToString());
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

            Assert.Equal("1 IU", new VitaminA(1, VitaminAUnit.InternationalUnit).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s1"));
                Assert.Equal("0.12 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s2"));
                Assert.Equal("0.123 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s3"));
                Assert.Equal("0.1235 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s4"));
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
            Assert.Equal("0.1 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s1", culture));
            Assert.Equal("0.12 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s2", culture));
            Assert.Equal("0.123 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s3", culture));
            Assert.Equal("0.1235 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
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
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(VitaminA)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(VitaminAUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(VitaminA.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(VitaminA.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            #if NET7_0_OR_GREATER
            var expected = HashCode.Combine(VitaminA.Info.Name, quantity.InternationalUnits);
            #else
            var expected = new {VitaminA.Info.Name, valueInBaseUnit = quantity.InternationalUnits}.GetHashCode();
            #endif
            Assert.Equal(expected, quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = VitaminA.FromInternationalUnits(value);
            Assert.Equal(VitaminA.FromInternationalUnits(-value), -quantity);
        }
    }
}
