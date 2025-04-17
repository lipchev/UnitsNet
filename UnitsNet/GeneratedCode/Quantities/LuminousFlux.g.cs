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
    ///     In photometry, luminous flux or luminous power is the measure of the perceived power of light.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminous_flux
    /// </remarks>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
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
        [DataMember(Name = "Value", Order = 1, EmitDefaultValue = false)]
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 2, EmitDefaultValue = false)]
        private readonly LuminousFluxUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="LuminousFlux"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class LuminousFluxInfo: QuantityInfo<LuminousFlux, LuminousFluxUnit>
        {
            /// <inheritdoc />
            public LuminousFluxInfo(string name, LuminousFluxUnit baseUnit, IEnumerable<IUnitDefinition<LuminousFluxUnit>> unitMappings, LuminousFlux zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<LuminousFlux, LuminousFluxUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public LuminousFluxInfo(string name, LuminousFluxUnit baseUnit, IEnumerable<IUnitDefinition<LuminousFluxUnit>> unitMappings, LuminousFlux zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, LuminousFlux.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.LuminousFlux", typeof(LuminousFlux).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="LuminousFluxInfo"/> class with the default settings for the LuminousFlux quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="LuminousFluxInfo"/> class with the default settings.</returns>
            public static LuminousFluxInfo CreateDefault()
            {
                return new LuminousFluxInfo(nameof(LuminousFlux), DefaultBaseUnit, GetDefaultMappings(), new LuminousFlux(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="LuminousFluxInfo"/> class with the default settings for the LuminousFlux quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="LuminousFluxInfo"/> class with the default settings.
            /// </returns>
            public static LuminousFluxInfo CreateDefault(Func<IEnumerable<UnitDefinition<LuminousFluxUnit>>, IEnumerable<IUnitDefinition<LuminousFluxUnit>>> customizeUnits)
            {
                return new LuminousFluxInfo(nameof(LuminousFlux), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new LuminousFlux(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="LuminousFlux"/> is J.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(0, 0, 0, 0, 0, 0, 1);

            /// <summary>
            ///     The default base unit of LuminousFlux is Lumen. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static LuminousFluxUnit DefaultBaseUnit { get; } = LuminousFluxUnit.Lumen;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="LuminousFluxUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{LuminousFluxUnit}"/> representing the default unit mappings for LuminousFlux.</returns>
            public static IEnumerable<UnitDefinition<LuminousFluxUnit>> GetDefaultMappings()
            {
                yield return new (LuminousFluxUnit.Lumen, "Lumen", "Lumens", new BaseUnits(luminousIntensity: LuminousIntensityUnit.Candela));
            }
        }

        static LuminousFlux()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(LuminousFluxInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public LuminousFlux(QuantityValue value, LuminousFluxUnit unit)
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
        public LuminousFlux(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="LuminousFlux" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<LuminousFlux, LuminousFluxUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of LuminousFlux, which is Lumen. All conversions go via this value.
        /// </summary>
        public static LuminousFluxUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the LuminousFlux quantity.
        /// </summary>
        public static IReadOnlyCollection<LuminousFluxUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Lumen.
        /// </summary>
        public static LuminousFlux Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public LuminousFluxUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<LuminousFlux, LuminousFluxUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => LuminousFlux.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<LuminousFluxUnit> IQuantity<LuminousFluxUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<LuminousFlux> IQuantityInstance<LuminousFlux>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="LuminousFluxUnit.Lumen"/>
        /// </summary>
        public QuantityValue Lumens => this.As(LuminousFluxUnit.Lumen);

        #endregion

        #region Static Methods

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
        public static LuminousFlux FromLumens(QuantityValue value)
        {
            return new LuminousFlux(value, LuminousFluxUnit.Lumen);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminousFluxUnit" /> to <see cref="LuminousFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LuminousFlux unit value.</returns>
        public static LuminousFlux From(QuantityValue value, LuminousFluxUnit fromUnit)
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
            return QuantityParser.Default.Parse<LuminousFlux, LuminousFluxUnit>(str, provider, From);
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
            return QuantityParser.Default.TryParse<LuminousFlux, LuminousFluxUnit>(str, provider, From, out result);
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
        /// <param name="provider">Format to use when parsing the unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static LuminousFluxUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.LuminousFluxUnit)"/>
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
        /// <param name="provider">Format to use when parsing the unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
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
            return new LuminousFlux(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from subtracting two <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator -(LuminousFlux left, LuminousFlux right)
        {
            return new LuminousFlux(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from multiplying value and <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator *(QuantityValue left, LuminousFlux right)
        {
            return new LuminousFlux(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from multiplying value and <see cref="LuminousFlux"/>.</summary>
        public static LuminousFlux operator *(LuminousFlux left, QuantityValue right)
        {
            return new LuminousFlux(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="LuminousFlux"/> from dividing <see cref="LuminousFlux"/> by value.</summary>
        public static LuminousFlux operator /(LuminousFlux left, QuantityValue right)
        {
            return new LuminousFlux(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="LuminousFlux"/> by <see cref="LuminousFlux"/>.</summary>
        public static QuantityValue operator /(LuminousFlux left, LuminousFlux right)
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
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(LuminousFlux left, LuminousFlux right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(LuminousFlux left, LuminousFlux right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(LuminousFlux left, LuminousFlux right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="LuminousFlux"/> quantities.</summary>
        public static bool operator ==(LuminousFlux left, LuminousFlux right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="LuminousFlux"/> quantities.</summary>
        public static bool operator !=(LuminousFlux left, LuminousFlux right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LuminousFlux"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not LuminousFlux otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="LuminousFlux"/> quantities.</summary>
        public bool Equals(LuminousFlux other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current LuminousFlux.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(LuminousFlux), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(LuminousFlux)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not LuminousFlux otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<LuminousFlux>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="LuminousFlux"/> with another <see cref="LuminousFlux"/> and returns an integer that indicates
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
        public int CompareTo(LuminousFlux other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<LuminousFluxUnit> IQuantity<LuminousFluxUnit>.ToUnit(LuminousFluxUnit unit) => this.ToUnit(unit);

        IQuantity<LuminousFluxUnit> IQuantity<LuminousFluxUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
