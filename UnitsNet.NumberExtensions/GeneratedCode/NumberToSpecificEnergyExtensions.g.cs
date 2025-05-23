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

namespace UnitsNet.NumberExtensions.NumberToSpecificEnergy
{
    /// <summary>
    /// A number to SpecificEnergy Extensions
    /// </summary>
    public static class NumberToSpecificEnergyExtensions
    {
        /// <inheritdoc cref="SpecificEnergy.FromBtuPerPound(double)" />
        public static SpecificEnergy BtuPerPound<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromBtuPerPound(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromBtuPerPound(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double)" />
        public static SpecificEnergy CaloriesPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromCaloriesPerGram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromCaloriesPerGram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromGigawattDaysPerKilogram(double)" />
        public static SpecificEnergy GigawattDaysPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromGigawattDaysPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromGigawattDaysPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromGigawattDaysPerShortTon(double)" />
        public static SpecificEnergy GigawattDaysPerShortTon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromGigawattDaysPerShortTon(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromGigawattDaysPerShortTon(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromGigawattDaysPerTonne(double)" />
        public static SpecificEnergy GigawattDaysPerTonne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromGigawattDaysPerTonne(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromGigawattDaysPerTonne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromGigawattHoursPerKilogram(double)" />
        public static SpecificEnergy GigawattHoursPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromGigawattHoursPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromGigawattHoursPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromGigawattHoursPerPound(double)" />
        public static SpecificEnergy GigawattHoursPerPound<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromGigawattHoursPerPound(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromGigawattHoursPerPound(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double)" />
        public static SpecificEnergy JoulesPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromJoulesPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromJoulesPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double)" />
        public static SpecificEnergy KilocaloriesPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilocaloriesPerGram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilocaloriesPerGram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double)" />
        public static SpecificEnergy KilojoulesPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilojoulesPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilojoulesPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilowattDaysPerKilogram(double)" />
        public static SpecificEnergy KilowattDaysPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilowattDaysPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilowattDaysPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilowattDaysPerShortTon(double)" />
        public static SpecificEnergy KilowattDaysPerShortTon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilowattDaysPerShortTon(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilowattDaysPerShortTon(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilowattDaysPerTonne(double)" />
        public static SpecificEnergy KilowattDaysPerTonne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilowattDaysPerTonne(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilowattDaysPerTonne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double)" />
        public static SpecificEnergy KilowattHoursPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilowattHoursPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilowattHoursPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerPound(double)" />
        public static SpecificEnergy KilowattHoursPerPound<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromKilowattHoursPerPound(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromKilowattHoursPerPound(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double)" />
        public static SpecificEnergy MegajoulesPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegajoulesPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegajoulesPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegaJoulesPerTonne(double)" />
        public static SpecificEnergy MegaJoulesPerTonne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegaJoulesPerTonne(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegaJoulesPerTonne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegawattDaysPerKilogram(double)" />
        public static SpecificEnergy MegawattDaysPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegawattDaysPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegawattDaysPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegawattDaysPerShortTon(double)" />
        public static SpecificEnergy MegawattDaysPerShortTon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegawattDaysPerShortTon(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegawattDaysPerShortTon(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegawattDaysPerTonne(double)" />
        public static SpecificEnergy MegawattDaysPerTonne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegawattDaysPerTonne(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegawattDaysPerTonne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double)" />
        public static SpecificEnergy MegawattHoursPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegawattHoursPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegawattHoursPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerPound(double)" />
        public static SpecificEnergy MegawattHoursPerPound<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromMegawattHoursPerPound(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromMegawattHoursPerPound(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromTerawattDaysPerKilogram(double)" />
        public static SpecificEnergy TerawattDaysPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromTerawattDaysPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromTerawattDaysPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromTerawattDaysPerShortTon(double)" />
        public static SpecificEnergy TerawattDaysPerShortTon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromTerawattDaysPerShortTon(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromTerawattDaysPerShortTon(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromTerawattDaysPerTonne(double)" />
        public static SpecificEnergy TerawattDaysPerTonne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromTerawattDaysPerTonne(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromTerawattDaysPerTonne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromWattDaysPerKilogram(double)" />
        public static SpecificEnergy WattDaysPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromWattDaysPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromWattDaysPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromWattDaysPerShortTon(double)" />
        public static SpecificEnergy WattDaysPerShortTon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromWattDaysPerShortTon(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromWattDaysPerShortTon(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromWattDaysPerTonne(double)" />
        public static SpecificEnergy WattDaysPerTonne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromWattDaysPerTonne(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromWattDaysPerTonne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double)" />
        public static SpecificEnergy WattHoursPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromWattHoursPerKilogram(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromWattHoursPerKilogram(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerPound(double)" />
        public static SpecificEnergy WattHoursPerPound<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificEnergy.FromWattHoursPerPound(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificEnergy.FromWattHoursPerPound(value.ToDouble(null));
#endif

    }
}
