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

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToThermalResistance
{
    /// <summary>
    /// A number to ThermalResistance Extensions
    /// </summary>
    public static class NumberToThermalResistanceExtensions
    {
        /// <inheritdoc cref="ThermalResistance.FromHourSquareFeetDegreesFahrenheitPerBtu(QuantityValue)" />
        public static ThermalResistance HourSquareFeetDegreesFahrenheitPerBtu<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ThermalResistance.FromHourSquareFeetDegreesFahrenheitPerBtu(Convert.ToDouble(value));

        /// <inheritdoc cref="ThermalResistance.FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(QuantityValue)" />
        public static ThermalResistance SquareCentimeterHourDegreesCelsiusPerKilocalorie<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ThermalResistance.FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(Convert.ToDouble(value));

        /// <inheritdoc cref="ThermalResistance.FromSquareCentimeterKelvinsPerWatt(QuantityValue)" />
        public static ThermalResistance SquareCentimeterKelvinsPerWatt<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ThermalResistance.FromSquareCentimeterKelvinsPerWatt(Convert.ToDouble(value));

        /// <inheritdoc cref="ThermalResistance.FromSquareMeterDegreesCelsiusPerWatt(QuantityValue)" />
        public static ThermalResistance SquareMeterDegreesCelsiusPerWatt<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ThermalResistance.FromSquareMeterDegreesCelsiusPerWatt(Convert.ToDouble(value));

        /// <inheritdoc cref="ThermalResistance.FromSquareMeterKelvinsPerKilowatt(QuantityValue)" />
        public static ThermalResistance SquareMeterKelvinsPerKilowatt<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(Convert.ToDouble(value));

        /// <inheritdoc cref="ThermalResistance.FromSquareMeterKelvinsPerWatt(QuantityValue)" />
        public static ThermalResistance SquareMeterKelvinsPerWatt<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ThermalResistance.FromSquareMeterKelvinsPerWatt(Convert.ToDouble(value));

    }
}
