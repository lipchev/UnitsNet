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
    ///     A leakage rate of QL = 1 Pa-m³/s is given when the pressure in a closed, evacuated container with a volume of 1 m³ rises by 1 Pa per second or when the pressure in the container drops by 1 Pa in the event of overpressure.
    /// </summary>
    /// <remarks>
    ///     https://www.leybold.com/en-in/knowledge/vacuum-fundamentals/leak-detection/definition-and-measurement-of-vacuum-leaks
    /// </remarks>
    [DataContract]
    [DebuggerTypeProxy(typeof(QuantityDisplay))]
    public readonly partial struct LeakRate :
        IArithmeticQuantity<LeakRate, LeakRateUnit>,
        IComparable,
        IComparable<LeakRate>,
        IConvertible,
        IEquatable<LeakRate>,
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
        private readonly LeakRateUnit? _unit;

        static LeakRate()
        {
            BaseDimensions = new BaseDimensions(2, 1, -3, 0, 0, 0, 0);
            BaseUnit = LeakRateUnit.PascalCubicMeterPerSecond;
            Units = Enum.GetValues(typeof(LeakRateUnit)).Cast<LeakRateUnit>().ToArray();
            Zero = new LeakRate(0, BaseUnit);
            Info = new QuantityInfo<LeakRateUnit>("LeakRate",
                new UnitInfo<LeakRateUnit>[]
                {
                    new UnitInfo<LeakRateUnit>(LeakRateUnit.MillibarLiterPerSecond, "MillibarLitersPerSecond", BaseUnits.Undefined, "LeakRate"),
                    new UnitInfo<LeakRateUnit>(LeakRateUnit.PascalCubicMeterPerSecond, "PascalCubicMetersPerSecond", BaseUnits.Undefined, "LeakRate"),
                    new UnitInfo<LeakRateUnit>(LeakRateUnit.TorrLiterPerSecond, "TorrLitersPerSecond", BaseUnits.Undefined, "LeakRate"),
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
        public LeakRate(QuantityValue value, LeakRateUnit unit)
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
        public LeakRate(QuantityValue value, UnitSystem unitSystem)
        {
            if (unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = value;
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="LeakRate" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<LeakRateUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of LeakRate, which is PascalCubicMeterPerSecond. All conversions go via this value.
        /// </summary>
        public static LeakRateUnit BaseUnit { get; }

        /// <summary>
        ///     All units of measurement for the LeakRate quantity.
        /// </summary>
        public static LeakRateUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit PascalCubicMeterPerSecond.
        /// </summary>
        public static LeakRate Zero { get; }

        /// <inheritdoc cref="Zero"/>
        public static LeakRate AdditiveIdentity => Zero;

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
        public LeakRateUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<LeakRateUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => LeakRate.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LeakRateUnit.MillibarLiterPerSecond"/>
        /// </summary>
        public QuantityValue MillibarLitersPerSecond => As(LeakRateUnit.MillibarLiterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LeakRateUnit.PascalCubicMeterPerSecond"/>
        /// </summary>
        public QuantityValue PascalCubicMetersPerSecond => As(LeakRateUnit.PascalCubicMeterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LeakRateUnit.TorrLiterPerSecond"/>
        /// </summary>
        public QuantityValue TorrLitersPerSecond => As(LeakRateUnit.TorrLiterPerSecond);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: LeakRateUnit -> BaseUnit
            unitConverter.SetConversionFunction<LeakRate>(LeakRateUnit.MillibarLiterPerSecond, LeakRateUnit.PascalCubicMeterPerSecond, quantity => quantity.ToUnit(LeakRateUnit.PascalCubicMeterPerSecond));
            unitConverter.SetConversionFunction<LeakRate>(LeakRateUnit.TorrLiterPerSecond, LeakRateUnit.PascalCubicMeterPerSecond, quantity => quantity.ToUnit(LeakRateUnit.PascalCubicMeterPerSecond));

            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<LeakRate>(LeakRateUnit.PascalCubicMeterPerSecond, LeakRateUnit.PascalCubicMeterPerSecond, quantity => quantity);

            // Register in unit converter: BaseUnit -> LeakRateUnit
            unitConverter.SetConversionFunction<LeakRate>(LeakRateUnit.PascalCubicMeterPerSecond, LeakRateUnit.MillibarLiterPerSecond, quantity => quantity.ToUnit(LeakRateUnit.MillibarLiterPerSecond));
            unitConverter.SetConversionFunction<LeakRate>(LeakRateUnit.PascalCubicMeterPerSecond, LeakRateUnit.TorrLiterPerSecond, quantity => quantity.ToUnit(LeakRateUnit.TorrLiterPerSecond));
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(LeakRateUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(LeakRateUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="LeakRate"/> from <see cref="LeakRateUnit.MillibarLiterPerSecond"/>.
        /// </summary>
        public static LeakRate FromMillibarLitersPerSecond(QuantityValue value)
        {
            return new LeakRate(value, LeakRateUnit.MillibarLiterPerSecond);
        }

        /// <summary>
        ///     Creates a <see cref="LeakRate"/> from <see cref="LeakRateUnit.PascalCubicMeterPerSecond"/>.
        /// </summary>
        public static LeakRate FromPascalCubicMetersPerSecond(QuantityValue value)
        {
            return new LeakRate(value, LeakRateUnit.PascalCubicMeterPerSecond);
        }

        /// <summary>
        ///     Creates a <see cref="LeakRate"/> from <see cref="LeakRateUnit.TorrLiterPerSecond"/>.
        /// </summary>
        public static LeakRate FromTorrLitersPerSecond(QuantityValue value)
        {
            return new LeakRate(value, LeakRateUnit.TorrLiterPerSecond);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LeakRateUnit" /> to <see cref="LeakRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LeakRate unit value.</returns>
        public static LeakRate From(QuantityValue value, LeakRateUnit fromUnit)
        {
            return new LeakRate(value, fromUnit);
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
        public static LeakRate Parse(string str)
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
        public static LeakRate Parse(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.QuantityParser.Parse<LeakRate, LeakRateUnit>(
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
        public static bool TryParse(string? str, out LeakRate result)
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
        public static bool TryParse(string? str, IFormatProvider? provider, out LeakRate result)
        {
            return UnitsNetSetup.Default.QuantityParser.TryParse<LeakRate, LeakRateUnit>(
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
        public static LeakRateUnit ParseUnit(string str)
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
        public static LeakRateUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitParser.Parse<LeakRateUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.LeakRateUnit)"/>
        public static bool TryParseUnit(string str, out LeakRateUnit unit)
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
        public static bool TryParseUnit(string str, IFormatProvider? provider, out LeakRateUnit unit)
        {
            return UnitsNetSetup.Default.UnitParser.TryParse<LeakRateUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static LeakRate operator -(LeakRate right)
        {
            return new LeakRate(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LeakRate"/> from adding two <see cref="LeakRate"/>.</summary>
        public static LeakRate operator +(LeakRate left, LeakRate right)
        {
            return new LeakRate(left.Value + right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="LeakRate"/> from subtracting two <see cref="LeakRate"/>.</summary>
        public static LeakRate operator -(LeakRate left, LeakRate right)
        {
            return new LeakRate(left.Value - right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="LeakRate"/> from multiplying value and <see cref="LeakRate"/>.</summary>
        public static LeakRate operator *(QuantityValue left, LeakRate right)
        {
            return new LeakRate(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LeakRate"/> from multiplying value and <see cref="LeakRate"/>.</summary>
        public static LeakRate operator *(LeakRate left, QuantityValue right)
        {
            return new LeakRate(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="LeakRate"/> from dividing <see cref="LeakRate"/> by value.</summary>
        public static LeakRate operator /(LeakRate left, QuantityValue right)
        {
            return new LeakRate(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="LeakRate"/> by <see cref="LeakRate"/>.</summary>
        public static QuantityValue operator /(LeakRate left, LeakRate right)
        {
            return left.PascalCubicMetersPerSecond / right.PascalCubicMetersPerSecond;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(LeakRate left, LeakRate right)
        {
            return left.Value <= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(LeakRate left, LeakRate right)
        {
            return left.Value >= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(LeakRate left, LeakRate right)
        {
            return left.Value < right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(LeakRate left, LeakRate right)
        {
            return left.Value > right.ToUnit(left.Unit).Value;
        }

        /// <summary>Indicates strict equality of two <see cref="LeakRate"/> quantities.</summary>
        public static bool operator ==(LeakRate left, LeakRate right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="LeakRate"/> quantities.</summary>
        public static bool operator !=(LeakRate left, LeakRate right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LeakRate"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is LeakRate otherQuantity))
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LeakRate"/> quantities.</summary>
        public bool Equals(LeakRate other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>Compares the current <see cref="LeakRate"/> with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
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
            if (!(obj is LeakRate otherQuantity)) throw new ArgumentException("Expected type LeakRate.", nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>Compares the current <see cref="LeakRate"/> with another <see cref="LeakRate"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="other">A quantity to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(LeakRate other)
        {
            return _value.CompareTo(other.ToUnit(this.Unit).Value);
        }

        /// <inheritdoc />
        public bool Equals(IQuantity? other, IQuantity tolerance)
        {
            return other is LeakRate otherTyped
                   && (tolerance is LeakRate toleranceTyped
                       ? true
                       : throw new ArgumentException($"Tolerance quantity ({tolerance.QuantityInfo.Name}) did not match the other quantities of type 'LeakRate'.", nameof(tolerance)))
                   && Equals(otherTyped, toleranceTyped);
        }

        /// <inheritdoc />
        public bool Equals(LeakRate other, LeakRate tolerance)
        {
            return UnitsNet.Comparison.EqualsAbsolute(
                this.Value,
                other.As(this.Unit),
                tolerance: tolerance.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current LeakRate.</returns>
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
        public QuantityValue As(LeakRateUnit unit)
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
            if (!(unit is LeakRateUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(LeakRateUnit)} is supported.", nameof(unit));

            return As(typedUnit);
        }

        /// <summary>
        ///     Converts this LeakRate to another LeakRate with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A LeakRate with the specified unit.</returns>
        public LeakRate ToUnit(LeakRateUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this <see cref="LeakRate"/> to another <see cref="LeakRate"/> using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A LeakRate with the specified unit.</returns>
        public LeakRate ToUnit(LeakRateUnit unit, UnitConverter unitConverter)
        {
            if (TryToUnit(unit, out var converted))
            {
                // Try to convert using the auto-generated conversion methods.
                return converted!.Value;
            }
            else if (unitConverter.TryGetConversionFunction((typeof(LeakRate), Unit, typeof(LeakRate), unit), out var conversionFunction))
            {
                // See if the unit converter has an extensibility conversion registered.
                return (LeakRate)conversionFunction(this);
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
        ///     Attempts to convert this <see cref="LeakRate"/> to another <see cref="LeakRate"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="converted">The converted <see cref="LeakRate"/> in <paramref name="unit"/>, if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        private bool TryToUnit(LeakRateUnit unit, [NotNullWhen(true)] out LeakRate? converted)
        {
            if (Unit == unit)
            {
                converted = this;
                return true;
            }

            LeakRate? convertedOrNull = (Unit, unit) switch
            {
                // LeakRateUnit -> BaseUnit
                (LeakRateUnit.MillibarLiterPerSecond, LeakRateUnit.PascalCubicMeterPerSecond) => new LeakRate(_value / 10, LeakRateUnit.PascalCubicMeterPerSecond),
                (LeakRateUnit.TorrLiterPerSecond, LeakRateUnit.PascalCubicMeterPerSecond) => new LeakRate(_value * new QuantityValue(2, 15), LeakRateUnit.PascalCubicMeterPerSecond),

                // BaseUnit -> LeakRateUnit
                (LeakRateUnit.PascalCubicMeterPerSecond, LeakRateUnit.MillibarLiterPerSecond) => new LeakRate(_value * 10, LeakRateUnit.MillibarLiterPerSecond),
                (LeakRateUnit.PascalCubicMeterPerSecond, LeakRateUnit.TorrLiterPerSecond) => new LeakRate(_value * new QuantityValue(15, 2), LeakRateUnit.TorrLiterPerSecond),

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
            if (!(unit is LeakRateUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(LeakRateUnit)} is supported.", nameof(unit));

            return ToUnit(typedUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public LeakRate ToUnit(UnitSystem unitSystem)
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
        IQuantity<LeakRateUnit> IQuantity<LeakRateUnit>.ToUnit(LeakRateUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<LeakRateUnit> IQuantity<LeakRateUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

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
            return QuantityFormatter.Format<LeakRateUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(LeakRate)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider? provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(LeakRate)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(LeakRate)} to DateTime is not supported.");
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
            if (conversionType == typeof(LeakRate))
                return this;
            else if (conversionType == typeof(LeakRateUnit))
                return Unit;
            else if (conversionType == typeof(QuantityInfo))
                return LeakRate.Info;
            else if (conversionType == typeof(BaseDimensions))
                return LeakRate.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(LeakRate)} to {conversionType} is not supported.");
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
