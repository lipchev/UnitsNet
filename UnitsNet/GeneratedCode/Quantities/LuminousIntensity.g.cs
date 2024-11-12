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
using System.Numerics;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In photometry, luminous intensity is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminous_intensity
    /// </remarks>
    [DataContract]
    [DebuggerTypeProxy(typeof(QuantityDisplay))]
    public readonly partial struct LuminousIntensity :
        IArithmeticQuantity<LuminousIntensity, LuminousIntensityUnit>,
#if NET7_0_OR_GREATER
        IDivisionOperators<LuminousIntensity, Luminance, Area>,
        IDivisionOperators<LuminousIntensity, Area, Luminance>,
#endif
        IComparable,
        IComparable<LuminousIntensity>,
        IConvertible,
        IEquatable<LuminousIntensity>,
        IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Value", Order = 1, EmitDefaultValue = false)]
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 2, EmitDefaultValue = false)]
        private readonly LuminousIntensityUnit? _unit;

        static LuminousIntensity()
        {
            BaseDimensions = new BaseDimensions(0, 0, 0, 0, 0, 0, 1);
            BaseUnit = LuminousIntensityUnit.Candela;
            Units = Enum.GetValues(typeof(LuminousIntensityUnit)).Cast<LuminousIntensityUnit>().ToArray();
            Zero = new LuminousIntensity(0, BaseUnit);
            Info = new QuantityInfo<LuminousIntensityUnit>("LuminousIntensity",
                new UnitInfo<LuminousIntensityUnit>[]
                {
                    new UnitInfo<LuminousIntensityUnit>(LuminousIntensityUnit.Candela, "Candela", new BaseUnits(luminousIntensity: LuminousIntensityUnit.Candela), "LuminousIntensity"),
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
        public LuminousIntensity(QuantityValue value, LuminousIntensityUnit unit)
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
        public LuminousIntensity(QuantityValue value, UnitSystem unitSystem)
        {
            if (unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = value;
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="LuminousIntensity" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<LuminousIntensityUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of LuminousIntensity, which is Candela. All conversions go via this value.
        /// </summary>
        public static LuminousIntensityUnit BaseUnit { get; }

        /// <summary>
        ///     All units of measurement for the LuminousIntensity quantity.
        /// </summary>
        public static LuminousIntensityUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Candela.
        /// </summary>
        public static LuminousIntensity Zero { get; }

        /// <inheritdoc cref="Zero"/>
        public static LuminousIntensity AdditiveIdentity => Zero;

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        QuantityValue IQuantity.Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public LuminousIntensityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<LuminousIntensityUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => LuminousIntensity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminousIntensityUnit.Candela"/>
        /// </summary>
        public QuantityValue Candela => As(LuminousIntensityUnit.Candela);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: LuminousIntensityUnit -> BaseUnit

            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<LuminousIntensity>(LuminousIntensityUnit.Candela, LuminousIntensityUnit.Candela, quantity => quantity);

            // Register in unit converter: BaseUnit -> LuminousIntensityUnit
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(LuminousIntensityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(LuminousIntensityUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="LuminousIntensity"/> from <see cref="LuminousIntensityUnit.Candela"/>.
        /// </summary>
        public static LuminousIntensity FromCandela(QuantityValue value)
        {
            return new LuminousIntensity(value, LuminousIntensityUnit.Candela);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminousIntensityUnit" /> to <see cref="LuminousIntensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LuminousIntensity unit value.</returns>
        public static LuminousIntensity From(QuantityValue value, LuminousIntensityUnit fromUnit)
        {
            return new LuminousIntensity(value, fromUnit);
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
        public static LuminousIntensity Parse(string str)
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
        public static LuminousIntensity Parse(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.QuantityParser.Parse<LuminousIntensity, LuminousIntensityUnit>(
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
        public static bool TryParse(string? str, out LuminousIntensity result)
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
        public static bool TryParse(string? str, IFormatProvider? provider, out LuminousIntensity result)
        {
            return UnitsNetSetup.Default.QuantityParser.TryParse<LuminousIntensity, LuminousIntensityUnit>(
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
        public static LuminousIntensityUnit ParseUnit(string str)
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
        public static LuminousIntensityUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitParser.Parse<LuminousIntensityUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.LuminousIntensityUnit)"/>
        public static bool TryParseUnit(string str, out LuminousIntensityUnit unit)
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
        public static bool TryParseUnit(string str, IFormatProvider? provider, out LuminousIntensityUnit unit)
        {
            return UnitsNetSetup.Default.UnitParser.TryParse<LuminousIntensityUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static LuminousIntensity operator -(LuminousIntensity right)
        {
            return new LuminousIntensity(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LuminousIntensity"/> from adding two <see cref="LuminousIntensity"/>.</summary>
        public static LuminousIntensity operator +(LuminousIntensity left, LuminousIntensity right)
        {
            return new LuminousIntensity(left.Value + right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="LuminousIntensity"/> from subtracting two <see cref="LuminousIntensity"/>.</summary>
        public static LuminousIntensity operator -(LuminousIntensity left, LuminousIntensity right)
        {
            return new LuminousIntensity(left.Value - right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="LuminousIntensity"/> from multiplying value and <see cref="LuminousIntensity"/>.</summary>
        public static LuminousIntensity operator *(QuantityValue left, LuminousIntensity right)
        {
            return new LuminousIntensity(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LuminousIntensity"/> from multiplying value and <see cref="LuminousIntensity"/>.</summary>
        public static LuminousIntensity operator *(LuminousIntensity left, QuantityValue right)
        {
            return new LuminousIntensity(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="LuminousIntensity"/> from dividing <see cref="LuminousIntensity"/> by value.</summary>
        public static LuminousIntensity operator /(LuminousIntensity left, QuantityValue right)
        {
            return new LuminousIntensity(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="LuminousIntensity"/> by <see cref="LuminousIntensity"/>.</summary>
        public static QuantityValue operator /(LuminousIntensity left, LuminousIntensity right)
        {
            return left.Candela / right.Candela;
        }

        #endregion

        #region Relational Operators

        /// <summary>Get <see cref="Area"/> from <see cref="LuminousIntensity"/> / <see cref="Luminance"/>.</summary>
        public static Area operator /(LuminousIntensity luminousIntensity, Luminance luminance)
        {
            return Area.FromSquareMeters(luminousIntensity.Candela / luminance.CandelasPerSquareMeter);
        }

        /// <summary>Get <see cref="Luminance"/> from <see cref="LuminousIntensity"/> / <see cref="Area"/>.</summary>
        public static Luminance operator /(LuminousIntensity luminousIntensity, Area area)
        {
            return Luminance.FromCandelasPerSquareMeter(luminousIntensity.Candela / area.SquareMeters);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(LuminousIntensity left, LuminousIntensity right)
        {
            return left.Value <= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(LuminousIntensity left, LuminousIntensity right)
        {
            return left.Value >= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(LuminousIntensity left, LuminousIntensity right)
        {
            return left.Value < right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(LuminousIntensity left, LuminousIntensity right)
        {
            return left.Value > right.ToUnit(left.Unit).Value;
        }

        /// <summary>Indicates strict equality of two <see cref="LuminousIntensity"/> quantities.</summary>
        public static bool operator ==(LuminousIntensity left, LuminousIntensity right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="LuminousIntensity"/> quantities.</summary>
        public static bool operator !=(LuminousIntensity left, LuminousIntensity right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LuminousIntensity"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is LuminousIntensity otherQuantity))
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LuminousIntensity"/> quantities.</summary>
        public bool Equals(LuminousIntensity other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>Compares the current <see cref="LuminousIntensity"/> with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
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
            if (!(obj is LuminousIntensity otherQuantity)) throw new ArgumentException("Expected type LuminousIntensity.", nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>Compares the current <see cref="LuminousIntensity"/> with another <see cref="LuminousIntensity"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="other">A quantity to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(LuminousIntensity other)
        {
            return _value.CompareTo(other.ToUnit(this.Unit).Value);
        }

        /// <inheritdoc />
        public bool Equals(IQuantity? other, IQuantity tolerance)
        {
            return other is LuminousIntensity otherTyped
                   && (tolerance is LuminousIntensity toleranceTyped
                       ? true
                       : throw new ArgumentException($"Tolerance quantity ({tolerance.QuantityInfo.Name}) did not match the other quantities of type 'LuminousIntensity'.", nameof(tolerance)))
                   && Equals(otherTyped, toleranceTyped);
        }

        /// <inheritdoc />
        public bool Equals(LuminousIntensity other, LuminousIntensity tolerance)
        {
            return UnitsNet.Comparison.EqualsAbsolute(
                this.Value,
                other.As(this.Unit),
                tolerance: tolerance.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current LuminousIntensity.</returns>
        public override int GetHashCode()
        {
            var valueInBaseUnit = As(BaseUnit);
            #if NET7_0_OR_GREATER
            return HashCode.Combine(Info.Name, valueInBaseUnit);
            #else
            return new { Info.Name, valueInBaseUnit }.GetHashCode();
            #endif
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(LuminousIntensityUnit unit)
        {
            if (Unit == unit)
                return Value;

            return ToUnit(unit).Value;
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public QuantityValue As(UnitSystem unitSystem)
        {
            if (unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if (firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        QuantityValue IQuantity.As(Enum unit)
        {
            if (!(unit is LuminousIntensityUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(LuminousIntensityUnit)} is supported.", nameof(unit));

            return As(typedUnit);
        }

        /// <summary>
        ///     Converts this LuminousIntensity to another LuminousIntensity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A LuminousIntensity with the specified unit.</returns>
        public LuminousIntensity ToUnit(LuminousIntensityUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this <see cref="LuminousIntensity"/> to another <see cref="LuminousIntensity"/> using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A LuminousIntensity with the specified unit.</returns>
        public LuminousIntensity ToUnit(LuminousIntensityUnit unit, UnitConverter unitConverter)
        {
            if (TryToUnit(unit, out var converted))
            {
                // Try to convert using the auto-generated conversion methods.
                return converted!.Value;
            }
            else if (unitConverter.TryGetConversionFunction((typeof(LuminousIntensity), Unit, typeof(LuminousIntensity), unit), out var conversionFunction))
            {
                // See if the unit converter has an extensibility conversion registered.
                return (LuminousIntensity)conversionFunction(this);
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
        ///     Attempts to convert this <see cref="LuminousIntensity"/> to another <see cref="LuminousIntensity"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="converted">The converted <see cref="LuminousIntensity"/> in <paramref name="unit"/>, if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        private bool TryToUnit(LuminousIntensityUnit unit, [NotNullWhen(true)] out LuminousIntensity? converted)
        {
            if (Unit == unit)
            {
                converted = this;
                return true;
            }

            LuminousIntensity? convertedOrNull = (Unit, unit) switch
            {
                // LuminousIntensityUnit -> BaseUnit

                // BaseUnit -> LuminousIntensityUnit

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

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if (!(unit is LuminousIntensityUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(LuminousIntensityUnit)} is supported.", nameof(unit));

            return ToUnit(typedUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public LuminousIntensity ToUnit(UnitSystem unitSystem)
        {
            if (unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if (firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<LuminousIntensityUnit> IQuantity<LuminousIntensityUnit>.ToUnit(LuminousIntensityUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<LuminousIntensityUnit> IQuantity<LuminousIntensityUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
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
            return QuantityFormatter.Format<LuminousIntensityUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(LuminousIntensity)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider? provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(LuminousIntensity)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(LuminousIntensity)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider? provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider? provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider? provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider? provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider? provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider? provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider? provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider? provider)
        {
            if (conversionType == typeof(LuminousIntensity))
                return this;
            else if (conversionType == typeof(LuminousIntensityUnit))
                return Unit;
            else if (conversionType == typeof(QuantityInfo))
                return LuminousIntensity.Info;
            else if (conversionType == typeof(BaseDimensions))
                return LuminousIntensity.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(LuminousIntensity)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider? provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider? provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider? provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}
