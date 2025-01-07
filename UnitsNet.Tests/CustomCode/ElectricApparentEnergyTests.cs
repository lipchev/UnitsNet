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
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class ElectricApparentEnergyTests : ElectricApparentEnergyTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        protected override double VoltampereHoursInOneVoltampereHour => 1;

        protected override double KilovoltampereHoursInOneVoltampereHour => 1E-3;

        protected override double MegavoltampereHoursInOneVoltampereHour => 1E-6;

        [Fact(Skip = "See about adding an SI unit (VoltampereSecond, Joules?)")]
        public override void Ctor_SIUnitSystem_ReturnsQuantityWithSIUnits()
        {
            base.Ctor_SIUnitSystem_ReturnsQuantityWithSIUnits();
        }
        
        [Fact(Skip = "See about changing the BaseUnit to VoltampereSecond or Joule (adding the unit)")]
        public override void BaseUnit_HasSIBase()
        {
            base.BaseUnit_HasSIBase();
        }
        
        [Fact(Skip = "See about adding an SI unit (VoltampereSecond, Joules?)")]
        public override void As_UnitSystem_SI_ReturnsQuantityInSIUnits()
        {
            base.As_UnitSystem_SI_ReturnsQuantityInSIUnits();
        }
        
        [Fact(Skip = "See about adding an SI unit (VoltampereSecond, Joules?)")]
        public override void ToUnit_UnitSystem_SI_ReturnsQuantityInSIUnits()
        {
            base.ToUnit_UnitSystem_SI_ReturnsQuantityInSIUnits();
        }
    }
}
