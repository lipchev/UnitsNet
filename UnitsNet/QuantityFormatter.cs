// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    /// The QuantityFormatter class is responsible for formatting a quantity using the given format string.
    /// </summary>
    public class QuantityFormatter
    {
        /// <summary>
        /// The available UnitsNet custom format specifiers.
        /// </summary>
        private static readonly char[] UnitsNetFormatSpecifiers = { 'A', 'a', 'G', 'g', 'Q', 'q', 'S', 's', 'U', 'u', 'V', 'v' };

        /// <summary>
        /// Formats a quantity using the given format string and format provider.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// <list type="bullet">
        ///     <item>
        ///         <term>A standard numeric format string.</term>
        ///         <description>Any of the standard numeric format for <see cref="IQuantity.Value" />, except for "G" or "g", which have a special implementation.
        ///         "C" or "c", "E" or "e", "F" or "f", "N" or "n", "P" or "p", "R" or "r" are all accepted.
        ///         See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#standard-format-specifiers.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>"G" or "g".</term>
        ///         <description>The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A" or "a".</term>
        ///         <description>The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A0", "A1", ..., "An" or "a0", "a1", ..., "an".</term>
        ///         <description>The n-th unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        ///         A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.</description>
        ///     </item>
        ///     <item>
        ///         <term>"U" or "u".</term>
        ///         <description>The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".</description>
        ///     </item>
        ///     <item>
        ///         <term>"Q" or "q".</term>
        ///         <description>The quantity name, such as "Length".</description>
        ///     </item>
        /// </list>
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string format)
            where TUnitType : Enum
        {
            return Format(quantity, format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Formats a quantity using the given format string and format provider.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">The format provider to use for localization and number formatting. Defaults to
        /// <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// <list type="bullet">
        ///     <item>
        ///         <term>A standard numeric format string.</term>
        ///         <description>Any of the standard numeric format for <see cref="IQuantity.Value" />, except for "G" or "g", which have a special implementation.
        ///         "C" or "c", "E" or "e", "F" or "f", "N" or "n", "P" or "p", "R" or "r" are all accepted.
        ///         See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#standard-format-specifiers.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>"G" or "g".</term>
        ///         <description>The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A" or "a".</term>
        ///         <description>The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A0", "A1", ..., "An" or "a0", "a1", ..., "an".</term>
        ///         <description>The n-th unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        ///         A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.</description>
        ///     </item>
        ///     <item>
        ///         <term>"U" or "u".</term>
        ///         <description>The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".</description>
        ///     </item>
        ///     <item>
        ///         <term>"Q" or "q".</term>
        ///         <description>The quantity name, such as "Length".</description>
        ///     </item>
        /// </list>
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string? format, IFormatProvider? formatProvider)
            where TUnitType : Enum
        {
            formatProvider ??= CultureInfo.CurrentCulture;

            if (format is null or "" or "g")
            {
                format = "s";
            }
            else if (format is "G")
            {
                format = "S";
            }

            var formatSpecifier = format[0]; // netstandard2.0 nullable quirk

            switch (formatSpecifier)
            {
                case 'A' or 'a': 
                {
                    if (format.Length == 1) 
                    {
                        return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(quantity.Unit, formatProvider);
                    }

                    // "An": The n-th unit abbreviation for
                    if (!int.TryParse(format.Substring(1), out var abbreviationIndex))
                    {
                        throw new FormatException($"The {format} format string is not supported.");
                    }

                    var abbreviations = UnitsNetSetup.Default.UnitAbbreviations.GetUnitAbbreviations(quantity.Unit, formatProvider);

                    if (abbreviationIndex >= abbreviations.Length)
                    {
                        throw new FormatException($"The {format} format string is invalid because the abbreviation index does not exist.");
                    }

                    return abbreviations[abbreviationIndex];
                }
                case 'V' or 'v':
                    return quantity.Value.ToString(formatProvider);
                case 'U' or 'u':
                    return quantity.Unit.ToString();
                case 'Q' or 'q':
                    return quantity.QuantityInfo.Name;
                default: // case of 'S' or 's' or 'G' or 'g' (and anything else) defaults to "{value:format} {abbreviation}" (trimmed as necessary)
                {
                    // TODO see about using the Span<char> overloads (net 8)
                    var valueString = quantity.Value.ToString(format, formatProvider);
                    var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(quantity.Unit, formatProvider);
                    return string.IsNullOrEmpty(abbreviation) ? valueString : valueString + ' ' + abbreviation;
                }
            }
        }
    }
}
