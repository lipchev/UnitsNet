﻿using System.Linq;
using System.Numerics;
using CodeGen.Helpers.ExpressionAnalyzer;
using CodeGen.Helpers.ExpressionAnalyzer.Expressions;
using CodeGen.JsonTypes;
using Fractions;

namespace CodeGen.Helpers;

internal static class ExpressionEvaluationHelpers
{
    private static (BigInteger reducedValue, int exponent) TrimTrailingZeroes(this BigInteger value)
    {
        var ten = new BigInteger(10);
        var exponent = 0;
        var nextValue = BigInteger.DivRem(value, ten, out BigInteger remainder);
        while (remainder.IsZero)
        {
            exponent ++;
            value = nextValue;
            nextValue = BigInteger.DivRem(nextValue, ten, out remainder);
        }

        return (value, exponent);
    }
    private static string GetConstantFormat(this Fraction coefficient)
    {
        if (coefficient == Fraction.One)
        {
            return "1";
        }

        return coefficient.Denominator.IsOne
            ? coefficient.Numerator.ToString()
            : $"new QuantityValue({coefficient.Numerator}, {coefficient.Denominator})";
    }

    private static string GetFractionalConstantFormat(this Fraction coefficient)
    {
        coefficient = coefficient.Reduce();
        // making sure that neither the Numerator nor the Denominator contain a value that cannot be represented as a compiler constant
        if (coefficient.Numerator >= long.MinValue && coefficient.Numerator <= long.MaxValue && coefficient.Denominator <= long.MaxValue)
        {
            return coefficient.GetConstantFormat();
        }

        // need to represent the fraction in terms of two terms: "a * b" (TODO see about creating a static readonly field in the unit class)
        if (coefficient.Denominator > long.MaxValue) // we are very close to zero
        {
            if (coefficient.Denominator.IsPowerOfTwo) // express as "2^n"
            {
                var exponent = coefficient.Denominator.GetBitLength() - 1;
                if (coefficient.Numerator.IsOne)
                {
                    return coefficient.IsPositive
                        ? $"1 / BigInteger.Pow(2, {exponent})"
                        : $"1 / -BigInteger.Pow(2, {exponent})";
                }

                return coefficient.IsPositive
                    ? $"{coefficient.Numerator} / BigInteger.Pow(2, {exponent})"
                    : $"{coefficient.Numerator} / -BigInteger.Pow(2, {exponent})";
            }
            else // express as "x * a / 10^n
            {
                (BigInteger reducedDenominator, var exponent) = coefficient.Denominator.TrimTrailingZeroes();
                var mantissa = new Fraction(coefficient.Numerator, reducedDenominator, false);
                return $"{mantissa.GetConstantFormat()} / BigInteger.Pow(10, {exponent})";
            }
        }
        else // we are very far from zero
        {
            if (coefficient.Numerator.IsPowerOfTwo) // express as "x * 2^n"
            {
                var exponent = coefficient.Numerator.GetBitLength() - 1;
                if (coefficient.Denominator.IsOne)
                {
                    return coefficient.IsPositive
                        ? $"BigInteger.Pow(2, {exponent})"
                        : $"-BigInteger.Pow(2, {exponent})";
                }

                return coefficient.IsPositive
                    ? $"BigInteger.Pow(2, {exponent}) / {coefficient.Denominator}"
                    : $"-BigInteger.Pow(2, {exponent}) / {coefficient.Denominator}";
            }
            else // express as "x * a * 10^n
            {
                (BigInteger reducedNumerator, var exponent) = coefficient.Numerator.TrimTrailingZeroes();
                var mantissa = new Fraction(reducedNumerator, coefficient.Denominator, false);
                return $"{mantissa.GetConstantFormat()} * BigInteger.Pow(10, {exponent})";
            }
        }
    }

    private static string GetConstantExpression(this Fraction coefficient, string csharpParameter)
    {
        if (coefficient == Fraction.One)
        {
            return csharpParameter;
        }

        if (coefficient.Denominator.IsOne)
        {
            return $"{csharpParameter} * {coefficient.Numerator}";
        }

        if (coefficient.Numerator.IsOne)
        {
            return $"{csharpParameter} / {coefficient.Denominator}";
        }

        if (coefficient.Numerator == BigInteger.MinusOne)
        {
            return $"{csharpParameter} / -{coefficient.Denominator}";
        }

        return $"{csharpParameter} * new QuantityValue({coefficient.Numerator}, {coefficient.Denominator})";
    }

