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

namespace UnitsNet.NumberExtensions.NumberToRotationalStiffness
{
    /// <summary>
    /// A number to RotationalStiffness Extensions
    /// </summary>
    public static class NumberToRotationalStiffnessExtensions
    {
        /// <inheritdoc cref="RotationalStiffness.FromCentinewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness CentinewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromCentinewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromCentinewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness CentinewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromCentinewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromCentinewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness CentinewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromCentinewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromDecanewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness DecanewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromDecanewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromDecanewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness DecanewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromDecanewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromDecanewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness DecanewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromDecanewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromDecinewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness DecinewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromDecinewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromDecinewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness DecinewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromDecinewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromDecinewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness DecinewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromDecinewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromKilonewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness KilonewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromKilonewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromKilonewtonMetersPerRadian(QuantityValue)" />
        public static RotationalStiffness KilonewtonMetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromKilonewtonMetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromKilonewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness KilonewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromKilonewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromKilonewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness KilonewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromKilonewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromKilopoundForceFeetPerDegrees(QuantityValue)" />
        public static RotationalStiffness KilopoundForceFeetPerDegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromKilopoundForceFeetPerDegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMeganewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness MeganewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMeganewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMeganewtonMetersPerRadian(QuantityValue)" />
        public static RotationalStiffness MeganewtonMetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMeganewtonMetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMeganewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness MeganewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMeganewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMeganewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness MeganewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMeganewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMicronewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness MicronewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMicronewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMicronewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness MicronewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMicronewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMicronewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness MicronewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMicronewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMillinewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness MillinewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMillinewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMillinewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness MillinewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMillinewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromMillinewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness MillinewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromMillinewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNanonewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness NanonewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNanonewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNanonewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness NanonewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNanonewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNanonewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness NanonewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNanonewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNewtonMetersPerDegree(QuantityValue)" />
        public static RotationalStiffness NewtonMetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNewtonMetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNewtonMetersPerRadian(QuantityValue)" />
        public static RotationalStiffness NewtonMetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNewtonMetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNewtonMillimetersPerDegree(QuantityValue)" />
        public static RotationalStiffness NewtonMillimetersPerDegree<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNewtonMillimetersPerDegree(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromNewtonMillimetersPerRadian(QuantityValue)" />
        public static RotationalStiffness NewtonMillimetersPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromNewtonMillimetersPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromPoundForceFeetPerRadian(QuantityValue)" />
        public static RotationalStiffness PoundForceFeetPerRadian<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromPoundForceFeetPerRadian(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalStiffness.FromPoundForceFeetPerDegrees(QuantityValue)" />
        public static RotationalStiffness PoundForceFeetPerDegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RotationalStiffness.FromPoundForceFeetPerDegrees(Convert.ToDouble(value));

    }
}
