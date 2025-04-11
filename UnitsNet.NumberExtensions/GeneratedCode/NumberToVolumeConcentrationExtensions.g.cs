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

namespace UnitsNet.NumberExtensions.NumberToVolumeConcentration
{
    /// <summary>
    /// A number to VolumeConcentration Extensions
    /// </summary>
    public static class NumberToVolumeConcentrationExtensions
    {
        /// <inheritdoc cref="VolumeConcentration.FromCentilitersPerLiter(double)" />
        public static VolumeConcentration CentilitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromCentilitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromCentilitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromCentilitersPerMilliliter(double)" />
        public static VolumeConcentration CentilitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromCentilitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromCentilitersPerMilliliter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromDecilitersPerLiter(double)" />
        public static VolumeConcentration DecilitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromDecilitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromDecilitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromDecilitersPerMilliliter(double)" />
        public static VolumeConcentration DecilitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromDecilitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromDecilitersPerMilliliter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromDecimalFractions(double)" />
        public static VolumeConcentration DecimalFractions<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromDecimalFractions(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromDecimalFractions(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromLitersPerLiter(double)" />
        public static VolumeConcentration LitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromLitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromLitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromLitersPerMilliliter(double)" />
        public static VolumeConcentration LitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromLitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromLitersPerMilliliter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromMicrolitersPerLiter(double)" />
        public static VolumeConcentration MicrolitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromMicrolitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromMicrolitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromMicrolitersPerMilliliter(double)" />
        public static VolumeConcentration MicrolitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromMicrolitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromMicrolitersPerMilliliter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromMillilitersPerLiter(double)" />
        public static VolumeConcentration MillilitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromMillilitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromMillilitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromMillilitersPerMilliliter(double)" />
        public static VolumeConcentration MillilitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromMillilitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromMillilitersPerMilliliter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromNanolitersPerLiter(double)" />
        public static VolumeConcentration NanolitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromNanolitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromNanolitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromNanolitersPerMilliliter(double)" />
        public static VolumeConcentration NanolitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromNanolitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromNanolitersPerMilliliter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerBillion(double)" />
        public static VolumeConcentration PartsPerBillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPartsPerBillion(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPartsPerBillion(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerMillion(double)" />
        public static VolumeConcentration PartsPerMillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPartsPerMillion(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPartsPerMillion(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerThousand(double)" />
        public static VolumeConcentration PartsPerThousand<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPartsPerThousand(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPartsPerThousand(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerTrillion(double)" />
        public static VolumeConcentration PartsPerTrillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPartsPerTrillion(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPartsPerTrillion(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPercent(double)" />
        public static VolumeConcentration Percent<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPercent(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPercent(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPicolitersPerLiter(double)" />
        public static VolumeConcentration PicolitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPicolitersPerLiter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPicolitersPerLiter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="VolumeConcentration.FromPicolitersPerMilliliter(double)" />
        public static VolumeConcentration PicolitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => VolumeConcentration.FromPicolitersPerMilliliter(double.CreateChecked(value));
#else
            , IConvertible
            => VolumeConcentration.FromPicolitersPerMilliliter(value.ToDouble(null));
#endif

    }
}