    private static string GetFractionalExpressionFormat(this Fraction coefficient, string csharpParameter)
    {
        coefficient = coefficient.Reduce();
        // making sure that neither the Numerator nor the Denominator contain a value that cannot be represented as a compiler constant
        if (coefficient.Numerator >= long.MinValue && coefficient.Numerator <= long.MaxValue && coefficient.Denominator <= long.MaxValue)
        {
            return coefficient.GetConstantExpression(csharpParameter);
        }

        // need to represent the fraction in terms of two terms: "x * a * b" (TODO see about creating a static readonly field in the unit class)
        if (coefficient.Denominator > long.MaxValue) // we are very close to zero
        {
            if (coefficient.Denominator.IsPowerOfTwo) // express as "x * 2^n"
            {
                var exponent = coefficient.Denominator.GetBitLength() - 1;
                if (coefficient.Numerator.IsOne)
                {
                    return coefficient.IsPositive
                        ? $"{csharpParameter} / BigInteger.Pow(2, {exponent})"
                        : $"{csharpParameter} / -BigInteger.Pow(2, {exponent})";
                }
                
                return coefficient.IsPositive
                    ? $"{csharpParameter} * {coefficient.Numerator} / BigInteger.Pow(2, {exponent})"
                    : $"{csharpParameter} * -{coefficient.Numerator} / BigInteger.Pow(2, {exponent})";
            }
            else // express as "x * a / 10^n
            {
                (BigInteger reducedDenominator, var exponent) = coefficient.Denominator.TrimTrailingZeroes();
                var mantissa = new Fraction(coefficient.Numerator, reducedDenominator, false);
                return $"{mantissa.GetConstantExpression(csharpParameter)} / BigInteger.Pow(10, {exponent})";
            }
        }
        else // we are very far from zero
        {
            if (coefficient.Numerator.IsPowerOfTwo) // express as "x * 2^n"
            {
                var exponent = coefficient.Numerator.GetBitLength() - 1;
                if (coefficient.Denominator.IsOne)
                {
                    return coefficient.IsPositive
                        ? $"{csharpParameter} * BigInteger.Pow(2, {exponent})"
                        : $"{csharpParameter} * -BigInteger.Pow(2, {exponent})";
                }

                return coefficient.IsPositive
                    ? $"{csharpParameter} * BigInteger.Pow(2, {exponent}) / {coefficient.Denominator}"
                    : $"{csharpParameter} * -BigInteger.Pow(2, {exponent}) / {coefficient.Denominator}";
            }
            else // express as "x * a * 10^n
            {
                (BigInteger reducedNumerator, var exponent) = coefficient.Numerator.TrimTrailingZeroes();
                var mantissa = new Fraction(reducedNumerator, coefficient.Denominator, false);
                return $"{mantissa.GetConstantExpression(csharpParameter)} * BigInteger.Pow(10, {exponent})";
            }
        }
    }


    public static string GetExpressionFormat(this CustomFunction customFunction, string csharpParameter)
    {
        // TODO see about redirecting these to a static method in the quantity's class which is responsible for handling the required operations (efficiently)
        var mainArgument = $"({customFunction.Terms.GetExpressionFormat(csharpParameter)}).ToDouble()";
        var functionArguments = string.Join(", ", customFunction.AdditionalParameters.Prepend(mainArgument));
        return $"QuantityValue.FromDoubleRounded(Math.{customFunction.Name}({functionArguments}))";
    }

    public static string GetExponentFormat(this Fraction exponent, string csharpParameter)
    {
        if (exponent.Numerator == exponent.Denominator)
        {
            return csharpParameter;
        }
        
        // alternatively this could be an operator: e.g. $"({csharpParameter} ^ {exponent.ToInt32()})"
        return exponent.Denominator.IsOne
            ? $"QuantityValue.Pow({csharpParameter}, {exponent.ToInt32()})"
            : $"QuantityValue.FromDoubleRounded(Math.Pow({csharpParameter}.ToDouble(), {exponent.ToDouble()}))";
    }

    public static string GetExpressionFormat(this ExpressionTerm term, string csharpParameter)
    {
        if (term.Exponent.IsZero)
        {
            return term.Coefficient.GetFractionalConstantFormat();
        }

        var expressionFormat = term.NestedFunction is null ? csharpParameter : term.NestedFunction.GetExpressionFormat(csharpParameter);
        return term.Coefficient.GetFractionalExpressionFormat(term.Exponent.GetExponentFormat(expressionFormat));
    }

    public static string GetExpressionFormat(this CompositeExpression expression, string csharpParameter)
    {
        return string.Join(" + ", expression.Terms.Select(x => x.GetExpressionFormat(csharpParameter)));
    }

    private static string GetStringExpression(string expression, string csharpParameter, string jsonParameter = "{x}")
    {
        CompositeExpression compositeExpression = ExpressionEvaluator.Evaluate(expression, jsonParameter);
        var expectedFormat = compositeExpression.GetExpressionFormat(csharpParameter);
        return expectedFormat;
    }

    /// <summary>
    ///     Gets the format of the conversion from the unit to the base unit.
    /// </summary>
    /// <param name="unit">The unit for which to get the conversion format.</param>
    /// <param name="csharpParameter">The C# parameter to be used in the conversion expression.</param>
    /// <returns>A string representing the format of the conversion from the unit to the base unit.</returns>
    internal static string GetUnitToBaseConversionFormat(this Unit unit, string csharpParameter)
    {
        return GetStringExpression(unit.FromUnitToBaseFunc, csharpParameter);
    }

    /// <summary>
    ///     Gets the format of the conversion from the base unit to the specified unit.
    /// </summary>
    /// <param name="unit">The unit to which the conversion format is to be obtained.</param>
    /// <param name="csharpParameter">The C# parameter to be used in the conversion expression.</param>
    /// <returns>A string representing the format of the conversion from the base unit to the specified unit.</returns>
    internal static string GetFromBaseToUnitConversionFormat(this Unit unit, string csharpParameter)
    {
        return GetStringExpression(unit.FromBaseToUnitFunc, csharpParameter);
    }
}
