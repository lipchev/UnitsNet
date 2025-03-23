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

namespace UnitsNet.NumberExtensions.NumberToRotationalSpeed
{
    /// <summary>
    /// A number to RotationalSpeed Extensions
    /// </summary>
    public static class NumberToRotationalSpeedExtensions
    {
        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(double)" />
        public static RotationalSpeed CentiradiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromCentiradiansPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromCentiradiansPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(double)" />
        public static RotationalSpeed DeciradiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromDeciradiansPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromDeciradiansPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(double)" />
        public static RotationalSpeed DegreesPerMinute<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromDegreesPerMinute(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromDegreesPerMinute(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(double)" />
        public static RotationalSpeed DegreesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromDegreesPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromDegreesPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(double)" />
        public static RotationalSpeed MicrodegreesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromMicrodegreesPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromMicrodegreesPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(double)" />
        public static RotationalSpeed MicroradiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromMicroradiansPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromMicroradiansPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(double)" />
        public static RotationalSpeed MillidegreesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromMillidegreesPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromMillidegreesPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(double)" />
        public static RotationalSpeed MilliradiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromMilliradiansPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromMilliradiansPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(double)" />
        public static RotationalSpeed NanodegreesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromNanodegreesPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromNanodegreesPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(double)" />
        public static RotationalSpeed NanoradiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromNanoradiansPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromNanoradiansPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(double)" />
        public static RotationalSpeed RadiansPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromRadiansPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromRadiansPerSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(double)" />
        public static RotationalSpeed RevolutionsPerMinute<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromRevolutionsPerMinute(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromRevolutionsPerMinute(value.ToDouble(null));
#endif

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(double)" />
        public static RotationalSpeed RevolutionsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => RotationalSpeed.FromRevolutionsPerSecond(double.CreateChecked(value));
#else
            , IConvertible
            => RotationalSpeed.FromRevolutionsPerSecond(value.ToDouble(null));
#endif

    }
}
