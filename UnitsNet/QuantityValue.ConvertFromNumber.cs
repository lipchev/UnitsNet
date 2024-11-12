// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Fractions;

namespace UnitsNet;

public partial struct QuantityValue
{
    /// <summary>Implicit cast from <see cref="byte" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(byte value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>Implicit cast from <see cref="short" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(short value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>Implicit cast from <see cref="int" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(int value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>Implicit cast from <see cref="uint" /> to <see cref="QuantityValue" />.</summary>
    [CLSCompliant(false)]
    public static implicit operator QuantityValue(uint value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>Implicit cast from <see cref="long" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(long value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>Implicit cast from <see cref="ulong" /> to <see cref="QuantityValue" />.</summary>
    [CLSCompliant(false)]
    public static implicit operator QuantityValue(ulong value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>Implicit cast from <see cref="float" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(float value)
    {
        return FromDoubleRounded(value);
    }

    /// <summary>Implicit cast from <see cref="double" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(double value)
    {
        return FromDoubleRounded(value);
    }

    /// <summary>Implicit cast from <see cref="decimal" /> to <see cref="QuantityValue" />.</summary>
    public static implicit operator QuantityValue(decimal value)
    {
        return new QuantityValue(Fraction.FromDecimal(value, false));
    }

    /// <summary>Implicit cast from <see cref="QuantityValue" /> to <see cref="BigInteger" />.</summary>
    public static implicit operator QuantityValue(BigInteger value)
    {
        return new QuantityValue(value, BigInteger.One);
    }

    /// <summary>
    ///     Creates a new QuantityValue from a decimal number.
    /// </summary>
    /// <param name="value">The decimal number to convert into a QuantityValue.</param>
    /// <returns>A new QuantityValue that represents the given decimal number.</returns>
    public static QuantityValue FromDecimal(decimal value)
    {
        return new QuantityValue(Fraction.FromDecimal(value, false));
    }

    /// <summary>
    ///     Converts a floating point value to a QuantityValue. The value is rounded if possible.
    /// </summary>
    /// <param name="value">The floating point value to convert.</param>
    /// <param name="nbSignificantDigits"></param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Thrown when the number of significant digits is less than 1 or greater than 17.
    /// </exception>
    /// <returns>A QuantityValue representing the rounded floating point value.</returns>
    /// <remarks>
    ///     The double data type stores its values as 64-bit floating point numbers in accordance with the IEC 60559:1989 (IEEE
    ///     754) standard for binary floating-point arithmetic.
    ///     However, the double data type cannot precisely store some numbers. For instance, 1/10, which is accurately
    ///     represented by .1 as a decimal fraction, is represented by .0001100110011... as a binary fraction, with the pattern
    ///     0011 repeating indefinitely.
    ///     In such cases, the floating-point value provides an approximate representation of the number.
    ///     <para>
    ///         This method can be used to avoid large numbers in the numerator and denominator while also making it safe to
    ///         use in comparison operations with other values.
    ///         <code>
    /// QuantityValue value = QuantityValue.FromDoubleRounded(0.1, 15); // returns {1/10}, which is exactly 0.1
    /// </code>
    ///     </para>
    /// </remarks>
    /// <example>
    ///     <code>
    /// QuantityValue qv = QuantityValue.FromDoubleRounded(0.1);
    /// // Output: 1/10, which is exactly 0.1
    /// </code>
    /// </example>
    public static QuantityValue FromDoubleRounded(double value, int nbSignificantDigits = 15)
    {
        return new QuantityValue(Fraction.FromDoubleRounded(value, nbSignificantDigits, false));
    }

    /// <summary>
    ///     Converts a floating point value to a QuantityValue.
    /// </summary>
    /// <param name="value">The floating point value to convert.</param>
    /// <returns>A QuantityValue representing the given floating point value.</returns>
    /// <remarks>
    ///     The double data type stores its values as 64-bit floating point numbers in accordance with the IEC 60559:1989 (IEEE
    ///     754) standard for binary floating-point arithmetic.
    ///     However, the double data type cannot precisely store some binary fractions. For instance, 1/10, which is accurately
    ///     represented by .1 as a decimal fraction, is represented by .0001100110011... as a binary fraction, with the pattern
    ///     0011 repeating indefinitely.
    ///     In such cases, the floating-point value provides an approximate representation of the number.
    /// </remarks>
    /// <example>
    ///     <code>
    /// QuantityValue qv = QuantityValue.FromDouble(0.1);
    /// // Output: 3602879701896397/36028797018963968, which is approximately 0.10000000000000000555111512312578
    /// </code>
    /// </example>
    public static QuantityValue FromExactDouble(double value)
    {
        return new QuantityValue(Fraction.FromDouble(value, false));
    }

    #if NET7_0_OR_GREATER
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<QuantityValue>.TryConvertFromChecked<TOther>(TOther value, out QuantityValue result)
    {
        return TryConvertFrom(value, out result);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<QuantityValue>.TryConvertFromSaturating<TOther>(TOther value, out QuantityValue result)
    {
        return TryConvertFrom(value, out result);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<QuantityValue>.TryConvertFromTruncating<TOther>(TOther value, out QuantityValue result)
    {
        return TryConvertFrom(value, out result);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool TryConvertFrom<TOther>(TOther value, out QuantityValue result) where TOther : INumberBase<TOther>
    {
        if (typeof(TOther) == typeof(Fraction))
        {
            var num = (Fraction)(object)value;
            result = new QuantityValue(num.Numerator, num.Denominator);
            return true;
        }

        if (typeof(TOther) == typeof(decimal))
        {
            var num = (decimal)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(double))
        {
            var num = (double)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(float))
        {
            var actualValue = (float)(object)value;
            result = actualValue;
            return true;
        }

        if (typeof(TOther) == typeof(Half))
        {
            var actualValue = (Half)(object)value;
            result = (float)actualValue;
            return true;
        }

        if (typeof(TOther) == typeof(BigInteger))
        {
            var num = (BigInteger)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(Int128))
        {
            var num = (Int128)(object)value;
            result = (BigInteger)num;
            return true;
        }

        if (typeof(TOther) == typeof(UInt128))
        {
            var num = (UInt128)(object)value;
            result = (BigInteger)num;
            return true;
        }

        if (typeof(TOther) == typeof(long))
        {
            var num = (long)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(ulong))
        {
            var num = (ulong)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(int))
        {
            long num = (int)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(uint))
        {
            var num = (uint)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(nint))
        {
            var num = (nint)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(UIntPtr))
        {
            var num = (UIntPtr)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(short))
        {
            var num = (short)(object)value;
            result = (BigInteger)num;
            return true;
        }

        if (typeof(TOther) == typeof(ushort))
        {
            var num = (ushort)(object)value;
            result = (decimal)num;
            return true;
        }

        if (typeof(TOther) == typeof(char))
        {
            var ch = (char)(object)value;
            result = (decimal)ch;
            return true;
        }

        if (typeof(TOther) == typeof(byte))
        {
            var num = (byte)(object)value;
            result = num;
            return true;
        }

        if (typeof(TOther) == typeof(sbyte))
        {
            var num = (sbyte)(object)value;
            result = num;
            return true;
        }

        result = default;
        return false;
    }
    
    #endif
}
