// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Diagnostics;
using System.Globalization;
using Fractions;
using System.Numerics;
using Fractions.Formatter;

namespace UnitsNet;

public partial struct QuantityValue
{
    /// <summary>Returns the string representation of the numeric value.</summary>
    public readonly override string ToString()
    {
        return ToString("G");
    }

    /// <summary>
    ///     Returns the string representation of the numeric value, formatted using the given standard numeric format string
    /// </summary>
    /// <param name="format">
    ///     A standard numeric format string (must be valid for either double or decimal, depending on the
    ///     base type)
    /// </param>
    /// <returns>The string representation</returns>
    public readonly string ToString(string format)
    {
        return ToString(format, CultureInfo.CurrentCulture);
    }

    /// <summary>
    ///     Returns the string representation of the numeric value, formatted using the given standard numeric format string
    /// </summary>
    /// <param name="formatProvider">The culture to use</param>
    /// <returns>The string representation</returns>
    public readonly string ToString(IFormatProvider? formatProvider)
    {
        return ToString(string.Empty, formatProvider);
    }

    /// <summary>
    ///     Returns the string representation of the underlying value
    /// </summary>
    /// <param name="format">
    ///     Standard format specifiers. Because the underlying value can be double or decimal, the meaning can
    ///     vary
    /// </param>
    /// <param name="formatProvider">Culture specific settings</param>
    /// <returns>A string representation of the number</returns>
    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        return formatProvider?.GetFormat(typeof(QuantityValue)) is ICustomFormatter formatter
            ? formatter.Format(format, this, formatProvider)
            : DecimalNotationFormatter.Instance.Format(format, _fraction, formatProvider);
    }

    #if NET7_0_OR_GREATER
    /// <inheritdoc/>
    public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        string formattedValue;
        if (provider?.GetFormat(typeof(QuantityValue)) is ICustomFormatter formatter)
        {
            formattedValue = formatter.Format(format.ToString(), this, provider);
        }
        else
        {
            // TODO this overload should be pushed to the DecimalNotationFormatter
            formattedValue = DecimalNotationFormatter.Instance.Format(format.ToString(), _fraction, provider);
        }

        if (formattedValue.Length > destination.Length)
        {
            charsWritten = 0;
            return false;
        }
        
        formattedValue.CopyTo(destination);
        charsWritten = formattedValue.Length;

        return true;
    }
    #endif

    
    internal readonly struct QuantityValueDebugView(QuantityValue value) {
        public BigInteger A => value._fraction.Numerator;
        public BigInteger B => value._fraction.Denominator;
        public FractionState State => value._fraction.State;
        public StringFormatsView StringFormats => new(value);
        public NumericFormatsView ValueFormats => new(value);

        [DebuggerDisplay("{ShortFormat}")]
        internal readonly struct StringFormatsView(QuantityValue value) {
            public string GeneralFormat => DecimalNotationFormatter.Instance
                .Format("g", value._fraction, CultureInfo.CurrentCulture);

            public string ShortFormat => DecimalNotationFormatter.Instance
                .Format("s", value._fraction, CultureInfo.CurrentCulture);

            public string SimplifiedFraction => value._fraction.ToString("m");
        }

        [DebuggerDisplay("{Double}")]
        internal readonly struct NumericFormatsView(QuantityValue value) {
            public int Integer => value._fraction.ToInt32();
            public long Long => value._fraction.ToInt64();
            public decimal Decimal => value.ToDecimal();
            public double Double => value.ToDouble();
        }
    }
}
