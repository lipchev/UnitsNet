// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace UnitsNet;

public partial struct QuantityValue
{
    /// <summary>
    ///     Greater-than operator
    /// </summary>
    public static bool operator >(QuantityValue a, QuantityValue b)
    {
        return a.CompareTo(b) > 0;
    }

    /// <summary>
    ///     Less-than operator
    /// </summary>
    public static bool operator <(QuantityValue a, QuantityValue b)
    {
        return a.CompareTo(b) < 0;
    }

    /// <summary>
    ///     Greater-than-or-equal operator
    /// </summary>
    public static bool operator >=(QuantityValue a, QuantityValue b)
    {
        return a.CompareTo(b) >= 0;
    }

    /// <summary>
    ///     Less-than-or-equal operator
    /// </summary>
    public static bool operator <=(QuantityValue a, QuantityValue b)
    {
        return a.CompareTo(b) <= 0;
    }

    /// <summary>
    ///     Compares this QuantityValue instance to another QuantityValue instance.
    /// </summary>
    /// <param name="other">The QuantityValue to compare with this instance.</param>
    /// <returns>
    ///     A value indicating the relative order of the QuantityValue instances being compared.
    ///     Less than zero: This instance is less than the other instance.
    ///     Zero: This instance is equal to the other instance.
    ///     Greater than zero: This instance is greater than the other instance.
    /// </returns>
    public readonly int CompareTo(QuantityValue other)
    {
        return _fraction.CompareTo(other._fraction);
    }

    /// <summary>
    ///     Compares this QuantityValue instance to another object.
    /// </summary>
    /// <param name="obj">The object to compare with this instance.</param>
    /// <returns>
    ///     A value indicating the relative order of the QuantityValue instances being compared.
    ///     Less than zero: This instance is less than the other instance.
    ///     Zero: This instance is equal to the other instance.
    ///     Greater than zero: This instance is greater than the other instance.
    /// </returns>
    public readonly int CompareTo(object? obj)
    {
        return obj switch
        {
            null => 1,
            QuantityValue other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(QuantityValue)}")
        };
    }

    /// <summary>
    ///     Returns the <see cref="QuantityValue" /> with the maximum magnitude from the two provided values.
    /// </summary>
    /// <param name="x">The first <see cref="QuantityValue" /> to compare.</param>
    /// <param name="y">The second <see cref="QuantityValue" /> to compare.</param>
    /// <returns>The <see cref="QuantityValue" /> with the maximum magnitude.</returns>
    public static QuantityValue MaxMagnitude(QuantityValue x, QuantityValue y)
    {
        return x._fraction.Abs() >= y._fraction.Abs() ? x : y;
    }

    /// <summary>
    ///     Compares two values to compute which has the greater magnitude and returning the other value if an input is
    ///     <c>NaN</c>.
    /// </summary>
    /// <param name="x">The value to compare with <paramref name="y" />.</param>
    /// <param name="y">The value to compare with <paramref name="x" />.</param>
    /// <returns>
    ///     <paramref name="x" /> if it is greater than <paramref name="y" />; otherwise, <paramref name="y" />.
    /// </returns>
    public static QuantityValue MaxMagnitudeNumber(QuantityValue x, QuantityValue y)
    {
        if (x._fraction.IsNaN)
        {
            return y;
        }

        if (y._fraction.IsNaN)
        {
            return x;
        }

        return x._fraction.Abs() >= y._fraction.Abs() ? x : y;
    }

    /// <summary>
    ///     Returns the QuantityValue with the smallest magnitude from the two provided QuantityValues.
    /// </summary>
    /// <param name="x">The first QuantityValue to compare.</param>
    /// <param name="y">The second QuantityValue to compare.</param>
    /// <returns>The QuantityValue with the smallest magnitude.</returns>
    public static QuantityValue MinMagnitude(QuantityValue x, QuantityValue y)
    {
        return x._fraction.Abs() <= y._fraction.Abs() ? x : y;
    }

    /// <summary>
    ///     Compares two values to compute which has the lesser magnitude and returning the other value if an input is
    ///     <c>NaN</c>.
    /// </summary>
    /// <param name="x">The value to compare with <paramref name="y" />.</param>
    /// <param name="y">The value to compare with <paramref name="x" />.</param>
    /// <returns>
    ///     <paramref name="x" /> if it is less than <paramref name="y" />; otherwise, <paramref name="y" />.
    /// </returns>
    public static QuantityValue MinMagnitudeNumber(QuantityValue x, QuantityValue y)
    {
        if (x._fraction.IsNaN)
        {
            return y;
        }

        if (y._fraction.IsNaN)
        {
            return x;
        }

        return x._fraction.Abs() <= y._fraction.Abs() ? x : y;
    }
}
