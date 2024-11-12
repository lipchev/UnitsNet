// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Numerics;
using Fractions;

namespace UnitsNet;

public partial struct QuantityValue
{
    internal static readonly BigInteger Ten = 10;

    /// <summary>
    ///     Parses a string representation of a quantity value into a QuantityValue object.
    /// </summary>
    /// <param name="s">The string representation of the quantity value.</param>
    /// <param name="provider">
    ///     A NumberStyles value that indicates the style elements that can be present in
    ///     valueString.
    /// </param>
    /// <returns>A QuantityValue object that represents the parsed string.</returns>
    /// <exception cref="System.ArgumentNullException">Thrown when the provided string argument is null.</exception>
    /// <exception cref="System.FormatException">
    ///     Thrown when the format of the provided string argument is invalid and cannot
    ///     be successfully parsed into a Fraction.
    /// </exception>
    public static QuantityValue Parse(string s, IFormatProvider? provider)
    {
        return Parse(s, NumberStyles.Any, provider);
    }

    /// <summary>
    ///     Parses a string representation of a quantity value into a QuantityValue object.
    /// </summary>
    /// <param name="s">The string representation of the quantity value.</param>
    /// <param name="style">
    ///     A NumberStyles value that indicates the style elements that can be present in
    ///     valueString.
    /// </param>
    /// <param name="provider">
    ///     An IFormatProvider that supplies culture-specific formatting information about
    ///     valueString.
    /// </param>
    /// <returns>A QuantityValue object that represents the parsed string.</returns>
    /// <exception cref="System.ArgumentNullException">Thrown when the provided string argument is null.</exception>
    /// <exception cref="System.FormatException">
    ///     Thrown when the format of the provided string argument is invalid and cannot
    ///     be successfully parsed into a Fraction.
    /// </exception>
    public static QuantityValue Parse(string s, NumberStyles style, IFormatProvider? provider)
    {
        if (TryParse(s, style, provider, out QuantityValue valueParsed))
        {
            return valueParsed;
        }

        throw new FormatException(
            $"The format of the provided string argument '{s}' is invalid and cannot be successfully parsed into a QuantityValue.");
    }

    /// <summary>
    ///     Tries to convert the string representation of a quantity value to its QuantityValue equivalent, and returns a value
    ///     that indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="s">A string containing a quantity value to convert.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
    /// <param name="result">
    ///     When this method returns, contains the QuantityValue equivalent to the quantity value contained in
    ///     s, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the s parameter is null
    ///     or is not of the correct format. This parameter is passed uninitialized; any value originally supplied in result
    ///     will be overwritten.
    /// </param>
    /// <returns>true if s was converted successfully; otherwise, false.</returns>
    public static bool TryParse(string? s, IFormatProvider? provider, out QuantityValue result)
    {
        return TryParse(s, NumberStyles.Any, provider, out result);
    }

    /// <summary>
    ///     Tries to convert the string representation of a quantity value to its QuantityValue equivalent, and returns a value
    ///     that indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="s">The string representation of a quantity value. This parameter can be null.</param>
    /// <param name="styles">
    ///     A NumberStyles value that indicates the style elements that can be present in s.
    /// </param>
    /// <param name="provider">
    ///     An IFormatProvider that supplies culture-specific formatting information about s. This parameter can be null.
    /// </param>
    /// <param name="result">
    ///     When this method returns, contains the QuantityValue equivalent to the quantity value
    ///     contained in valueString, if the conversion succeeded, or zero if the conversion failed. The conversion fails if
    ///     the s parameter is null or is not of the correct format. This parameter is passed uninitialized.
    /// </param>
    /// <returns>true if valueString was converted successfully; otherwise, false.</returns>
    public static bool TryParse(string? s, NumberStyles styles, IFormatProvider? provider, out QuantityValue result)
    {
        if (Fraction.TryParse(s, styles, provider, false, out Fraction fraction))
        {
            result = new QuantityValue(fraction);
            return true;
        }

        result = default;
        return false;
    }

#if NET
    /// <inheritdoc />
    public static QuantityValue Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
    {
        return Parse(s, NumberStyles.Any, provider);
    }

    /// <inheritdoc />
    public static QuantityValue Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
    {
        // TODO see about adding this overload to the Fractions
        if (Fraction.TryParse(s, style, provider, false, out Fraction fraction))
        {
            return new QuantityValue(fraction);
        }

        throw new FormatException(
            $"The format of the provided string argument '{s}' is invalid and cannot be successfully parsed into a QuantityValue.");
    }

    /// <inheritdoc />
    public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out QuantityValue result)
    {
        return TryParse(s, NumberStyles.Any, provider, out result);
    }

    /// <inheritdoc />
    public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out QuantityValue result)
    {
        if (Fraction.TryParse(s, style, provider, false, out Fraction fraction))
        {
            result = new QuantityValue(fraction);
            return true;
        }

        result = default;
        return false;
    }
#endif
}
