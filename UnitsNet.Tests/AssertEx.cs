using System;
using Xunit;

namespace UnitsNet.Tests
{
    /// <summary>
    ///     Additional assert methods to XUnit's <see cref="Xunit.Assert" />.
    /// </summary>
    public static class AssertEx
    {
        public static void EqualTolerance(QuantityValue expected, QuantityValue actual, QuantityValue tolerance, ComparisonType comparisonType = ComparisonType.Relative)
        {
            if (comparisonType == ComparisonType.Relative)
            {
                var areEqual = Comparison.EqualsRelative(expected, actual, tolerance);
                
                var difference = QuantityValue.Abs(expected - actual).ToDouble();
                var relativeDifference = difference / expected.ToDouble();

                Assert.True( areEqual, $"Values are not equal within relative tolerance: {tolerance.ToDouble():P4}\nExpected: {expected}\nActual: {actual}\nDiff: {relativeDifference:P4}" );
            }
            else if (comparisonType == ComparisonType.Absolute)
            {
                var areEqual = Comparison.EqualsAbsolute(expected, actual, tolerance);
                Assert.True( areEqual, $"Values are not equal within absolute tolerance: {tolerance}\nExpected: {expected}\nActual: {actual}\nDiff: {actual - expected:e}" );
            }
        }
    }
}
