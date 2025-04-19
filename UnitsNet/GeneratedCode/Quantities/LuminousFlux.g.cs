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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using UnitsNet.Units;
#if NET
using System.Numerics;
#endif

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In photometry, luminous flux or luminous power is the measure of the perceived power of light.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminous_flux
    /// </remarks>
    [DataContract]
    [DebuggerTypeProxy(typeof(QuantityDisplay))]
    public readonly partial struct LuminousFlux :
        IArithmeticQuantity<LuminousFlux, LuminousFluxUnit>,
#if NET7_0_OR_GREATER
        IDivisionOperators<LuminousFlux, Illuminance, Area>,
        IDivisionOperators<LuminousFlux, Area, Illuminance>,
#endif
#if NET7_0_OR_GREATER
        IComparisonOperators<LuminousFlux, LuminousFlux, bool>,
        IParsable<LuminousFlux>,
#endif
        IComparable,
        IComparable<LuminousFlux>,
        IEquatable<LuminousFlux>,
        IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Value", Order = 1)]
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 2)]
        private readonly LuminousFluxUnit? _unit;

        static LuminousFlux()
        {
            BaseDimensions = new BaseDimensions(0, 0, 0, 0, 0, 0, 1);
            BaseUnit = LuminousFluxUnit.Lumen;
            Units = Enum.GetValues(typeof(LuminousFluxUnit)).Cast<LuminousFluxUnit>().ToArray();
            Zero = new LuminousFlux(0, BaseUnit);
            Info = new QuantityInfo<LuminousFluxUnit>("LuminousFlux",
                new UnitInfo<LuminousFluxUnit>[]
                {
                    new UnitInfo<LuminousFluxUnit>(LuminousFluxUnit.Lumen, "Lumens", new BaseUnits(luminousIntensity: LuminousIntensityUnit.Candela), "LuminousFlux"),
                },
                BaseUnit, Zero, BaseDimensions);

            DefaultConversionFunctions = new UnitConverter();
            RegisterDefaultConversions(DefaultConversionFunctions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public LuminousFlux(double value, LuminousFluxUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        /// Creates an instance of the quantity with the given numeric value in units compatible with the given <see cref="UnitSystem"/>.
        /// If multiple compatible units were found, the first match is used.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unitSystem">The unit system to create the quantity with.</param>
        /// <exception cref="ArgumentNullException">The given <see cref="UnitSystem"/> is null.</exception>
        /// <exception cref="ArgumentException">No unit was found for the given <see cref="UnitSystem"/>.</exception>
        public LuminousFlux(double value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="LuminousFlux" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<LuminousFluxUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of LuminousFlux, which is Lumen. All conversions go via this value.
        /// </summary>
        public static LuminousFluxUnit BaseUnit { get; }

        /// <summary>
        ///     All units of measurement for the LuminousFlux quantity.
        /// </summary>
        public static LuminousFluxUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Lumen.
        /// </summary>
        public static LuminousFlux Zero { get; }

        /// <inheritdoc cref="Zero"/>
        public static LuminousFlux AdditiveIdentity => Zero;

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        double IQuantity.Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public LuminousFluxUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<LuminousFluxUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => LuminousFlux.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminousFluxUnit.Lumen"/>
        /// </summary>
        public double Lumens => As(LuminousFluxUnit.Lumen);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: LuminousFluxUnit -> BaseUnit

            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<LuminousFlux>(LuminousFluxUnit.Lumen, LuminousFluxUnit.Lumen, quantity => quantity);

            // Register in unit converter: BaseUnit -> LuminousFluxUnit
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(LuminousFluxUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(LuminousFluxUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="LuminousFlux"/> from <see cref="LuminousFluxUnit.Lumen"/>.
        /// </summary>
        public static LuminousFlux FromLumens(double value)
        {
            return new LuminousFlux(value, LuminousFluxUnit.Lumen);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminousFluxUnit" /> to <see cref="LuminousFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LuminousFlux unit value.</returns>
        public static LuminousFlux From(double value, LuminousFluxUnit fromUnit)
        {
            return new LuminousFlux(value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static LuminousFlux Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static LuminousFlux Parse(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.QuantityParser.Parse<LuminousFlux, LuminousFluxUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out LuminousFlux result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out LuminousFlux result)
        {
            return UnitsNetSetup.Default.QuantityParser.TryParse<LuminousFlux, LuminousFluxUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static LuminousFluxUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static LuminousFluxUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.LuminousFluxUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out LuminousFluxUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out LuminousFluxUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static LuminousFlux operator -(LuminousFlux right)
        {
            return new LuminousFlux(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from adding two <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator +(LuminousFlux left, LuminousFlux right)
        {
            return new LuminousFlux(left.Value + right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from subtracting two <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator -(LuminousFlux left, LuminousFlux right)
        {
            return new LuminousFlux(left.Value - right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from multiplying value and <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator *(double left, LuminousFlux right)
        {
            return new LuminousFlux(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from multiplying value and <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator *(LuminousFlux left, double right)
        {
            return new LuminousFlux(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from dividing <see cref="LuminousFlux"/> by value.</summary>
        public static LuminousFlux operator /(LuminousFlux left, double right)
        {
            return new LuminousFlux(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="LuminousFlux"/> by <see cref="LuminousFlux"/>.</summary>
        public static double operator /(LuminousFlux left, LuminousFlux right)
        {
            return left.Lumens / right.Lumens;
        }

        #endregion

        #region Relational Operators

        /// <summary>Get <see cref="Area"/> from <see cref="LuminousFlux"/> / <see cref="Illuminance"/>.</summary>
        public static Area operator /(LuminousFlux luminousFlux, Illuminance illuminance)
        {
            return Area.FromSquareMeters(luminousFlux.Lumens / illuminance.Lux);
        }

        /// <summary>Get <see cref="Illuminance"/> from <see cref="LuminousFlux"/> / <see cref="Area"/>.</summary>
        public static Illuminance operator /(LuminousFlux luminousFlux, Area area)
        {
            return Illuminance.FromLux(luminousFlux.Lumens / area.SquareMeters);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(LuminousFlux left, LuminousFlux right)
        {
            return left.Value <= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(LuminousFlux left, LuminousFlux right)
        {
            return left.Value >= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(LuminousFlux left, LuminousFlux right)
        {
            return left.Value < right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(LuminousFlux left, LuminousFlux right)
        {
            return left.Value > right.ToUnit(left.Unit).Value;
        }

        // We use obsolete attribute to communicate the preferred equality members to use.
        // CS0809: Obsolete member 'memberA' overrides non-obsolete member 'memberB'.
        #pragma warning disable CS0809

        /// <summary>Indicates strict equality of two <see cref="LuminousFlux"/> quantities, where both <see cref="Value" /> and <see cref="Unit" /> are exactly equal.</summary>
        [Obsolete("For null checks, use `x is null` syntax to not invoke overloads. For equality checks, use Equals(LuminousFlux other, LuminousFlux tolerance) instead, to check equality across units and to specify the max tolerance for rounding errors due to floating-point arithmetic when converting between units.")]
        public static bool operator ==(LuminousFlux left, LuminousFlux right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="LuminousFlux"/> quantities, where both <see cref="Value" /> and <see cref="Unit" /> are exactly equal.</summary>
        [Obsolete("For null checks, use `x is null` syntax to not invoke overloads. For equality checks, use Equals(LuminousFlux other, LuminousFlux tolerance) instead, to check equality across units and to specify the max tolerance for rounding errors due to floating-point arithmetic when converting between units.")]
        public static bool operator !=(LuminousFlux left, LuminousFlux right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LuminousFlux"/> quantities, where both <see cref="Value" /> and <see cref="Unit" /> are exactly equal.</summary>
        [Obsolete("Use Equals(LuminousFlux other, LuminousFlux tolerance) instead, to check equality across units and to specify the max tolerance for rounding errors due to floating-point arithmetic when converting between units.")]
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is LuminousFlux otherQuantity))
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LuminousFlux"/> quantities, where both <see cref="Value" /> and <see cref="Unit" /> are exactly equal.</summary>
        [Obsolete("Use Equals(LuminousFlux other, LuminousFlux tolerance) instead, to check equality across units and to specify the max tolerance for rounding errors due to floating-point arithmetic when converting between units.")]
        public bool Equals(LuminousFlux other)
        {
            return new { Value, Unit }.Equals(new { other.Value, other.Unit });
        }

        #pragma warning restore CS0809

        /// <summary>Compares the current <see cref="LuminousFlux"/> with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="obj" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="obj" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="obj" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(object? obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is LuminousFlux otherQuantity)) throw new ArgumentException("Expected type LuminousFlux.", nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>Compares the current <see cref="LuminousFlux"/> with another <see cref="LuminousFlux"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="other">A quantity to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(LuminousFlux other)
        {
            return _value.CompareTo(other.ToUnit(this.Unit).Value);
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another LuminousFlux within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating-point operations and using double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        [Obsolete("Use Equals(LuminousFlux other, LuminousFlux tolerance) instead, to check equality across units and to specify the max tolerance for rounding errors due to floating-point arithmetic when converting between units.")]
        public bool Equals(LuminousFlux other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException(nameof(tolerance), "Tolerance must be greater than or equal to 0.");

            return UnitsNet.Comparison.Equals(
                referenceValue: this.Value,
                otherValue: other.As(this.Unit),
                tolerance: tolerance,
                comparisonType: comparisonType);
        }

        /// <inheritdoc />
        public bool Equals(IQuantity? other, IQuantity tolerance)
        {
            return other is LuminousFlux otherTyped
                   && (tolerance is LuminousFlux toleranceTyped
                       ? true
                       : throw new ArgumentException($"Tolerance quantity ({tolerance.QuantityInfo.Name}) did not match the other quantities of type 'LuminousFlux'.", nameof(tolerance)))
                   && Equals(otherTyped, toleranceTyped);
        }

        /// <inheritdoc />
        public bool Equals(LuminousFlux other, LuminousFlux tolerance)
        {
            return UnitsNet.Comparison.Equals(
                referenceValue: this.Value,
                otherValue: other.As(this.Unit),
                tolerance: tolerance.As(this.Unit),
                comparisonType: ComparisonType.Absolute);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current LuminousFlux.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(LuminousFluxUnit unit)
        {
            if (Unit == unit)
                return Value;

            return ToUnit(unit).Value;
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public double As(UnitSystem unitSystem)
        {
            return As(Info.GetDefaultUnit(unitSystem));
        }

        /// <summary>
        ///     Converts this LuminousFlux to another LuminousFlux with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A LuminousFlux with the specified unit.</returns>
        public LuminousFlux ToUnit(LuminousFluxUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this <see cref="LuminousFlux"/> to another <see cref="LuminousFlux"/> using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A LuminousFlux with the specified unit.</returns>
        public LuminousFlux ToUnit(LuminousFluxUnit unit, UnitConverter unitConverter)
        {
            if (TryToUnit(unit, out var converted))
            {
                // Try to convert using the auto-generated conversion methods.
                return converted!.Value;
            }
            else if (unitConverter.TryGetConversionFunction((typeof(LuminousFlux), Unit, typeof(LuminousFlux), unit), out var conversionFunction))
            {
                // See if the unit converter has an extensibility conversion registered.
                return (LuminousFlux)conversionFunction(this);
            }
            else if (Unit != BaseUnit)
            {
                // Conversion to requested unit NOT found. Try to convert to BaseUnit, and then from BaseUnit to requested unit.
                var inBaseUnits = ToUnit(BaseUnit);
                return inBaseUnits.ToUnit(unit);
            }
            else
            {
                // No possible conversion
                throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        /// <summary>
        ///     Attempts to convert this <see cref="LuminousFlux"/> to another <see cref="LuminousFlux"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="converted">The converted <see cref="LuminousFlux"/> in <paramref name="unit"/>, if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        private bool TryToUnit(LuminousFluxUnit unit, [NotNullWhen(true)] out LuminousFlux? converted)
        {
            if (Unit == unit)
            {
                converted = this;
                return true;
            }

            LuminousFlux? convertedOrNull = (Unit, unit) switch
            {
                // LuminousFluxUnit -> BaseUnit

                // BaseUnit -> LuminousFluxUnit

                _ => null
            };

            if (convertedOrNull is null)
            {
                converted = default;
                return false;
            }

            converted = convertedOrNull.Value;
            return true;
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public LuminousFlux ToUnit(UnitSystem unitSystem)
        {
            return ToUnit(Info.GetDefaultUnit(unitSystem));
        }

        #region Explicit implementations

        double IQuantity.As(Enum unit)
        {
            if (unit is not LuminousFluxUnit typedUnit)
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(LuminousFluxUnit)} is supported.", nameof(unit));

            return As(typedUnit);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if (!(unit is LuminousFluxUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(LuminousFluxUnit)} is supported.", nameof(unit));

            return ToUnit(typedUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<LuminousFluxUnit> IQuantity<LuminousFluxUnit>.ToUnit(LuminousFluxUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<LuminousFluxUnit> IQuantity<LuminousFluxUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        #endregion

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null, null);
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString(null, provider);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format)
        {
            return ToString(format, null);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentCulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<LuminousFluxUnit>(this, format, provider);
        }

        #endregion

    }
}
