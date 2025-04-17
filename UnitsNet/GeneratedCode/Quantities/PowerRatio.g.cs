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
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Resources;
using System.Runtime.Serialization;
using UnitsNet.Units;
using UnitsNet.Debug;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The strength of a signal expressed in decibels (dB) relative to one watt.
    /// </summary>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct PowerRatio :
        ILogarithmicQuantity<PowerRatio, PowerRatioUnit>,
#if NET7_0_OR_GREATER
        IComparisonOperators<PowerRatio, PowerRatio, bool>,
        IParsable<PowerRatio>,
#endif
        IComparable,
        IComparable<PowerRatio>,
        IEquatable<PowerRatio>,
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
        private readonly PowerRatioUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="PowerRatio"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class PowerRatioInfo: QuantityInfo<PowerRatio, PowerRatioUnit>
        {
            /// <inheritdoc />
            public PowerRatioInfo(string name, PowerRatioUnit baseUnit, IEnumerable<IUnitDefinition<PowerRatioUnit>> unitMappings, PowerRatio zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<PowerRatio, PowerRatioUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public PowerRatioInfo(string name, PowerRatioUnit baseUnit, IEnumerable<IUnitDefinition<PowerRatioUnit>> unitMappings, PowerRatio zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, PowerRatio.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.PowerRatio", typeof(PowerRatio).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="PowerRatioInfo"/> class with the default settings for the PowerRatio quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="PowerRatioInfo"/> class with the default settings.</returns>
            public static PowerRatioInfo CreateDefault()
            {
                return new PowerRatioInfo(nameof(PowerRatio), DefaultBaseUnit, GetDefaultMappings(), new PowerRatio(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="PowerRatioInfo"/> class with the default settings for the PowerRatio quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="PowerRatioInfo"/> class with the default settings.
            /// </returns>
            public static PowerRatioInfo CreateDefault(Func<IEnumerable<UnitDefinition<PowerRatioUnit>>, IEnumerable<IUnitDefinition<PowerRatioUnit>>> customizeUnits)
            {
                return new PowerRatioInfo(nameof(PowerRatio), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new PowerRatio(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="PowerRatio"/> is .
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = BaseDimensions.Dimensionless;

            /// <summary>
            ///     The default base unit of PowerRatio is DecibelWatt. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static PowerRatioUnit DefaultBaseUnit { get; } = PowerRatioUnit.DecibelWatt;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="PowerRatioUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{PowerRatioUnit}"/> representing the default unit mappings for PowerRatio.</returns>
            public static IEnumerable<UnitDefinition<PowerRatioUnit>> GetDefaultMappings()
            {
                yield return new (PowerRatioUnit.DecibelMilliwatt, "DecibelMilliwatt", "DecibelMilliwatts", BaseUnits.Undefined,
                     new ConversionExpression(1, 30),
                     new ConversionExpression(1, -30)                
                );
                yield return new (PowerRatioUnit.DecibelWatt, "DecibelWatt", "DecibelWatts", BaseUnits.Undefined);
            }
        }

        static PowerRatio()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(PowerRatioInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public PowerRatio(QuantityValue value, PowerRatioUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="PowerRatio" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<PowerRatio, PowerRatioUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of PowerRatio, which is DecibelWatt. All conversions go via this value.
        /// </summary>
        public static PowerRatioUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the PowerRatio quantity.
        /// </summary>
        public static IReadOnlyCollection<PowerRatioUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit DecibelWatt.
        /// </summary>
        public static PowerRatio Zero => Info.Zero;

        /// <inheritdoc />
        public static QuantityValue LogarithmicScalingFactor {get;} = 10;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public PowerRatioUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<PowerRatio, PowerRatioUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => PowerRatio.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<PowerRatioUnit> IQuantity<PowerRatioUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<PowerRatio> IQuantityInstance<PowerRatio>.QuantityInfo => Info;
#endif

#if NETSTANDARD2_0
        QuantityValue ILogarithmicQuantity<PowerRatio>.LogarithmicScalingFactor => LogarithmicScalingFactor;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="PowerRatioUnit.DecibelMilliwatt"/>
        /// </summary>
        public QuantityValue DecibelMilliwatts => this.As(PowerRatioUnit.DecibelMilliwatt);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="PowerRatioUnit.DecibelWatt"/>
        /// </summary>
        public QuantityValue DecibelWatts => this.As(PowerRatioUnit.DecibelWatt);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(PowerRatioUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(PowerRatioUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="PowerRatio"/> from <see cref="PowerRatioUnit.DecibelMilliwatt"/>.
        /// </summary>
        public static PowerRatio FromDecibelMilliwatts(QuantityValue value)
        {
            return new PowerRatio(value, PowerRatioUnit.DecibelMilliwatt);
        }

        /// <summary>
        ///     Creates a <see cref="PowerRatio"/> from <see cref="PowerRatioUnit.DecibelWatt"/>.
        /// </summary>
        public static PowerRatio FromDecibelWatts(QuantityValue value)
        {
            return new PowerRatio(value, PowerRatioUnit.DecibelWatt);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PowerRatioUnit" /> to <see cref="PowerRatio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PowerRatio unit value.</returns>
        public static PowerRatio From(QuantityValue value, PowerRatioUnit fromUnit)
        {
            return new PowerRatio(value, fromUnit);
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
        public static PowerRatio Parse(string str)
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
        public static PowerRatio Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<PowerRatio, PowerRatioUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out PowerRatio result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out PowerRatio result)
        {
            return QuantityParser.Default.TryParse<PowerRatio, PowerRatioUnit>(str, provider, From, out result);
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
        public static PowerRatioUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing the unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static PowerRatioUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.PowerRatioUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out PowerRatioUnit unit)
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
        /// <param name="provider">Format to use when parsing the unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out PowerRatioUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Logarithmic Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static PowerRatio operator -(PowerRatio quantity)
        {
            return new PowerRatio(-quantity.Value, quantity.Unit);
        }

        /// <summary>Get <see cref="PowerRatio"/> from logarithmic addition of two <see cref="PowerRatio"/>.</summary>
        /// <remarks>This operation involves a conversion of the values to linear space, which is not guaranteed to produce an exact value.
        /// <para>The final result is rounded to 15 significant digits.</para>
        /// </remarks>
        public static PowerRatio operator +(PowerRatio left, PowerRatio right)
        {
            // Logarithmic addition
            // Formula: 10 * log10(10^(x/10) + 10^(y/10))
            var leftUnit = left.Unit;
            return new PowerRatio(QuantityValueExtensions.AddWithLogScaling(left.Value, right.As(leftUnit), LogarithmicScalingFactor), leftUnit);
        }

        /// <summary>Get <see cref="PowerRatio"/> from logarithmic subtraction of two <see cref="PowerRatio"/>.</summary>
        /// <remarks>This operation involves a conversion of the values to linear space, which is not guaranteed to produce an exact value.
        /// <para>The final result is rounded to 15 significant digits.</para>
        /// </remarks>
        public static PowerRatio operator -(PowerRatio left, PowerRatio right)
        {
            // Logarithmic subtraction
            // Formula: 10 * log10(10^(x/10) - 10^(y/10))
            var leftUnit = left.Unit;
            return new PowerRatio(QuantityValueExtensions.SubtractWithLogScaling(left.Value, right.As(leftUnit), LogarithmicScalingFactor), leftUnit);
        }

        /// <summary>Get <see cref="PowerRatio"/> from logarithmic multiplication of value and <see cref="PowerRatio"/>.</summary>
        public static PowerRatio operator *(QuantityValue left, PowerRatio right)
        {
            // Logarithmic multiplication = addition
            return new PowerRatio(left + right.Value, right.Unit);
        }

        /// <summary>Get <see cref="PowerRatio"/> from logarithmic multiplication of value and <see cref="PowerRatio"/>.</summary>
        public static PowerRatio operator *(PowerRatio left, QuantityValue right)
        {
            // Logarithmic multiplication = addition
            return new PowerRatio(left.Value + right, left.Unit);
        }

        /// <summary>Get <see cref="PowerRatio"/> from logarithmic division of <see cref="PowerRatio"/> by value.</summary>
        public static PowerRatio operator /(PowerRatio left, QuantityValue right)
        {
            // Logarithmic division = subtraction
            return new PowerRatio(left.Value - right, left.Unit);
        }

        /// <summary>Get ratio value from logarithmic division of <see cref="PowerRatio"/> by <see cref="PowerRatio"/>.</summary>
        public static QuantityValue operator /(PowerRatio left, PowerRatio right)
        {
            // Logarithmic division = subtraction
            return left.Value - right.As(left.Unit);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(PowerRatio left, PowerRatio right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(PowerRatio left, PowerRatio right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(PowerRatio left, PowerRatio right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(PowerRatio left, PowerRatio right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="PowerRatio"/> quantities.</summary>
        public static bool operator ==(PowerRatio left, PowerRatio right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="PowerRatio"/> quantities.</summary>
        public static bool operator !=(PowerRatio left, PowerRatio right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="PowerRatio"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not PowerRatio otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="PowerRatio"/> quantities.</summary>
        public bool Equals(PowerRatio other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current PowerRatio.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(PowerRatio), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(PowerRatio)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not PowerRatio otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<PowerRatio>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="PowerRatio"/> with another <see cref="PowerRatio"/> and returns an integer that indicates
        ///     whether the current instance precedes, follows, or occurs in the same position in the sort order as the other quantity, when converted to the same unit.
        /// </summary>
        /// <param name="other">A quantity to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(PowerRatio other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<PowerRatioUnit> IQuantity<PowerRatioUnit>.ToUnit(PowerRatioUnit unit) => this.ToUnit(unit);

        IQuantity<PowerRatioUnit> IQuantity<PowerRatioUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
#endif

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

        /// <inheritdoc cref="QuantityFormatter.Format{TQuantity}(TQuantity, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentCulture" /> if null.
        /// </summary>
        public string ToString(string? format, IFormatProvider? provider)
        {
            return QuantityFormatter.Default.Format(this, format, provider);
        }

        #endregion

    }
}
