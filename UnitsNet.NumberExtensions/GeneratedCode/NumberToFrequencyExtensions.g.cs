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

namespace UnitsNet.NumberExtensions.NumberToFrequency
{
    /// <summary>
    /// A number to Frequency Extensions
    /// </summary>
    public static class NumberToFrequencyExtensions
    {
        /// <inheritdoc cref="Frequency.FromBeatsPerMinute(QuantityValue)" />
        public static Frequency BeatsPerMinute<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromBeatsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(QuantityValue)" />
        public static Frequency CyclesPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromCyclesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(QuantityValue)" />
        public static Frequency CyclesPerMinute<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromCyclesPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromGigahertz(QuantityValue)" />
        public static Frequency Gigahertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromGigahertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromHertz(QuantityValue)" />
        public static Frequency Hertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromHertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromKilohertz(QuantityValue)" />
        public static Frequency Kilohertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromKilohertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromMegahertz(QuantityValue)" />
        public static Frequency Megahertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromMegahertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromMicrohertz(QuantityValue)" />
        public static Frequency Microhertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromMicrohertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromMillihertz(QuantityValue)" />
        public static Frequency Millihertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromMillihertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromPerSecond(QuantityValue)" />
        public static Frequency PerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromRadiansPerSecond(QuantityValue)" />
        public static Frequency RadiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromRadiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromTerahertz(QuantityValue)" />
        public static Frequency Terahertz<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Frequency.FromTerahertz(Convert.ToDouble(value));

    }
}
