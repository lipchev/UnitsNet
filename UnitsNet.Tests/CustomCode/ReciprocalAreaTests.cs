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

using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class ReciprocalAreaTests : ReciprocalAreaTestsBase
    {
        protected override double InverseSquareMetersInOneInverseSquareMeter => 1;
        protected override double InverseSquareKilometersInOneInverseSquareMeter => 1E6;
        protected override double InverseSquareDecimetersInOneInverseSquareMeter => 1E-2;
        protected override double InverseSquareCentimetersInOneInverseSquareMeter => 1E-4;
        protected override double InverseSquareMillimetersInOneInverseSquareMeter => 1E-6;
        protected override double InverseSquareMicrometersInOneInverseSquareMeter => 1E-12;

        protected override double InverseSquareMilesInOneInverseSquareMeter => 2.59E6;
        protected override double InverseSquareYardsInOneInverseSquareMeter => 0.836127;
        protected override double InverseSquareFeetInOneInverseSquareMeter => 0.092903;
        protected override double InverseUsSurveySquareFeetInOneInverseSquareMeter => 0.09290341161;
        protected override double InverseSquareInchesInOneInverseSquareMeter => 0.00064516;

        [Theory]
        [InlineData(-2.0, -0.5)]
        [InlineData(-1.0, -1.0)]
        [InlineData(0.0, double.PositiveInfinity)]
        [InlineData(1.0, 1.0)]
        [InlineData(2.0, 0.5)]
        public void InverseReturnsArea(double value, double expected)
        {
            var inverseArea = new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareMeter);
            var area = inverseArea.Inverse();

            Assert.Equal(expected, area.SquareMeters);
        }

        [Fact]
        public void ReciprocalAreaTimesForceEqualsPressure()
        {
            Pressure pressure = ReciprocalArea.FromInverseSquareMeters(25) * Force.FromNewtons(2);
            Assert.Equal(pressure, Pressure.FromNewtonsPerSquareMeter(50));
        }

        [Fact]
        public void ReciprocalAreaTimesAreaEqualsRatio()
        {
            Ratio ratio = ReciprocalArea.FromInverseSquareMeters(10) * Area.FromSquareMeters(0.5);
            Assert.Equal(5.0, ratio.Value);
        }

        [Fact]
        public void ReciprocalAreaDividedByReciprocalLengthEqualsReciprocalLength()
        {
            ReciprocalLength reciprocalLength = ReciprocalArea.FromInverseSquareMeters(10) / ReciprocalLength.FromInverseMeters(0.5);
            Assert.Equal(reciprocalLength, ReciprocalLength.FromInverseMeters(20));
        }
    }
}
