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
    ///     Difference between two temperatures. The conversions are different than for Temperature.
    /// </summary>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct TemperatureDelta :
        IArithmeticQuantity<TemperatureDelta, TemperatureDeltaUnit>,
#if NET7_0_OR_GREATER
        IDivisionOperators<TemperatureDelta, TemperatureChangeRate, Duration>,
        IMultiplyOperators<TemperatureDelta, Entropy, Energy>,
        IDivisionOperators<TemperatureDelta, TemperatureGradient, Length>,
        IMultiplyOperators<TemperatureDelta, CoefficientOfThermalExpansion, Ratio>,
        IMultiplyOperators<TemperatureDelta, SpecificEntropy, SpecificEnergy>,
        IDivisionOperators<TemperatureDelta, Duration, TemperatureChangeRate>,
        IDivisionOperators<TemperatureDelta, Length, TemperatureGradient>,
#endif
#if NET7_0_OR_GREATER
        IComparisonOperators<TemperatureDelta, TemperatureDelta, bool>,
        IParsable<TemperatureDelta>,
#endif
        IComparable,
        IComparable<TemperatureDelta>,
        IEquatable<TemperatureDelta>,
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
        private readonly TemperatureDeltaUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="TemperatureDelta"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class TemperatureDeltaInfo: QuantityInfo<TemperatureDelta, TemperatureDeltaUnit>
        {
            /// <inheritdoc />
            public TemperatureDeltaInfo(string name, TemperatureDeltaUnit baseUnit, IEnumerable<IUnitDefinition<TemperatureDeltaUnit>> unitMappings, TemperatureDelta zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<TemperatureDelta, TemperatureDeltaUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public TemperatureDeltaInfo(string name, TemperatureDeltaUnit baseUnit, IEnumerable<IUnitDefinition<TemperatureDeltaUnit>> unitMappings, TemperatureDelta zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, TemperatureDelta.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.TemperatureDelta", typeof(TemperatureDelta).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="TemperatureDeltaInfo"/> class with the default settings for the TemperatureDelta quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="TemperatureDeltaInfo"/> class with the default settings.</returns>
            public static TemperatureDeltaInfo CreateDefault()
            {
                return new TemperatureDeltaInfo(nameof(TemperatureDelta), DefaultBaseUnit, GetDefaultMappings(), new TemperatureDelta(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="TemperatureDeltaInfo"/> class with the default settings for the TemperatureDelta quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="TemperatureDeltaInfo"/> class with the default settings.
            /// </returns>
            public static TemperatureDeltaInfo CreateDefault(Func<IEnumerable<UnitDefinition<TemperatureDeltaUnit>>, IEnumerable<IUnitDefinition<TemperatureDeltaUnit>>> customizeUnits)
            {
                return new TemperatureDeltaInfo(nameof(TemperatureDelta), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new TemperatureDelta(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="TemperatureDelta"/> is Θ.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(0, 0, 0, 0, 1, 0, 0);

            /// <summary>
            ///     The default base unit of TemperatureDelta is Kelvin. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static TemperatureDeltaUnit DefaultBaseUnit { get; } = TemperatureDeltaUnit.Kelvin;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="TemperatureDeltaUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{TemperatureDeltaUnit}"/> representing the default unit mappings for TemperatureDelta.</returns>
            public static IEnumerable<UnitDefinition<TemperatureDeltaUnit>> GetDefaultMappings()
            {
                yield return new (TemperatureDeltaUnit.DegreeCelsius, "DegreeCelsius", "DegreesCelsius", new BaseUnits(temperature: TemperatureUnit.DegreeCelsius),
                     1             
                );
                yield return new (TemperatureDeltaUnit.DegreeDelisle, "DegreeDelisle", "DegreesDelisle", new BaseUnits(temperature: TemperatureUnit.DegreeDelisle),
                     new QuantityValue(-3, 2)             
                );
                yield return new (TemperatureDeltaUnit.DegreeFahrenheit, "DegreeFahrenheit", "DegreesFahrenheit", new BaseUnits(temperature: TemperatureUnit.DegreeFahrenheit),
                     new QuantityValue(9, 5)             
                );
                yield return new (TemperatureDeltaUnit.DegreeNewton, "DegreeNewton", "DegreesNewton", new BaseUnits(temperature: TemperatureUnit.DegreeNewton),
                     new QuantityValue(33, 100)             
                );
                yield return new (TemperatureDeltaUnit.DegreeRankine, "DegreeRankine", "DegreesRankine", new BaseUnits(temperature: TemperatureUnit.DegreeRankine),
                     new QuantityValue(9, 5)             
                );
                yield return new (TemperatureDeltaUnit.DegreeReaumur, "DegreeReaumur", "DegreesReaumur", new BaseUnits(temperature: TemperatureUnit.DegreeReaumur),
                     new QuantityValue(4, 5)             
                );
                yield return new (TemperatureDeltaUnit.DegreeRoemer, "DegreeRoemer", "DegreesRoemer", new BaseUnits(temperature: TemperatureUnit.DegreeRoemer),
                     new QuantityValue(21, 40)             
                );
                yield return new (TemperatureDeltaUnit.Kelvin, "Kelvin", "Kelvins", new BaseUnits(temperature: TemperatureUnit.Kelvin));
                yield return new (TemperatureDeltaUnit.MillidegreeCelsius, "MillidegreeCelsius", "MillidegreesCelsius", BaseUnits.Undefined,
                     1000             
                );
            }
        }

        static TemperatureDelta()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(TemperatureDeltaInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public TemperatureDelta(QuantityValue value, TemperatureDeltaUnit unit)
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
        public TemperatureDelta(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="TemperatureDelta" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<TemperatureDelta, TemperatureDeltaUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of TemperatureDelta, which is Kelvin. All conversions go via this value.
        /// </summary>
        public static TemperatureDeltaUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the TemperatureDelta quantity.
        /// </summary>
        public static IReadOnlyCollection<TemperatureDeltaUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Kelvin.
        /// </summary>
        public static TemperatureDelta Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public TemperatureDeltaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<TemperatureDelta, TemperatureDeltaUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => TemperatureDelta.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<TemperatureDeltaUnit> IQuantity<TemperatureDeltaUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<TemperatureDelta> IQuantityInstance<TemperatureDelta>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeCelsius"/>
        /// </summary>
        public QuantityValue DegreesCelsius => this.As(TemperatureDeltaUnit.DegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeDelisle"/>
        /// </summary>
        public QuantityValue DegreesDelisle => this.As(TemperatureDeltaUnit.DegreeDelisle);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeFahrenheit"/>
        /// </summary>
        public QuantityValue DegreesFahrenheit => this.As(TemperatureDeltaUnit.DegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeNewton"/>
        /// </summary>
        public QuantityValue DegreesNewton => this.As(TemperatureDeltaUnit.DegreeNewton);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeRankine"/>
        /// </summary>
        public QuantityValue DegreesRankine => this.As(TemperatureDeltaUnit.DegreeRankine);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeReaumur"/>
        /// </summary>
        public QuantityValue DegreesReaumur => this.As(TemperatureDeltaUnit.DegreeReaumur);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeRoemer"/>
        /// </summary>
        public QuantityValue DegreesRoemer => this.As(TemperatureDeltaUnit.DegreeRoemer);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.Kelvin"/>
        /// </summary>
        public QuantityValue Kelvins => this.As(TemperatureDeltaUnit.Kelvin);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.MillidegreeCelsius"/>
        /// </summary>
        public QuantityValue MillidegreesCelsius => this.As(TemperatureDeltaUnit.MillidegreeCelsius);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(TemperatureDeltaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(TemperatureDeltaUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeCelsius"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesCelsius(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeCelsius);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeDelisle"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesDelisle(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeDelisle);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeFahrenheit"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesFahrenheit(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeFahrenheit);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeNewton"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesNewton(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeNewton);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeRankine"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesRankine(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeRankine);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeReaumur"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesReaumur(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeReaumur);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeRoemer"/>.
        /// </summary>
        public static TemperatureDelta FromDegreesRoemer(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeRoemer);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.Kelvin"/>.
        /// </summary>
        public static TemperatureDelta FromKelvins(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.Kelvin);
        }

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.MillidegreeCelsius"/>.
        /// </summary>
        public static TemperatureDelta FromMillidegreesCelsius(QuantityValue value)
        {
            return new TemperatureDelta(value, TemperatureDeltaUnit.MillidegreeCelsius);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureDeltaUnit" /> to <see cref="TemperatureDelta" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureDelta unit value.</returns>
        public static TemperatureDelta From(QuantityValue value, TemperatureDeltaUnit fromUnit)
        {
            return new TemperatureDelta(value, fromUnit);
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
        public static TemperatureDelta Parse(string str)
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
        public static TemperatureDelta Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<TemperatureDelta, TemperatureDeltaUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out TemperatureDelta result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out TemperatureDelta result)
        {
            return QuantityParser.Default.TryParse<TemperatureDelta, TemperatureDeltaUnit>(str, provider, From, out result);
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
        public static TemperatureDeltaUnit ParseUnit(string str)
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
        public static TemperatureDeltaUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.TemperatureDeltaUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out TemperatureDeltaUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out TemperatureDeltaUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static TemperatureDelta operator -(TemperatureDelta right)
        {
            return new TemperatureDelta(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="TemperatureDelta"/> from adding two <see cref="TemperatureDelta"/>.</summary>
        public static TemperatureDelta operator +(TemperatureDelta left, TemperatureDelta right)
        {
            return new TemperatureDelta(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="TemperatureDelta"/> from subtracting two <see cref="TemperatureDelta"/>.</summary>
        public static TemperatureDelta operator -(TemperatureDelta left, TemperatureDelta right)
        {
            return new TemperatureDelta(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="TemperatureDelta"/> from multiplying value and <see cref="TemperatureDelta"/>.</summary>
        public static TemperatureDelta operator *(QuantityValue left, TemperatureDelta right)
        {
            return new TemperatureDelta(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="TemperatureDelta"/> from multiplying value and <see cref="TemperatureDelta"/>.</summary>
        public static TemperatureDelta operator *(TemperatureDelta left, QuantityValue right)
        {
            return new TemperatureDelta(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="TemperatureDelta"/> from dividing <see cref="TemperatureDelta"/> by value.</summary>
        public static TemperatureDelta operator /(TemperatureDelta left, QuantityValue right)
        {
            return new TemperatureDelta(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="TemperatureDelta"/> by <see cref="TemperatureDelta"/>.</summary>
        public static QuantityValue operator /(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Kelvins / right.Kelvins;
        }

        #endregion

        #region Relational Operators

        /// <summary>Get <see cref="Duration"/> from <see cref="TemperatureDelta"/> / <see cref="TemperatureChangeRate"/>.</summary>
        public static Duration operator /(TemperatureDelta temperatureDelta, TemperatureChangeRate temperatureChangeRate)
        {
            return Duration.FromSeconds(temperatureDelta.DegreesCelsius / temperatureChangeRate.DegreesCelsiusPerSecond);
        }

        /// <summary>Get <see cref="Energy"/> from <see cref="TemperatureDelta"/> * <see cref="Entropy"/>.</summary>
        public static Energy operator *(TemperatureDelta temperatureDelta, Entropy entropy)
        {
            return Energy.FromJoules(temperatureDelta.Kelvins * entropy.JoulesPerKelvin);
        }

        /// <summary>Get <see cref="Length"/> from <see cref="TemperatureDelta"/> / <see cref="TemperatureGradient"/>.</summary>
        public static Length operator /(TemperatureDelta temperatureDelta, TemperatureGradient temperatureGradient)
        {
            return Length.FromKilometers(temperatureDelta.DegreesCelsius / temperatureGradient.DegreesCelsiusPerKilometer);
        }

        /// <summary>Get <see cref="Ratio"/> from <see cref="TemperatureDelta"/> * <see cref="CoefficientOfThermalExpansion"/>.</summary>
        public static Ratio operator *(TemperatureDelta temperatureDelta, CoefficientOfThermalExpansion coefficientOfThermalExpansion)
        {
            return Ratio.FromDecimalFractions(temperatureDelta.Kelvins * coefficientOfThermalExpansion.PerKelvin);
        }

        /// <summary>Get <see cref="SpecificEnergy"/> from <see cref="TemperatureDelta"/> * <see cref="SpecificEntropy"/>.</summary>
        public static SpecificEnergy operator *(TemperatureDelta temperatureDelta, SpecificEntropy specificEntropy)
        {
            return SpecificEnergy.FromJoulesPerKilogram(temperatureDelta.Kelvins * specificEntropy.JoulesPerKilogramKelvin);
        }

        /// <summary>Get <see cref="TemperatureChangeRate"/> from <see cref="TemperatureDelta"/> / <see cref="Duration"/>.</summary>
        public static TemperatureChangeRate operator /(TemperatureDelta temperatureDelta, Duration duration)
        {
            return TemperatureChangeRate.FromDegreesCelsiusPerSecond(temperatureDelta.DegreesCelsius / duration.Seconds);
        }

        /// <summary>Get <see cref="TemperatureGradient"/> from <see cref="TemperatureDelta"/> / <see cref="Length"/>.</summary>
        public static TemperatureGradient operator /(TemperatureDelta temperatureDelta, Length length)
        {
            return TemperatureGradient.FromDegreesCelsiusPerKilometer(temperatureDelta.DegreesCelsius / length.Kilometers);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="TemperatureDelta"/> quantities.</summary>
        public static bool operator ==(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="TemperatureDelta"/> quantities.</summary>
        public static bool operator !=(TemperatureDelta left, TemperatureDelta right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="TemperatureDelta"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not TemperatureDelta otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="TemperatureDelta"/> quantities.</summary>
        public bool Equals(TemperatureDelta other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current TemperatureDelta.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(TemperatureDelta), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(TemperatureDelta)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not TemperatureDelta otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<TemperatureDelta>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="TemperatureDelta"/> with another <see cref="TemperatureDelta"/> and returns an integer that indicates
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
        public int CompareTo(TemperatureDelta other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<TemperatureDeltaUnit> IQuantity<TemperatureDeltaUnit>.ToUnit(TemperatureDeltaUnit unit) => this.ToUnit(unit);

        IQuantity<TemperatureDeltaUnit> IQuantity<TemperatureDeltaUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
