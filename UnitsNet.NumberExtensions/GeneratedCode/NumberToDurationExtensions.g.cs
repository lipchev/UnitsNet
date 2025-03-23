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

namespace UnitsNet.NumberExtensions.NumberToDuration
{
    /// <summary>
    /// A number to Duration Extensions
    /// </summary>
    public static class NumberToDurationExtensions
    {
        /// <inheritdoc cref="Duration.FromDays(double)" />
        public static Duration Days<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromDays(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromDays(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromHours(double)" />
        public static Duration Hours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromHours(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromHours(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromJulianYears(double)" />
        public static Duration JulianYears<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromJulianYears(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromJulianYears(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromMicroseconds(double)" />
        public static Duration Microseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromMicroseconds(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromMicroseconds(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromMilliseconds(double)" />
        public static Duration Milliseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromMilliseconds(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromMilliseconds(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromMinutes(double)" />
        public static Duration Minutes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromMinutes(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromMinutes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromMonths30(double)" />
        public static Duration Months30<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromMonths30(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromMonths30(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromNanoseconds(double)" />
        public static Duration Nanoseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromNanoseconds(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromNanoseconds(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromSeconds(double)" />
        public static Duration Seconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromSeconds(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromSeconds(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromSols(double)" />
        public static Duration Sols<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromSols(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromSols(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromWeeks(double)" />
        public static Duration Weeks<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromWeeks(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromWeeks(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Duration.FromYears365(double)" />
        public static Duration Years365<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Duration.FromYears365(double.CreateChecked(value));
#else
            , IConvertible
            => Duration.FromYears365(value.ToDouble(null));
#endif

    }
}
