// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using Fractions;

namespace UnitsNet;

/// <summary>
///     A type that supports implicit cast from all .NET numeric types, in order to avoid a large number of overloads
///     and binary size for all From(value, unit) factory methods, for each of the 700+ units in the library.
///     <see cref="QuantityValue" /> stores the value internally using a fraction represented by two
///     <see cref="BigInteger" />, allowing it to represent arbitrary values without loss of precision.
/// </summary>
/// <remarks>
///     <para>
///         At the time of this writing, this reduces the number of From(value, unit) overloads to 1/4th:
///         From 8 (int, long, double, decimal + each nullable) down to 2 (QuantityValue and QuantityValue?).
///         This also adds more numeric types with no extra overhead, such as float, short and byte.
///     </para>
/// </remarks>
// [DataContract]
[TypeConverter(typeof(QuantityValueTypeConverter))]
// [DebuggerDisplay("_fraction")]
[DebuggerTypeProxy(typeof(QuantityValueDebugView))]
public readonly partial struct QuantityValue :
#if NET7_0_OR_GREATER
    INumber<QuantityValue>, IConvertible
#else
    IFormattable, IConvertible, IEquatable<QuantityValue>, IComparable<QuantityValue>, IComparable
#endif
{
    /// <summary>
    ///     Gets the QuantityValue representing the value zero.
    /// </summary>
    public static QuantityValue Zero { get; } = new(0);

    /// <summary>
    ///     Gets the QuantityValue representing the number one.
    /// </summary>
    public static QuantityValue One { get; } = new(1);

    /// <summary>
    ///     A fraction representing the positive infinity.
    /// </summary>
    public static QuantityValue PositiveInfinity { get; } = new(Fraction.PositiveInfinity);

    /// <summary>
    ///     A fraction representing the negative infinity.
    /// </summary>
    public static QuantityValue NegativeInfinity { get; } = new(Fraction.NegativeInfinity);

    /// <summary>
    ///     A fraction representing the result of dividing zero by zero.
    /// </summary>
    public static QuantityValue NaN { get; } = new(Fraction.NaN);


    private readonly Fraction _fraction;

    private QuantityValue(Fraction value)
    {
        _fraction = value;
    }

    /// <summary>
    ///     Construct using a value <paramref name="numerator" /> and <paramref name="denominator" />.
    /// </summary>
    /// <param name="numerator">Numerator</param>
    /// <param name="denominator">Denominator</param>
    public QuantityValue(BigInteger numerator, BigInteger denominator)
    {
        _fraction = new Fraction(numerator, denominator, false);
        // _fraction = Fraction.GetReducedFraction(numerator, denominator);
    }

    /// <summary>
    ///     Construct using a value <paramref name="numerator" /> and <paramref name="denominator" />.
    /// </summary>
    /// <param name="numerator">Numerator</param>
    /// <param name="denominator">Denominator</param>
    /// <param name="normalize">If <c>true</c> the fraction will be created as reduced/simplified fraction. </param>
    /// <remarks>
    ///     Normalizing the fraction can reduce the size of the terms but is a relatively expensive operation and should
    ///     be used only when the number is expected to be re-used (e.g. when part of hash-code lookup) .
    /// </remarks>
    internal QuantityValue(BigInteger numerator, BigInteger denominator, bool normalize)
    {
        _fraction = new Fraction(numerator, denominator, normalize);
    }

    /// <summary>
    ///     Deconstructs the QuantityValue object into its numerator and denominator components.
    /// </summary>
    /// <param name="numerator">Output parameter for the numerator component.</param>
    /// <param name="denominator">Output parameter for the denominator component.</param>
    public readonly void Deconstruct(out BigInteger numerator, out BigInteger denominator)
    {
        numerator = _fraction.Numerator;
        denominator = _fraction.Denominator;
    }

    #region INumber definitions

#if NET7_0_OR_GREATER
    static int INumberBase<QuantityValue>.Radix => 10;
    static QuantityValue IAdditiveIdentity<QuantityValue, QuantityValue>.AdditiveIdentity => Zero;
    static QuantityValue IMultiplicativeIdentity<QuantityValue, QuantityValue>.MultiplicativeIdentity => One;

    static bool INumberBase<QuantityValue>.IsNormal(QuantityValue value)
    {
        return IsFinite(value);
    }

    static bool INumberBase<QuantityValue>.IsRealNumber(QuantityValue value)
    {
        return true;
    }

    static bool INumberBase<QuantityValue>.IsComplexNumber(QuantityValue value)
    {
        return false;
    }

    static bool INumberBase<QuantityValue>.IsImaginaryNumber(QuantityValue value)
    {
        return false;
    }

    static bool INumberBase<QuantityValue>.IsSubnormal(QuantityValue value)
    {
        return false;
    }
#endif

    /// <summary>
    ///     Determines whether the given QuantityValue is in canonical form.
    /// </summary>
    /// <param name="value">The QuantityValue to check.</param>
    /// <returns>True if the QuantityValue is in canonical form, otherwise false.</returns>
    /// <remarks>
    ///     A QuantityValue is considered to be in canonical form if its denominator is one,
    ///     or if its numerator and denominator are coprime numbers (their greatest common divisor is one).
    /// </remarks>
    public static bool IsCanonical(QuantityValue value)
    {
        (BigInteger numerator, BigInteger denominator) = value;
        if (denominator.IsOne)
        {
            return true;
        }

        if (numerator.IsZero)
        {
            return denominator.IsZero; // if we want to consider NaN as "canonical"
        }

        if (denominator.IsZero)
        {
            return numerator.IsOne || numerator == BigInteger.MinusOne;
        }

        return BigInteger.GreatestCommonDivisor(numerator, denominator).IsOne;
    }

    /// <summary>Determines if a value represents an even integral number.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is an even integer; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsEvenInteger(QuantityValue value)
    {
        Fraction fraction = value._fraction.Reduce();
        return fraction.Denominator.IsOne && fraction.Numerator.IsEven;
    }

    /// <summary>Determines if a value is finite.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is finite; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsFinite(QuantityValue value)
    {
        return !value._fraction.Denominator.IsZero;
    }

    /// <summary>Determines if a value is infinite.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is infinite; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsInfinity(QuantityValue value)
    {
        return value._fraction.IsInfinity;
    }

    /// <summary>Determines if a value represents an integral number.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is an integer; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsInteger(QuantityValue value)
    {
        var denominator = BigInteger.Abs(value._fraction.Denominator);
        if (denominator.IsOne)
        {
            return true;
        }

        if (denominator.IsZero)
        {
            return false;
        }

        var numerator = BigInteger.Abs(value._fraction.Numerator);
        if (numerator.IsZero)
        {
            return true;
        }

        return numerator >= denominator && (numerator % denominator).IsZero;
    }

    /// <summary>Determines if a value is NaN.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is NaN; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNaN(QuantityValue value)
    {
        return value._fraction.IsNaN;
    }

    /// <summary>Determines if a value represents a negative real number.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    public static bool IsNegative(QuantityValue value)
    {
        return value._fraction.IsNegative;
    }

    /// <summary>Determines if a value is negative infinity.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is negative infinity; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNegativeInfinity(QuantityValue value)
    {
        return value._fraction.IsNegativeInfinity;
    }

    /// <summary>Determines if a value represents an odd integral number.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is an odd integer; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsOddInteger(QuantityValue value)
    {
        Fraction fraction = value._fraction.Reduce();
        return fraction.Denominator.IsOne && !fraction.Numerator.IsEven;
    }

    /// <summary>Determines if a value represents zero or a positive real number.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number;
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsPositive(QuantityValue value)
    {
        return value._fraction.IsPositive;
    }

    /// <summary>Determines if a value is positive infinity.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is positive infinity; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsPositiveInfinity(QuantityValue value)
    {
        return value._fraction.IsPositiveInfinity;
    }

    /// <summary>Determines if a value is zero.</summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsZero(QuantityValue value)
    {
        return value._fraction.IsZero;
    }

    #endregion

    #region Math Operators

    /// <summary>
    ///     Adds two QuantityValue instances.
    /// </summary>
    /// <param name="a">The first QuantityValue.</param>
    /// <param name="b">The second QuantityValue.</param>
    /// <returns>The sum of the two QuantityValue instances.</returns>
    public static QuantityValue operator +(QuantityValue a, QuantityValue b)
    {
        return new QuantityValue(a._fraction.Add(b._fraction));
    }

    /// <summary>
    ///     Increments the QuantityValue by one.
    /// </summary>
    /// <param name="value">The QuantityValue to be incremented.</param>
    /// <returns>A new QuantityValue that represents the original value incremented by one.</returns>
    public static QuantityValue operator ++(QuantityValue value)
    {
        return value + One;
    }

    /// <summary>
    ///     Subtracts one QuantityValue from another.
    /// </summary>
    /// <param name="a">The QuantityValue to subtract from.</param>
    /// <param name="b">The QuantityValue to subtract.</param>
    /// <returns>The difference between the two QuantityValue instances.</returns>
    public static QuantityValue operator -(QuantityValue a, QuantityValue b)
    {
        return new QuantityValue(a._fraction.Subtract(b._fraction));
    }

    /// <summary>
    ///     Returns the same value for the given QuantityValue. This unary plus operator doesn't change the value.
    /// </summary>
    /// <param name="value">The QuantityValue to return.</param>
    /// <returns>The same QuantityValue that was passed in.</returns>
    public static QuantityValue operator +(QuantityValue value)
    {
        return value;
    }

    /// <summary>
    ///     Returns the negated value of the operand
    /// </summary>
    /// <param name="v">Value to negate</param>
    /// <returns>-v</returns>
    public static QuantityValue operator -(QuantityValue v)
    {
        return new QuantityValue(v._fraction.Negate());
    }

    /// <summary>
    ///     Decrements the value of the specified QuantityValue by one.
    /// </summary>
    /// <param name="value">The QuantityValue to decrement.</param>
    /// <returns>A new QuantityValue that is the value of the input QuantityValue minus one.</returns>
    public static QuantityValue operator --(QuantityValue value)
    {
        return value - One;
    }

    /// <summary>
    ///     Multiplies two QuantityValue instances.
    /// </summary>
    /// <param name="a">The first QuantityValue.</param>
    /// <param name="b">The second QuantityValue.</param>
    /// <returns>The product of the two QuantityValue instances.</returns>
    public static QuantityValue operator *(QuantityValue a, QuantityValue b)
    {
        return new QuantityValue(a._fraction.Multiply(b._fraction));
    }

    /// <summary>
    ///     Divides one QuantityValue by another.
    /// </summary>
    /// <param name="a">The QuantityValue to divide.</param>
    /// <param name="b">The QuantityValue to divide by.</param>
    /// <returns>The quotient of the two QuantityValue instances.</returns>
    public static QuantityValue operator /(QuantityValue a, QuantityValue b)
    {
        return new QuantityValue(a._fraction.Divide(b._fraction));
    }

    /// <summary>
    ///     Returns the remainder of dividing one QuantityValue by another.
    /// </summary>
    /// <param name="a">The QuantityValue to divide.</param>
    /// <param name="b">The QuantityValue to divide by.</param>
    /// <returns>The remainder of the division of the two QuantityValue instances.</returns>
    public static QuantityValue operator %(QuantityValue a, QuantityValue b)
    {
        return new QuantityValue(a._fraction.Remainder(b._fraction));
    }

    /// <summary>
    ///     Raises a QuantityValue to the specified power.
    /// </summary>
    /// <param name="a">The QuantityValue to raise to the power.</param>
    /// <param name="power">The power to raise the QuantityValue to.</param>
    /// <returns>The QuantityValue raised to the specified power.</returns>
    public static QuantityValue operator
        ^(QuantityValue a, int power) // TODO this operator will be removed (it's only here for tracking the irrational operators)
    {
        return new QuantityValue(Fraction.Pow(a._fraction, power));
    }

    /// <summary>
    ///     Raises a QuantityValue to the specified power.
    /// </summary>
    /// <param name="a">The QuantityValue to raise to the power.</param>
    /// <param name="power">The power to raise the QuantityValue to.</param>
    /// <returns>The QuantityValue raised to the specified power.</returns>
    public static QuantityValue Pow(QuantityValue a, int power)
    {
        return new QuantityValue(Fraction.Pow(a._fraction, power));
    }

    /// <summary>
    ///     Calculates the square root of a given QuantityValue.
    /// </summary>
    /// <param name="a">The QuantityValue for which to calculate the square root.</param>
    /// <param name="accuracy">The number of decimal places of accuracy for the square root calculation. Default is 30.</param>
    /// <returns>A new QuantityValue that is the square root of the input QuantityValue.</returns>
    /// <exception cref="OverflowException">Thrown when the input QuantityValue is negative.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the accuracy is less than or equal to zero.</exception>
    /// <remarks>
    ///     Uses Babylonian Method of computing square roots: increasing the accuracy would result in longer calculation
    ///     times.
    /// </remarks>
    public static QuantityValue Sqrt(QuantityValue a, int accuracy = 30)
    {
        // return new QuantityValue(a._fraction.Sqrt(accuracy)); // TODO revert to this once https://github.com/danm-de/Fractions/pull/81 is merged (and remove the constants)
        Fraction x = a._fraction;
        if (accuracy <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(accuracy),
                accuracy,
                "The accuracy must be positive");
        }

        if (x.IsNaN || x.IsNegative)
        {
            return NaN;
        }

        if (x.Numerator.IsZero || x.Denominator.IsZero) // (x.IsZero || x.IsInfinity)
        {
            return a;
        }

        var tolerance = new Fraction(BigInteger.One, BigInteger.Pow(Ten, accuracy));

        //Using Math.Sqrt to get a good starting guess
        var guessDouble = Math.Sqrt(a.ToDouble());
        Fraction oldGuess = double.IsInfinity(guessDouble)
            ? x / Fraction.Two
            : Fraction.FromDouble(guessDouble, false);

        Fraction newGuess;
        do
        {
            //Babylonian Method
            newGuess = (oldGuess + x / oldGuess) / Fraction.Two;
            oldGuess = newGuess;
        } while ((oldGuess - newGuess).Abs() > tolerance);

        return Round(new QuantityValue(newGuess), accuracy);
    }

    /// <summary>
    ///     Returns the absolute value of a specified <see cref="QuantityValue" />.
    /// </summary>
    /// <param name="value">A <see cref="QuantityValue" />.</param>
    /// <returns>The absolute value of <paramref name="value" />.</returns>
    public static QuantityValue Abs(QuantityValue value)
    {
        return new QuantityValue(Fraction.Abs(value._fraction));
    }

    /// <summary>
    ///     Calculates and returns the reciprocal of the specified <see cref="QuantityValue" />.
    /// </summary>
    /// <param name="value">A <see cref="QuantityValue" /> whose reciprocal is to be calculated.</param>
    /// <returns>A new <see cref="QuantityValue" /> that is the reciprocal of the input value.</returns>
    /// <remarks>
    ///     In mathematics, a multiplicative inverse or reciprocal for a number x, denoted by 1/x or x^-1, is a
    ///     number
    ///     which when multiplied by x yields the multiplicative identity, 1. The multiplicative inverse of a fraction a/b is
    ///     b/a. For the multiplicative inverse of a real number, divide 1 by the number. For example, the reciprocal of 5 is
    ///     one fifth (1/5 or 0.2), and the reciprocal of 0.25 is 1 divided by 0.25, or 4.
    /// </remarks>
    public static QuantityValue Inverse(QuantityValue value)
    {
        return new QuantityValue(value._fraction.Reciprocal());
    }

    /// <summary>
    ///     Rounds the given QuantityValue to the specified number of digits.
    /// </summary>
    /// <param name="x">The QuantityValue to be rounded.</param>
    /// <param name="nbDigits">The number of decimal places in the return value.</param>
    /// <returns>A new QuantityValue that is the nearest number with the specified number of digits.</returns>
    public static QuantityValue Round(QuantityValue x, int nbDigits)
    {
        return Round(x, nbDigits, MidpointRounding.ToEven);
    }

    /// <summary>
    ///     Rounds the given Fraction to the specified precision using the specified rounding strategy.
    /// </summary>
    /// <param name="x">The QuantityValue to be rounded.</param>
    /// <param name="decimals">The number of significant decimal places (precision) in the return value.</param>
    /// <param name="mode">Specifies the strategy that mathematical rounding methods should use to round a number.</param>
    /// <returns>
    ///     The number that <paramref name="x" /> is rounded to using the <paramref name="mode" /> rounding strategy and
    ///     with a precision of <paramref name="decimals" />. If the precision of <paramref name="x" /> is less than
    ///     <paramref name="decimals" />, <paramref name="x" /> is returned unchanged.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">If <paramref name="decimals" /> is less than 0</exception>
    public static QuantityValue Round(QuantityValue x, int decimals, MidpointRounding mode)
    {
        // TODO this can be delegated to the Fraction class once https://github.com/danm-de/Fractions/pull/81 is merged (and remove the constants)
#if NET
        ArgumentOutOfRangeException.ThrowIfNegative(decimals);
#else
        if (decimals < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(decimals));
        }
#endif

        (BigInteger numerator, BigInteger denominator) = x;
        if (numerator.IsZero)
        {
            return x;
        }

        if (denominator.IsOne || denominator.IsZero)
        {
            return x;
        }

        var factor = BigInteger.Pow(Ten, decimals);
        BigInteger roundedNumerator = Fraction.RoundToBigInteger(x._fraction * factor, mode);
        return new QuantityValue(roundedNumerator, factor);
    }

    #endregion
}
