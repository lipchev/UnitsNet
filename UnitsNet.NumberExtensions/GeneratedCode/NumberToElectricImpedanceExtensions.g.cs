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

namespace UnitsNet.NumberExtensions.NumberToElectricImpedance
{
    /// <summary>
    /// A number to ElectricImpedance Extensions
    /// </summary>
    [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
    public static class NumberToElectricImpedanceExtensions
    {
        /// <inheritdoc cref="ElectricImpedance.FromGigaohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Gigaohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromGigaohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromGigaohms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromKiloohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Kiloohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromKiloohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromKiloohms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromMegaohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Megaohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromMegaohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromMegaohms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromMicroohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Microohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromMicroohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromMicroohms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromMilliohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Milliohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromMilliohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromMilliohms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromNanoohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Nanoohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromNanoohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromNanoohms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromOhms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Ohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromOhms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromOhms(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricImpedance.FromTeraohms(double)" />
        [Obsolete("Impedance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricResistance or ElectricReactance instead.")]
        public static ElectricImpedance Teraohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricImpedance.FromTeraohms(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricImpedance.FromTeraohms(value.ToDouble(null));
#endif

    }
}
