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
    ///     In electromagnetism, the current gradient describes how the current changes in time.
    /// </summary>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct ElectricCurrentGradient :
        IArithmeticQuantity<ElectricCurrentGradient, ElectricCurrentGradientUnit>,
#if NET7_0_OR_GREATER
        IMultiplyOperators<ElectricCurrentGradient, Duration, ElectricCurrent>,
#endif
#if NET7_0_OR_GREATER
        IComparisonOperators<ElectricCurrentGradient, ElectricCurrentGradient, bool>,
        IParsable<ElectricCurrentGradient>,
#endif
        IComparable,
        IComparable<ElectricCurrentGradient>,
        IEquatable<ElectricCurrentGradient>,
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
        private readonly ElectricCurrentGradientUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="ElectricCurrentGradient"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class ElectricCurrentGradientInfo: QuantityInfo<ElectricCurrentGradient, ElectricCurrentGradientUnit>
        {
            /// <inheritdoc />
            public ElectricCurrentGradientInfo(string name, ElectricCurrentGradientUnit baseUnit, IEnumerable<IUnitDefinition<ElectricCurrentGradientUnit>> unitMappings, ElectricCurrentGradient zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<ElectricCurrentGradient, ElectricCurrentGradientUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public ElectricCurrentGradientInfo(string name, ElectricCurrentGradientUnit baseUnit, IEnumerable<IUnitDefinition<ElectricCurrentGradientUnit>> unitMappings, ElectricCurrentGradient zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, ElectricCurrentGradient.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.ElectricCurrentGradient", typeof(ElectricCurrentGradient).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="ElectricCurrentGradientInfo"/> class with the default settings for the ElectricCurrentGradient quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="ElectricCurrentGradientInfo"/> class with the default settings.</returns>
            public static ElectricCurrentGradientInfo CreateDefault()
            {
                return new ElectricCurrentGradientInfo(nameof(ElectricCurrentGradient), DefaultBaseUnit, GetDefaultMappings(), new ElectricCurrentGradient(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="ElectricCurrentGradientInfo"/> class with the default settings for the ElectricCurrentGradient quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="ElectricCurrentGradientInfo"/> class with the default settings.
            /// </returns>
            public static ElectricCurrentGradientInfo CreateDefault(Func<IEnumerable<UnitDefinition<ElectricCurrentGradientUnit>>, IEnumerable<IUnitDefinition<ElectricCurrentGradientUnit>>> customizeUnits)
            {
                return new ElectricCurrentGradientInfo(nameof(ElectricCurrentGradient), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new ElectricCurrentGradient(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="ElectricCurrentGradient"/> is T^-1I.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(0, 0, -1, 1, 0, 0, 0);

            /// <summary>
            ///     The default base unit of ElectricCurrentGradient is AmperePerSecond. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static ElectricCurrentGradientUnit DefaultBaseUnit { get; } = ElectricCurrentGradientUnit.AmperePerSecond;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="ElectricCurrentGradientUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{ElectricCurrentGradientUnit}"/> representing the default unit mappings for ElectricCurrentGradient.</returns>
            public static IEnumerable<UnitDefinition<ElectricCurrentGradientUnit>> GetDefaultMappings()
            {
                yield return new (ElectricCurrentGradientUnit.AmperePerMicrosecond, "AmperePerMicrosecond", "AmperesPerMicrosecond", new BaseUnits(time: DurationUnit.Microsecond, current: ElectricCurrentUnit.Ampere),
                     new QuantityValue(1, 1000000)             
                );
                yield return new (ElectricCurrentGradientUnit.AmperePerMillisecond, "AmperePerMillisecond", "AmperesPerMillisecond", new BaseUnits(time: DurationUnit.Millisecond, current: ElectricCurrentUnit.Ampere),
                     new QuantityValue(1, 1000)             
                );
                yield return new (ElectricCurrentGradientUnit.AmperePerMinute, "AmperePerMinute", "AmperesPerMinute", new BaseUnits(time: DurationUnit.Minute, current: ElectricCurrentUnit.Ampere),
                     60             
                );
                yield return new (ElectricCurrentGradientUnit.AmperePerNanosecond, "AmperePerNanosecond", "AmperesPerNanosecond", new BaseUnits(time: DurationUnit.Nanosecond, current: ElectricCurrentUnit.Ampere),
                     new QuantityValue(1, 1000000000)             
                );
                yield return new (ElectricCurrentGradientUnit.AmperePerSecond, "AmperePerSecond", "AmperesPerSecond", new BaseUnits(time: DurationUnit.Second, current: ElectricCurrentUnit.Ampere));
                yield return new (ElectricCurrentGradientUnit.MilliamperePerMinute, "MilliamperePerMinute", "MilliamperesPerMinute", new BaseUnits(time: DurationUnit.Minute, current: ElectricCurrentUnit.Milliampere),
                     60000             
                );
                yield return new (ElectricCurrentGradientUnit.MilliamperePerSecond, "MilliamperePerSecond", "MilliamperesPerSecond", new BaseUnits(time: DurationUnit.Second, current: ElectricCurrentUnit.Milliampere),
                     1000             
                );
            }
        }

        static ElectricCurrentGradient()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(ElectricCurrentGradientInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ElectricCurrentGradient(QuantityValue value, ElectricCurrentGradientUnit unit)
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
        public ElectricCurrentGradient(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="ElectricCurrentGradient" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<ElectricCurrentGradient, ElectricCurrentGradientUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of ElectricCurrentGradient, which is AmperePerSecond. All conversions go via this value.
        /// </summary>
        public static ElectricCurrentGradientUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the ElectricCurrentGradient quantity.
        /// </summary>
        public static IReadOnlyCollection<ElectricCurrentGradientUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit AmperePerSecond.
        /// </summary>
        public static ElectricCurrentGradient Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ElectricCurrentGradientUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<ElectricCurrentGradient, ElectricCurrentGradientUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ElectricCurrentGradient.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<ElectricCurrentGradientUnit> IQuantity<ElectricCurrentGradientUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<ElectricCurrentGradient> IQuantityInstance<ElectricCurrentGradient>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerMicrosecond"/>
        /// </summary>
        public QuantityValue AmperesPerMicrosecond => this.As(ElectricCurrentGradientUnit.AmperePerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerMillisecond"/>
        /// </summary>
        public QuantityValue AmperesPerMillisecond => this.As(ElectricCurrentGradientUnit.AmperePerMillisecond);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerMinute"/>
        /// </summary>
        public QuantityValue AmperesPerMinute => this.As(ElectricCurrentGradientUnit.AmperePerMinute);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerNanosecond"/>
        /// </summary>
        public QuantityValue AmperesPerNanosecond => this.As(ElectricCurrentGradientUnit.AmperePerNanosecond);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerSecond"/>
        /// </summary>
        public QuantityValue AmperesPerSecond => this.As(ElectricCurrentGradientUnit.AmperePerSecond);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.MilliamperePerMinute"/>
        /// </summary>
        public QuantityValue MilliamperesPerMinute => this.As(ElectricCurrentGradientUnit.MilliamperePerMinute);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.MilliamperePerSecond"/>
        /// </summary>
        public QuantityValue MilliamperesPerSecond => this.As(ElectricCurrentGradientUnit.MilliamperePerSecond);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ElectricCurrentGradientUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(ElectricCurrentGradientUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerMicrosecond"/>.
        /// </summary>
        public static ElectricCurrentGradient FromAmperesPerMicrosecond(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMicrosecond);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerMillisecond"/>.
        /// </summary>
        public static ElectricCurrentGradient FromAmperesPerMillisecond(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMillisecond);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerMinute"/>.
        /// </summary>
        public static ElectricCurrentGradient FromAmperesPerMinute(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMinute);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerNanosecond"/>.
        /// </summary>
        public static ElectricCurrentGradient FromAmperesPerNanosecond(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerNanosecond);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerSecond"/>.
        /// </summary>
        public static ElectricCurrentGradient FromAmperesPerSecond(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerSecond);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.MilliamperePerMinute"/>.
        /// </summary>
        public static ElectricCurrentGradient FromMilliamperesPerMinute(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.MilliamperePerMinute);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.MilliamperePerSecond"/>.
        /// </summary>
        public static ElectricCurrentGradient FromMilliamperesPerSecond(QuantityValue value)
        {
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.MilliamperePerSecond);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricCurrentGradientUnit" /> to <see cref="ElectricCurrentGradient" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCurrentGradient unit value.</returns>
        public static ElectricCurrentGradient From(QuantityValue value, ElectricCurrentGradientUnit fromUnit)
        {
            return new ElectricCurrentGradient(value, fromUnit);
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
        public static ElectricCurrentGradient Parse(string str)
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
        public static ElectricCurrentGradient Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<ElectricCurrentGradient, ElectricCurrentGradientUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out ElectricCurrentGradient result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out ElectricCurrentGradient result)
        {
            return QuantityParser.Default.TryParse<ElectricCurrentGradient, ElectricCurrentGradientUnit>(str, provider, From, out result);
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
        public static ElectricCurrentGradientUnit ParseUnit(string str)
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
        public static ElectricCurrentGradientUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.ElectricCurrentGradientUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out ElectricCurrentGradientUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out ElectricCurrentGradientUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static ElectricCurrentGradient operator -(ElectricCurrentGradient right)
        {
            return new ElectricCurrentGradient(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrentGradient"/> from adding two <see cref="ElectricCurrentGradient"/>.</summary>
        public static ElectricCurrentGradient operator +(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return new ElectricCurrentGradient(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrentGradient"/> from subtracting two <see cref="ElectricCurrentGradient"/>.</summary>
        public static ElectricCurrentGradient operator -(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return new ElectricCurrentGradient(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrentGradient"/> from multiplying value and <see cref="ElectricCurrentGradient"/>.</summary>
        public static ElectricCurrentGradient operator *(QuantityValue left, ElectricCurrentGradient right)
        {
            return new ElectricCurrentGradient(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrentGradient"/> from multiplying value and <see cref="ElectricCurrentGradient"/>.</summary>
        public static ElectricCurrentGradient operator *(ElectricCurrentGradient left, QuantityValue right)
        {
            return new ElectricCurrentGradient(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrentGradient"/> from dividing <see cref="ElectricCurrentGradient"/> by value.</summary>
        public static ElectricCurrentGradient operator /(ElectricCurrentGradient left, QuantityValue right)
        {
            return new ElectricCurrentGradient(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="ElectricCurrentGradient"/> by <see cref="ElectricCurrentGradient"/>.</summary>
        public static QuantityValue operator /(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return left.AmperesPerSecond / right.AmperesPerSecond;
        }

        #endregion

        #region Relational Operators

        /// <summary>Get <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentGradient"/> * <see cref="Duration"/>.</summary>
        public static ElectricCurrent operator *(ElectricCurrentGradient electricCurrentGradient, Duration duration)
        {
            return ElectricCurrent.FromAmperes(electricCurrentGradient.AmperesPerSecond * duration.Seconds);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="ElectricCurrentGradient"/> quantities.</summary>
        public static bool operator ==(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="ElectricCurrentGradient"/> quantities.</summary>
        public static bool operator !=(ElectricCurrentGradient left, ElectricCurrentGradient right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="ElectricCurrentGradient"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not ElectricCurrentGradient otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="ElectricCurrentGradient"/> quantities.</summary>
        public bool Equals(ElectricCurrentGradient other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current ElectricCurrentGradient.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(ElectricCurrentGradient), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(ElectricCurrentGradient)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not ElectricCurrentGradient otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<ElectricCurrentGradient>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="ElectricCurrentGradient"/> with another <see cref="ElectricCurrentGradient"/> and returns an integer that indicates
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
        public int CompareTo(ElectricCurrentGradient other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<ElectricCurrentGradientUnit> IQuantity<ElectricCurrentGradientUnit>.ToUnit(ElectricCurrentGradientUnit unit) => this.ToUnit(unit);

        IQuantity<ElectricCurrentGradientUnit> IQuantity<ElectricCurrentGradientUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
