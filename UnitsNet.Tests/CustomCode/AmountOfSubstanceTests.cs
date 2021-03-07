﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class AmountOfSubstanceTests : AmountOfSubstanceTestsBase
    {
        protected override double CentimolesInOneMole => 1e2;
        protected override double CentipoundMolesInOneMole => 0.002204622621848776 * 1e2;
        protected override double DecimolesInOneMole => 1e1;
        protected override double DecipoundMolesInOneMole => 0.002204622621848776 * 1e1;
        protected override double KilomolesInOneMole => 1e-3;
        protected override double KilopoundMolesInOneMole => 0.002204622621848776 * 1e-3;
        protected override double MicromolesInOneMole => 1e6;
        protected override double MicropoundMolesInOneMole => 0.002204622621848776 * 1e6;
        protected override double MillimolesInOneMole => 1e3;
        protected override double MillipoundMolesInOneMole => 0.002204622621848776 * 1e3;
        protected override double MolesInOneMole => 1;
        protected override double NanomolesInOneMole => 1e9;
        protected override double NanopoundMolesInOneMole => 0.002204622621848776 * 1e9;
        protected override double PoundMolesInOneMole => 0.002204622621848776;
        protected override double MegamolesInOneMole => 1e-6;

        [Fact]
        public void NumberOfParticlesInOneMoleEqualsAvogadroConstant()
        {
            var oneMole = AmountOfSubstance.FromMoles(1);
            var numberOfParticles = oneMole.NumberOfParticles();
            Assert.Equal(AmountOfSubstance.AvogadroConstant, numberOfParticles);
        }

        [Fact]
        public void NumberOfParticlesInTwoMolesIsDoubleAvogadroConstant()
        {
            var twoMoles = AmountOfSubstance.FromMoles(2);
            var numberOfParticles = twoMoles.NumberOfParticles();
            Assert.Equal(AmountOfSubstance.AvogadroConstant * 2, numberOfParticles);
        }

        [Theory]
        [InlineData(10, AmountOfSubstanceUnit.Mole,
                    KnownQuantities.MolarMassOfOxygen, MolarMassUnit.GramPerMole,
                    10 * KnownQuantities.MolarMassOfOxygen, MassUnit.Gram)]     // 10 Moles of Oxygen weight 10 times as much as 1 Mole of Oxygen (MolarMass)
        public void MassFromAmountOfSubstanceAndMolarMass(
            double amountOfSubstanceValue, AmountOfSubstanceUnit amountOfSubstanceUnit,
            double molarMassValue, MolarMassUnit molarMassUnit,
            double expectedMass, MassUnit expectedMassUnit, double tolerence = 1e-5)
        {
            AmountOfSubstance amountOfSubstance = new AmountOfSubstance(amountOfSubstanceValue, amountOfSubstanceUnit);
            MolarMass molarMass = new MolarMass(molarMassValue, molarMassUnit);

            Mass mass = amountOfSubstance * molarMass;

            AssertEx.EqualTolerance(expectedMass, mass.As(expectedMassUnit), tolerence);
        }

        [Theory]
        [InlineData(5, MassUnit.Gram,
                    KnownQuantities.MolarMassHClInGramsPerMole, MolarMassUnit.GramPerMole,
                    1.2, VolumeUnit.Liter,
                    0.1142805, MolarityUnit.MolesPerLiter)]     // molarity(HCl) = 5g / (1.2L * 36.46) = 0.114 mol/l = 0.114 M
        public void MolarityFromComponentMassAndSolutionVolume(
            double componentMassValue, MassUnit componentMassUnit,
            double componentMolarMassValue, MolarMassUnit componentMolarMassUnit,
            double solutionVolumeValue, VolumeUnit solutionVolumeUnit,
            double expectedMolarityValue, MolarityUnit expectedMolarityUnit, double tolerence = 1e-5)
        {
            var componentMass = new Mass(componentMassValue, componentMassUnit);
            var componentMolarMass = new MolarMass(componentMolarMassValue, componentMolarMassUnit);
            var volumeSolution = new Volume(solutionVolumeValue, solutionVolumeUnit);
            AmountOfSubstance amountOfSubstance = componentMass / componentMolarMass;

            Molarity molarity = amountOfSubstance / volumeSolution;

            AssertEx.EqualTolerance(expectedMolarityValue, molarity.As(expectedMolarityUnit), tolerence);
        }

        [Theory]
        [InlineData(5, MassUnit.Gram,
                    KnownQuantities.MolarMassHClInGramsPerMole, MolarMassUnit.GramPerMole,
                    0.1142805, MolarityUnit.MolesPerLiter,
                    1.2, VolumeUnit.Liter)]     // 1.2 L of solution required for obtaining 0.1142805 Moles/L from 5g HCl
        public void VolumeSolutionFromComponentMassAndDesiredConcentration(
            double componentMassValue, MassUnit componentMassUnit,
            double componentMolarMassValue, MolarMassUnit componentMolarMassUnit,
            double desiredMolarityValue, MolarityUnit desiredMolarityUnit,
            double expectedSolutionVolumeValue, VolumeUnit expectedSolutionVolumeUnit, double tolerence = 1e-5)
        {
            var componentMass = new Mass(componentMassValue, componentMassUnit);
            var componentMolarMass = new MolarMass(componentMolarMassValue, componentMolarMassUnit);
            var desiredMolarity = new Molarity(desiredMolarityValue, desiredMolarityUnit);
            AmountOfSubstance amountOfSubstance = componentMass / componentMolarMass;

            Volume volumeSolution = amountOfSubstance / desiredMolarity;

            AssertEx.EqualTolerance(expectedSolutionVolumeValue, volumeSolution.As(expectedSolutionVolumeUnit), tolerence);
        }
    }
}
