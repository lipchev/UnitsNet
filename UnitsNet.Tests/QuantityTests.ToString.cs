﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using UnitsNet.Tests.Helpers;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public partial class QuantityTests
    {
        public class ToStringTests
        {
            [Fact]
            public void ReturnsTheOriginalValueAndUnit()
            {
                var culture = CultureInfo.InvariantCulture;
                Assert.Equal("5 kg", Mass.FromKilograms(5).ToString(culture));
                Assert.Equal("5000 g", Mass.FromGrams(5000).ToString(culture));
                Assert.Equal("0.0001 long tn", Mass.FromLongTons(1e-4).ToString(culture));
                Assert.Equal("0.00034567 dN/m", ForcePerLength.FromDecinewtonsPerMeter(0.00034567).ToString(culture));
                Assert.Equal("0.0069 dB", Level.FromDecibels(0.0069).ToString(culture));
                Assert.Equal("0.011 kWh/kg", SpecificEnergy.FromKilowattHoursPerKilogram(0.011).ToString(culture));
                //                Assert.Equal("0.1 MJ/kg·C", SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(0.1).ToString(culture));
                Assert.Equal("0.1 MJ/kg·°C", SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(0.1).ToString(culture));
                Assert.Equal("5 cm", Length.FromCentimeters(5).ToString(culture));
            }

            [Fact]
            public void FormatsNumberUsingGivenCulture()
            {
                using var _ = new CultureScope(CultureInfo.InvariantCulture);
                Assert.Equal("0.05 m", Length.FromCentimeters(5).ToUnit(LengthUnit.Meter).ToString((IFormatProvider?)null));
                Assert.Equal("0.05 m", Length.FromCentimeters(5).ToUnit(LengthUnit.Meter).ToString(CultureInfo.InvariantCulture));
                Assert.Equal("0,05 m", Length.FromCentimeters(5).ToUnit(LengthUnit.Meter).ToString(CultureInfo.GetCultureInfo("nb-NO")));
            }
        }
    }
}
