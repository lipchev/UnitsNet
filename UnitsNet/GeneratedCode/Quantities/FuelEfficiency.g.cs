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
    ///     In the context of transport, fuel economy is the energy efficiency of a particular vehicle, given as a ratio of distance traveled per unit of fuel consumed. In most countries, using the metric system, fuel economy is stated as "fuel consumption" in liters per 100 kilometers (L/100 km) or kilometers per liter (km/L or kmpl). In countries using non-metric system, fuel economy is expressed in miles per gallon (mpg) (imperial galon or US galon).
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Fuel_efficiency
    /// </remarks>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct FuelEfficiency :
        IArithmeticQuantity<FuelEfficiency, FuelEfficiencyUnit>,
#if NET7_0_OR_GREATER
        IComparisonOperators<FuelEfficiency, FuelEfficiency, bool>,
        IParsable<FuelEfficiency>,
#endif
        IComparable,
        IComparable<FuelEfficiency>,
        IEquatable<FuelEfficiency>,
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
        private readonly FuelEfficiencyUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="FuelEfficiency"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class FuelEfficiencyInfo: QuantityInfo<FuelEfficiency, FuelEfficiencyUnit>
        {
            /// <inheritdoc />
            public FuelEfficiencyInfo(string name, FuelEfficiencyUnit baseUnit, IEnumerable<IUnitDefinition<FuelEfficiencyUnit>> unitMappings, FuelEfficiency zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<FuelEfficiency, FuelEfficiencyUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public FuelEfficiencyInfo(string name, FuelEfficiencyUnit baseUnit, IEnumerable<IUnitDefinition<FuelEfficiencyUnit>> unitMappings, FuelEfficiency zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, FuelEfficiency.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.FuelEfficiency", typeof(FuelEfficiency).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="FuelEfficiencyInfo"/> class with the default settings for the FuelEfficiency quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="FuelEfficiencyInfo"/> class with the default settings.</returns>
            public static FuelEfficiencyInfo CreateDefault()
            {
                return new FuelEfficiencyInfo(nameof(FuelEfficiency), DefaultBaseUnit, GetDefaultMappings(), new FuelEfficiency(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="FuelEfficiencyInfo"/> class with the default settings for the FuelEfficiency quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="FuelEfficiencyInfo"/> class with the default settings.
            /// </returns>
            public static FuelEfficiencyInfo CreateDefault(Func<IEnumerable<UnitDefinition<FuelEfficiencyUnit>>, IEnumerable<IUnitDefinition<FuelEfficiencyUnit>>> customizeUnits)
            {
                return new FuelEfficiencyInfo(nameof(FuelEfficiency), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new FuelEfficiency(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="FuelEfficiency"/> is L^-2.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(-2, 0, 0, 0, 0, 0, 0);

            /// <summary>
            ///     The default base unit of FuelEfficiency is KilometerPerLiter. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static FuelEfficiencyUnit DefaultBaseUnit { get; } = FuelEfficiencyUnit.KilometerPerLiter;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="FuelEfficiencyUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{FuelEfficiencyUnit}"/> representing the default unit mappings for FuelEfficiency.</returns>
            public static IEnumerable<UnitDefinition<FuelEfficiencyUnit>> GetDefaultMappings()
            {
                yield return new (FuelEfficiencyUnit.KilometerPerLiter, "KilometerPerLiter", "KilometersPerLiter", BaseUnits.Undefined);
                yield return new (FuelEfficiencyUnit.LiterPer100Kilometers, "LiterPer100Kilometers", "LitersPer100Kilometers", BaseUnits.Undefined,
                     new ConversionExpression(100, null, -1),
                     new ConversionExpression(100, null, -1)                
                );
                yield return new (FuelEfficiencyUnit.MilePerUkGallon, "MilePerUkGallon", "MilesPerUkGallon", BaseUnits.Undefined,
                     new QuantityValue(2273045, 804672)             
                );
                yield return new (FuelEfficiencyUnit.MilePerUsGallon, "MilePerUsGallon", "MilesPerUsGallon", BaseUnits.Undefined,
                     new QuantityValue(112903, 48000)             
                );
            }
        }

        static FuelEfficiency()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(FuelEfficiencyInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public FuelEfficiency(QuantityValue value, FuelEfficiencyUnit unit)
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
        public FuelEfficiency(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="FuelEfficiency" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<FuelEfficiency, FuelEfficiencyUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of FuelEfficiency, which is KilometerPerLiter. All conversions go via this value.
        /// </summary>
        public static FuelEfficiencyUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the FuelEfficiency quantity.
        /// </summary>
        public static IReadOnlyCollection<FuelEfficiencyUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit KilometerPerLiter.
        /// </summary>
        public static FuelEfficiency Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public FuelEfficiencyUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<FuelEfficiency, FuelEfficiencyUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => FuelEfficiency.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<FuelEfficiencyUnit> IQuantity<FuelEfficiencyUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<FuelEfficiency> IQuantityInstance<FuelEfficiency>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="FuelEfficiencyUnit.KilometerPerLiter"/>
        /// </summary>
        public QuantityValue KilometersPerLiter => this.As(FuelEfficiencyUnit.KilometerPerLiter);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="FuelEfficiencyUnit.LiterPer100Kilometers"/>
        /// </summary>
        public QuantityValue LitersPer100Kilometers => this.As(FuelEfficiencyUnit.LiterPer100Kilometers);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="FuelEfficiencyUnit.MilePerUkGallon"/>
        /// </summary>
        public QuantityValue MilesPerUkGallon => this.As(FuelEfficiencyUnit.MilePerUkGallon);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="FuelEfficiencyUnit.MilePerUsGallon"/>
        /// </summary>
        public QuantityValue MilesPerUsGallon => this.As(FuelEfficiencyUnit.MilePerUsGallon);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(FuelEfficiencyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(FuelEfficiencyUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="FuelEfficiency"/> from <see cref="FuelEfficiencyUnit.KilometerPerLiter"/>.
        /// </summary>
        public static FuelEfficiency FromKilometersPerLiter(QuantityValue value)
        {
            return new FuelEfficiency(value, FuelEfficiencyUnit.KilometerPerLiter);
        }

        /// <summary>
        ///     Creates a <see cref="FuelEfficiency"/> from <see cref="FuelEfficiencyUnit.LiterPer100Kilometers"/>.
        /// </summary>
        public static FuelEfficiency FromLitersPer100Kilometers(QuantityValue value)
        {
            return new FuelEfficiency(value, FuelEfficiencyUnit.LiterPer100Kilometers);
        }

        /// <summary>
        ///     Creates a <see cref="FuelEfficiency"/> from <see cref="FuelEfficiencyUnit.MilePerUkGallon"/>.
        /// </summary>
        public static FuelEfficiency FromMilesPerUkGallon(QuantityValue value)
        {
            return new FuelEfficiency(value, FuelEfficiencyUnit.MilePerUkGallon);
        }

        /// <summary>
        ///     Creates a <see cref="FuelEfficiency"/> from <see cref="FuelEfficiencyUnit.MilePerUsGallon"/>.
        /// </summary>
        public static FuelEfficiency FromMilesPerUsGallon(QuantityValue value)
        {
            return new FuelEfficiency(value, FuelEfficiencyUnit.MilePerUsGallon);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FuelEfficiencyUnit" /> to <see cref="FuelEfficiency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>FuelEfficiency unit value.</returns>
        public static FuelEfficiency From(QuantityValue value, FuelEfficiencyUnit fromUnit)
        {
            return new FuelEfficiency(value, fromUnit);
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
        public static FuelEfficiency Parse(string str)
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
        public static FuelEfficiency Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<FuelEfficiency, FuelEfficiencyUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out FuelEfficiency result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out FuelEfficiency result)
        {
            return QuantityParser.Default.TryParse<FuelEfficiency, FuelEfficiencyUnit>(str, provider, From, out result);
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
        public static FuelEfficiencyUnit ParseUnit(string str)
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
        public static FuelEfficiencyUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.FuelEfficiencyUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out FuelEfficiencyUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out FuelEfficiencyUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static FuelEfficiency operator -(FuelEfficiency right)
        {
            return new FuelEfficiency(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="FuelEfficiency"/> from adding two <see cref="FuelEfficiency"/>.</summary>
        public static FuelEfficiency operator +(FuelEfficiency left, FuelEfficiency right)
        {
            return new FuelEfficiency(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="FuelEfficiency"/> from subtracting two <see cref="FuelEfficiency"/>.</summary>
        public static FuelEfficiency operator -(FuelEfficiency left, FuelEfficiency right)
        {
            return new FuelEfficiency(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="FuelEfficiency"/> from multiplying value and <see cref="FuelEfficiency"/>.</summary>
        public static FuelEfficiency operator *(QuantityValue left, FuelEfficiency right)
        {
            return new FuelEfficiency(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="FuelEfficiency"/> from multiplying value and <see cref="FuelEfficiency"/>.</summary>
        public static FuelEfficiency operator *(FuelEfficiency left, QuantityValue right)
        {
            return new FuelEfficiency(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="FuelEfficiency"/> from dividing <see cref="FuelEfficiency"/> by value.</summary>
        public static FuelEfficiency operator /(FuelEfficiency left, QuantityValue right)
        {
            return new FuelEfficiency(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="FuelEfficiency"/> by <see cref="FuelEfficiency"/>.</summary>
        public static QuantityValue operator /(FuelEfficiency left, FuelEfficiency right)
        {
            return left.KilometersPerLiter / right.KilometersPerLiter;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(FuelEfficiency left, FuelEfficiency right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(FuelEfficiency left, FuelEfficiency right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(FuelEfficiency left, FuelEfficiency right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(FuelEfficiency left, FuelEfficiency right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="FuelEfficiency"/> quantities.</summary>
        public static bool operator ==(FuelEfficiency left, FuelEfficiency right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="FuelEfficiency"/> quantities.</summary>
        public static bool operator !=(FuelEfficiency left, FuelEfficiency right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="FuelEfficiency"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not FuelEfficiency otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="FuelEfficiency"/> quantities.</summary>
        public bool Equals(FuelEfficiency other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current FuelEfficiency.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(FuelEfficiency), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(FuelEfficiency)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not FuelEfficiency otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<FuelEfficiency>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="FuelEfficiency"/> with another <see cref="FuelEfficiency"/> and returns an integer that indicates
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
        public int CompareTo(FuelEfficiency other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<FuelEfficiencyUnit> IQuantity<FuelEfficiencyUnit>.ToUnit(FuelEfficiencyUnit unit) => this.ToUnit(unit);

        IQuantity<FuelEfficiencyUnit> IQuantity<FuelEfficiencyUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
