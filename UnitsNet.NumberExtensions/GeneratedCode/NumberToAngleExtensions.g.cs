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

namespace UnitsNet.NumberExtensions.NumberToAngle
{
    /// <summary>
    /// A number to Angle Extensions
    /// </summary>
    public static class NumberToAngleExtensions
    {
        /// <inheritdoc cref="Angle.FromArcminutes(QuantityValue)" />
        public static Angle Arcminutes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromArcminutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromArcseconds(QuantityValue)" />
        public static Angle Arcseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromArcseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromCentiradians(QuantityValue)" />
        public static Angle Centiradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromCentiradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromDeciradians(QuantityValue)" />
        public static Angle Deciradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromDeciradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromDegrees(QuantityValue)" />
        public static Angle Degrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromDegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromGradians(QuantityValue)" />
        public static Angle Gradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromGradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMicrodegrees(QuantityValue)" />
        public static Angle Microdegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromMicrodegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMicroradians(QuantityValue)" />
        public static Angle Microradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromMicroradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMillidegrees(QuantityValue)" />
        public static Angle Millidegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromMillidegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMilliradians(QuantityValue)" />
        public static Angle Milliradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromMilliradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNanodegrees(QuantityValue)" />
        public static Angle Nanodegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromNanodegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNanoradians(QuantityValue)" />
        public static Angle Nanoradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromNanoradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNatoMils(QuantityValue)" />
        public static Angle NatoMils<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromNatoMils(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromRadians(QuantityValue)" />
        public static Angle Radians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromRadians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromRevolutions(QuantityValue)" />
        public static Angle Revolutions<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Angle.FromRevolutions(Convert.ToDouble(value));

    }
}
