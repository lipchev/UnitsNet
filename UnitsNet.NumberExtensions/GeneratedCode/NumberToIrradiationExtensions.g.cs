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

namespace UnitsNet.NumberExtensions.NumberToIrradiation
{
    /// <summary>
    /// A number to Irradiation Extensions
    /// </summary>
    public static class NumberToIrradiationExtensions
    {
        /// <inheritdoc cref="Irradiation.FromBtusPerSquareFoot(QuantityValue)" />
        public static Irradiation BtusPerSquareFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromBtusPerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(QuantityValue)" />
        public static Irradiation JoulesPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromJoulesPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(QuantityValue)" />
        public static Irradiation JoulesPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromJoulesPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(QuantityValue)" />
        public static Irradiation JoulesPerSquareMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromJoulesPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromKilobtusPerSquareFoot(QuantityValue)" />
        public static Irradiation KilobtusPerSquareFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromKilobtusPerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(QuantityValue)" />
        public static Irradiation KilojoulesPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromKilojoulesPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(QuantityValue)" />
        public static Irradiation KilowattHoursPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromKilowattHoursPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(QuantityValue)" />
        public static Irradiation MillijoulesPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromMillijoulesPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(QuantityValue)" />
        public static Irradiation WattHoursPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Irradiation.FromWattHoursPerSquareMeter(Convert.ToDouble(value));

    }
}
