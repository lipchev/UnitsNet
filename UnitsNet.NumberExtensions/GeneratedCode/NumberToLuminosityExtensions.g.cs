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

namespace UnitsNet.NumberExtensions.NumberToLuminosity
{
    /// <summary>
    /// A number to Luminosity Extensions
    /// </summary>
    public static class NumberToLuminosityExtensions
    {
        /// <inheritdoc cref="Luminosity.FromDecawatts(QuantityValue)" />
        public static Luminosity Decawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromDecawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromDeciwatts(QuantityValue)" />
        public static Luminosity Deciwatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromDeciwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromFemtowatts(QuantityValue)" />
        public static Luminosity Femtowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromFemtowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromGigawatts(QuantityValue)" />
        public static Luminosity Gigawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromGigawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromKilowatts(QuantityValue)" />
        public static Luminosity Kilowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromKilowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromMegawatts(QuantityValue)" />
        public static Luminosity Megawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromMegawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromMicrowatts(QuantityValue)" />
        public static Luminosity Microwatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromMicrowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromMilliwatts(QuantityValue)" />
        public static Luminosity Milliwatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromMilliwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromNanowatts(QuantityValue)" />
        public static Luminosity Nanowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromNanowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromPetawatts(QuantityValue)" />
        public static Luminosity Petawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromPetawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromPicowatts(QuantityValue)" />
        public static Luminosity Picowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromPicowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromSolarLuminosities(QuantityValue)" />
        public static Luminosity SolarLuminosities<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromSolarLuminosities(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromTerawatts(QuantityValue)" />
        public static Luminosity Terawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromTerawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Luminosity.FromWatts(QuantityValue)" />
        public static Luminosity Watts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Luminosity.FromWatts(Convert.ToDouble(value));

    }
}
