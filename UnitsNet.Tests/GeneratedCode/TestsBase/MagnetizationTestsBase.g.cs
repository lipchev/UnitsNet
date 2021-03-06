﻿//------------------------------------------------------------------------------
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
    /// Test of Magnetization.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagnetizationTestsBase : QuantityTestsBase
    {
        protected abstract double AmperesPerMeterInOneAmperePerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Magnetization((double)0.0, MagnetizationUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Magnetization();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MagnetizationUnit.AmperePerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Magnetization(double.PositiveInfinity, MagnetizationUnit.AmperePerMeter));
            Assert.Throws<ArgumentException>(() => new Magnetization(double.NegativeInfinity, MagnetizationUnit.AmperePerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Magnetization(double.NaN, MagnetizationUnit.AmperePerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Magnetization(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => new Magnetization(1, UnitSystem.Astronomical));
        }

        [Fact]
        public void Ctor_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Magnetization(1, null));
        }

        public void Magnetization_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Magnetization(1, MagnetizationUnit.AmperePerMeter);

            QuantityInfo<MagnetizationUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Magnetization.Zero, quantityInfo.Zero);
            Assert.Equal("Magnetization", quantityInfo.Name);
            Assert.Equal(QuantityType.Magnetization, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<MagnetizationUnit>().Except(new[] {MagnetizationUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void AmperePerMeterToMagnetizationUnits()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(AmperesPerMeterInOneAmperePerMeter, amperepermeter.AmperesPerMeter, AmperesPerMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Magnetization.From(1, MagnetizationUnit.AmperePerMeter);
            AssertEx.EqualTolerance(1, quantity00.AmperesPerMeter, AmperesPerMeterTolerance);
            Assert.Equal(MagnetizationUnit.AmperePerMeter, quantity00.Unit);

        }

        [Fact]
        public void FromAmperesPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Magnetization.FromAmperesPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Magnetization.FromAmperesPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromAmperesPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Magnetization.FromAmperesPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(AmperesPerMeterInOneAmperePerMeter, amperepermeter.As(MagnetizationUnit.AmperePerMeter), AmperesPerMeterTolerance);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);

            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => amperepermeter.As(UnitSystem.Astronomical));
        }

        [Fact]
        public void As_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);
 
            Assert.Throws<ArgumentNullException>(() => amperepermeter.As(null));
        }

        [Fact]
        public void ToUnit()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);

            var amperepermeterQuantity = amperepermeter.ToUnit(MagnetizationUnit.AmperePerMeter);
            AssertEx.EqualTolerance(AmperesPerMeterInOneAmperePerMeter, (double)amperepermeterQuantity.Value, AmperesPerMeterTolerance);
            Assert.Equal(MagnetizationUnit.AmperePerMeter, amperepermeterQuantity.Unit);
        }

        [Fact]
        public void To_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);

            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => amperepermeter.ToUnit(UnitSystem.Astronomical));
        }

        [Fact]
        public void ToUnit_WithNullUnitSystem_ThrowsNullException()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);
 
            Assert.Throws<ArgumentNullException>(() => amperepermeter.ToUnit(null));
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Magnetization.FromAmperesPerMeter(1).ToBaseUnit();
            Assert.Equal(Magnetization.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(1, Magnetization.FromAmperesPerMeter(amperepermeter.AmperesPerMeter).AmperesPerMeter, AmperesPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Magnetization v = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Magnetization.FromAmperesPerMeter(3)-v).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Magnetization.FromAmperesPerMeter(10)/5).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, Magnetization.FromAmperesPerMeter(10)/Magnetization.FromAmperesPerMeter(5), AmperesPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Magnetization oneAmperePerMeter = Magnetization.FromAmperesPerMeter(1);
            Magnetization twoAmperesPerMeter = Magnetization.FromAmperesPerMeter(2);

            Assert.True(oneAmperePerMeter < twoAmperesPerMeter);
            Assert.True(oneAmperePerMeter <= twoAmperesPerMeter);
            Assert.True(twoAmperesPerMeter > oneAmperePerMeter);
            Assert.True(twoAmperesPerMeter >= oneAmperePerMeter);

            Assert.False(oneAmperePerMeter > twoAmperesPerMeter);
            Assert.False(oneAmperePerMeter >= twoAmperesPerMeter);
            Assert.False(twoAmperesPerMeter < oneAmperePerMeter);
            Assert.False(twoAmperesPerMeter <= oneAmperePerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.Equal(0, amperepermeter.CompareTo(amperepermeter));
            Assert.True(amperepermeter.CompareTo(Magnetization.Zero) > 0);
            Assert.True(Magnetization.Zero.CompareTo(amperepermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.Throws<ArgumentException>(() => amperepermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => amperepermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Magnetization.FromAmperesPerMeter(1);
            var b = Magnetization.FromAmperesPerMeter(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = Magnetization.FromAmperesPerMeter(1);
            var b = Magnetization.FromAmperesPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Magnetization.FromAmperesPerMeter(1);
            object b = Magnetization.FromAmperesPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Magnetization.FromAmperesPerMeter(1);
            Assert.True(v.Equals(Magnetization.FromAmperesPerMeter(1), AmperesPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Magnetization.Zero, AmperesPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Magnetization.FromAmperesPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Magnetization.FromAmperesPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.False(amperepermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.False(amperepermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MagnetizationUnit.Undefined, Magnetization.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MagnetizationUnit)).Cast<MagnetizationUnit>();
            foreach(var unit in units)
            {
                if(unit == MagnetizationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Magnetization.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 A/m", new Magnetization(1, MagnetizationUnit.AmperePerMeter).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 A/m", new Magnetization(1, MagnetizationUnit.AmperePerMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s1"));
                Assert.Equal("0.12 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s2"));
                Assert.Equal("0.123 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s3"));
                Assert.Equal("0.1235 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s1", culture));
            Assert.Equal("0.12 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s2", culture));
            Assert.Equal("0.123 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Magnetization)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MagnetizationUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(QuantityType.Magnetization, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(Magnetization.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(Magnetization.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(new {Magnetization.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Magnetization.FromAmperesPerMeter(value);
            Assert.Equal(Magnetization.FromAmperesPerMeter(-value), -quantity);
        }
    }
}
