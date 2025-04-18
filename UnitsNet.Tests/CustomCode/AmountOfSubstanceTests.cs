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
        protected override double PicomolesInOneMole => 1e12;
        protected override double FemtomolesInOneMole => 1e15;
        
        [Fact]
        public void AllBaseQuantityUnitsAreBaseUnits()
        {
            Assert.All(AmountOfSubstance.Info.UnitInfos, unitInfo => Assert.Equal(new BaseUnits(amount: unitInfo.Value), unitInfo.BaseUnits));
        }

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
        // 10 Moles of Oxygen weight 10 times as much as 1 Mole of Oxygen (MolarMass)
        [InlineData(10, AmountOfSubstanceUnit.Mole,
                    KnownQuantities.MolarMassOfOxygen, MolarMassUnit.GramPerMole,
                    10 * KnownQuantities.MolarMassOfOxygen, MassUnit.Gram)]
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
        // molarity(HCl) = 5g / (1.2L * 36.46) = 0.114 mol/l = 0.114 M
        [InlineData(5, MassUnit.Gram,
                    KnownQuantities.MolarMassHClInGramsPerMole, MolarMassUnit.GramPerMole,
                    1.2, VolumeUnit.Liter,
                    0.1142805, MolarityUnit.MolePerLiter)]
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
        // 1.2 L of solution required for obtaining 0.1142805 Moles/L from 5g HCl
        [InlineData(5, MassUnit.Gram,
                    KnownQuantities.MolarMassHClInGramsPerMole, MolarMassUnit.GramPerMole,
                    0.1142805, MolarityUnit.MolePerLiter,
                    1.2, VolumeUnit.Liter)]
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

        [Fact]
        public void From_Mass_And_MolarMass_ReturnsTheMassDividedByTheMolarMass()
        {
            var mass = Mass.From(10, MassUnit.Gram);
            var molarMass = MolarMass.From(2, MolarMassUnit.GramPerMole);
            var expectedAmountOfSubstance = AmountOfSubstance.From(5, AmountOfSubstanceUnit.Mole);

            var amountOfSubstance = AmountOfSubstance.FromMass(mass, molarMass);

            Assert.Equal(expectedAmountOfSubstance, amountOfSubstance);
        }

        [Fact]
        public void Multiplying_AmountOfSubstance_By_MolarEnergy_ReturnsEnergy()
        {
            Energy energy = AmountOfSubstance.FromMoles(5) * MolarEnergy.FromJoulesPerMole(10);
            Assert.Equal(Energy.FromJoules(50), energy);
        }

        [Fact]
        public void Dividing_AmountOfSubstance_By_MolarFlow_Returns_Duration()
        {
            var duration = AmountOfSubstance.FromMoles(10) / MolarFlow.FromMolesPerSecond(2);
            Assert.Equal(Duration.FromSeconds(5), duration);
        }

        [Fact]
        public void Dividing_AmountOfSubstance_By_Duration_Returns_MolarFlow()
        {
            MolarFlow molarFlow = AmountOfSubstance.FromMoles(10) / Duration.FromSeconds(5);
            Assert.Equal(MolarFlow.FromMolesPerSecond(2), molarFlow);
        }
    }
}
