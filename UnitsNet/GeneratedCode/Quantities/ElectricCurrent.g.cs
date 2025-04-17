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
    ///     An electric current is a flow of electric charge. In electric circuits this charge is often carried by moving electrons in a wire. It can also be carried by ions in an electrolyte, or by both ions and electrons such as in a plasma.
    /// </summary>
    /// <remarks>
    ///     If you want to map more parameters into the <c>ElectricCurrent</c> class (amps RMS, phase angle, etc.), create your own wrapper type such as a record or named tuple.
    /// </remarks>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct ElectricCurrent :
        IArithmeticQuantity<ElectricCurrent, ElectricCurrentUnit>,
#if NET7_0_OR_GREATER
        IDivisionOperators<ElectricCurrent, ElectricCurrentGradient, Duration>,
        IMultiplyOperators<ElectricCurrent, Duration, ElectricCharge>,
        IDivisionOperators<ElectricCurrent, Duration, ElectricCurrentGradient>,
        IMultiplyOperators<ElectricCurrent, ElectricResistance, ElectricPotential>,
        IMultiplyOperators<ElectricCurrent, ElectricPotential, Power>,
#endif
#if NET7_0_OR_GREATER
        IComparisonOperators<ElectricCurrent, ElectricCurrent, bool>,
        IParsable<ElectricCurrent>,
#endif
        IComparable,
        IComparable<ElectricCurrent>,
        IEquatable<ElectricCurrent>,
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
        private readonly ElectricCurrentUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="ElectricCurrent"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class ElectricCurrentInfo: QuantityInfo<ElectricCurrent, ElectricCurrentUnit>
        {
            /// <inheritdoc />
            public ElectricCurrentInfo(string name, ElectricCurrentUnit baseUnit, IEnumerable<IUnitDefinition<ElectricCurrentUnit>> unitMappings, ElectricCurrent zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<ElectricCurrent, ElectricCurrentUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public ElectricCurrentInfo(string name, ElectricCurrentUnit baseUnit, IEnumerable<IUnitDefinition<ElectricCurrentUnit>> unitMappings, ElectricCurrent zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, ElectricCurrent.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.ElectricCurrent", typeof(ElectricCurrent).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="ElectricCurrentInfo"/> class with the default settings for the ElectricCurrent quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="ElectricCurrentInfo"/> class with the default settings.</returns>
            public static ElectricCurrentInfo CreateDefault()
            {
                return new ElectricCurrentInfo(nameof(ElectricCurrent), DefaultBaseUnit, GetDefaultMappings(), new ElectricCurrent(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="ElectricCurrentInfo"/> class with the default settings for the ElectricCurrent quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="ElectricCurrentInfo"/> class with the default settings.
            /// </returns>
            public static ElectricCurrentInfo CreateDefault(Func<IEnumerable<UnitDefinition<ElectricCurrentUnit>>, IEnumerable<IUnitDefinition<ElectricCurrentUnit>>> customizeUnits)
            {
                return new ElectricCurrentInfo(nameof(ElectricCurrent), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new ElectricCurrent(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="ElectricCurrent"/> is I.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(0, 0, 0, 1, 0, 0, 0);

            /// <summary>
            ///     The default base unit of ElectricCurrent is Ampere. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static ElectricCurrentUnit DefaultBaseUnit { get; } = ElectricCurrentUnit.Ampere;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="ElectricCurrentUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{ElectricCurrentUnit}"/> representing the default unit mappings for ElectricCurrent.</returns>
            public static IEnumerable<UnitDefinition<ElectricCurrentUnit>> GetDefaultMappings()
            {
                yield return new (ElectricCurrentUnit.Ampere, "Ampere", "Amperes", new BaseUnits(current: ElectricCurrentUnit.Ampere));
                yield return new (ElectricCurrentUnit.Centiampere, "Centiampere", "Centiamperes", new BaseUnits(current: ElectricCurrentUnit.Centiampere),
                     100             
                );
                yield return new (ElectricCurrentUnit.Femtoampere, "Femtoampere", "Femtoamperes", new BaseUnits(current: ElectricCurrentUnit.Femtoampere),
                     1000000000000000             
                );
                yield return new (ElectricCurrentUnit.Kiloampere, "Kiloampere", "Kiloamperes", new BaseUnits(current: ElectricCurrentUnit.Kiloampere),
                     new QuantityValue(1, 1000)             
                );
                yield return new (ElectricCurrentUnit.Megaampere, "Megaampere", "Megaamperes", new BaseUnits(current: ElectricCurrentUnit.Megaampere),
                     new QuantityValue(1, 1000000)             
                );
                yield return new (ElectricCurrentUnit.Microampere, "Microampere", "Microamperes", new BaseUnits(current: ElectricCurrentUnit.Microampere),
                     1000000             
                );
                yield return new (ElectricCurrentUnit.Milliampere, "Milliampere", "Milliamperes", new BaseUnits(current: ElectricCurrentUnit.Milliampere),
                     1000             
                );
                yield return new (ElectricCurrentUnit.Nanoampere, "Nanoampere", "Nanoamperes", new BaseUnits(current: ElectricCurrentUnit.Nanoampere),
                     1000000000             
                );
                yield return new (ElectricCurrentUnit.Picoampere, "Picoampere", "Picoamperes", new BaseUnits(current: ElectricCurrentUnit.Picoampere),
                     1000000000000             
                );
            }
        }

        static ElectricCurrent()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(ElectricCurrentInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ElectricCurrent(QuantityValue value, ElectricCurrentUnit unit)
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
        public ElectricCurrent(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="ElectricCurrent" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<ElectricCurrent, ElectricCurrentUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of ElectricCurrent, which is Ampere. All conversions go via this value.
        /// </summary>
        public static ElectricCurrentUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the ElectricCurrent quantity.
        /// </summary>
        public static IReadOnlyCollection<ElectricCurrentUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Ampere.
        /// </summary>
        public static ElectricCurrent Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ElectricCurrentUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<ElectricCurrent, ElectricCurrentUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ElectricCurrent.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<ElectricCurrentUnit> IQuantity<ElectricCurrentUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<ElectricCurrent> IQuantityInstance<ElectricCurrent>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Ampere"/>
        /// </summary>
        public QuantityValue Amperes => this.As(ElectricCurrentUnit.Ampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Centiampere"/>
        /// </summary>
        public QuantityValue Centiamperes => this.As(ElectricCurrentUnit.Centiampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Femtoampere"/>
        /// </summary>
        public QuantityValue Femtoamperes => this.As(ElectricCurrentUnit.Femtoampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Kiloampere"/>
        /// </summary>
        public QuantityValue Kiloamperes => this.As(ElectricCurrentUnit.Kiloampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Megaampere"/>
        /// </summary>
        public QuantityValue Megaamperes => this.As(ElectricCurrentUnit.Megaampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Microampere"/>
        /// </summary>
        public QuantityValue Microamperes => this.As(ElectricCurrentUnit.Microampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Milliampere"/>
        /// </summary>
        public QuantityValue Milliamperes => this.As(ElectricCurrentUnit.Milliampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Nanoampere"/>
        /// </summary>
        public QuantityValue Nanoamperes => this.As(ElectricCurrentUnit.Nanoampere);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ElectricCurrentUnit.Picoampere"/>
        /// </summary>
        public QuantityValue Picoamperes => this.As(ElectricCurrentUnit.Picoampere);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ElectricCurrentUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(ElectricCurrentUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Ampere"/>.
        /// </summary>
        public static ElectricCurrent FromAmperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Ampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Centiampere"/>.
        /// </summary>
        public static ElectricCurrent FromCentiamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Centiampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Femtoampere"/>.
        /// </summary>
        public static ElectricCurrent FromFemtoamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Femtoampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Kiloampere"/>.
        /// </summary>
        public static ElectricCurrent FromKiloamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Kiloampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Megaampere"/>.
        /// </summary>
        public static ElectricCurrent FromMegaamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Megaampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Microampere"/>.
        /// </summary>
        public static ElectricCurrent FromMicroamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Microampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Milliampere"/>.
        /// </summary>
        public static ElectricCurrent FromMilliamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Milliampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Nanoampere"/>.
        /// </summary>
        public static ElectricCurrent FromNanoamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Nanoampere);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCurrent"/> from <see cref="ElectricCurrentUnit.Picoampere"/>.
        /// </summary>
        public static ElectricCurrent FromPicoamperes(QuantityValue value)
        {
            return new ElectricCurrent(value, ElectricCurrentUnit.Picoampere);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricCurrentUnit" /> to <see cref="ElectricCurrent" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCurrent unit value.</returns>
        public static ElectricCurrent From(QuantityValue value, ElectricCurrentUnit fromUnit)
        {
            return new ElectricCurrent(value, fromUnit);
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
        public static ElectricCurrent Parse(string str)
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
        public static ElectricCurrent Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<ElectricCurrent, ElectricCurrentUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out ElectricCurrent result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out ElectricCurrent result)
        {
            return QuantityParser.Default.TryParse<ElectricCurrent, ElectricCurrentUnit>(str, provider, From, out result);
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
        public static ElectricCurrentUnit ParseUnit(string str)
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
        public static ElectricCurrentUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.ElectricCurrentUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out ElectricCurrentUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out ElectricCurrentUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static ElectricCurrent operator -(ElectricCurrent right)
        {
            return new ElectricCurrent(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrent"/> from adding two <see cref="ElectricCurrent"/>.</summary>
        public static ElectricCurrent operator +(ElectricCurrent left, ElectricCurrent right)
        {
            return new ElectricCurrent(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrent"/> from subtracting two <see cref="ElectricCurrent"/>.</summary>
        public static ElectricCurrent operator -(ElectricCurrent left, ElectricCurrent right)
        {
            return new ElectricCurrent(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrent"/> from multiplying value and <see cref="ElectricCurrent"/>.</summary>
        public static ElectricCurrent operator *(QuantityValue left, ElectricCurrent right)
        {
            return new ElectricCurrent(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrent"/> from multiplying value and <see cref="ElectricCurrent"/>.</summary>
        public static ElectricCurrent operator *(ElectricCurrent left, QuantityValue right)
        {
            return new ElectricCurrent(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="ElectricCurrent"/> from dividing <see cref="ElectricCurrent"/> by value.</summary>
        public static ElectricCurrent operator /(ElectricCurrent left, QuantityValue right)
        {
            return new ElectricCurrent(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="ElectricCurrent"/> by <see cref="ElectricCurrent"/>.</summary>
        public static QuantityValue operator /(ElectricCurrent left, ElectricCurrent right)
        {
            return left.Amperes / right.Amperes;
        }

        #endregion

        #region Relational Operators

        /// <summary>Get <see cref="Duration"/> from <see cref="ElectricCurrent"/> / <see cref="ElectricCurrentGradient"/>.</summary>
        public static Duration operator /(ElectricCurrent electricCurrent, ElectricCurrentGradient electricCurrentGradient)
        {
            return Duration.FromSeconds(electricCurrent.Amperes / electricCurrentGradient.AmperesPerSecond);
        }

        /// <summary>Get <see cref="ElectricCharge"/> from <see cref="ElectricCurrent"/> * <see cref="Duration"/>.</summary>
        public static ElectricCharge operator *(ElectricCurrent electricCurrent, Duration duration)
        {
            return ElectricCharge.FromAmpereHours(electricCurrent.Amperes * duration.Hours);
        }

        /// <summary>Get <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrent"/> / <see cref="Duration"/>.</summary>
        public static ElectricCurrentGradient operator /(ElectricCurrent electricCurrent, Duration duration)
        {
            return ElectricCurrentGradient.FromAmperesPerSecond(electricCurrent.Amperes / duration.Seconds);
        }

        /// <summary>Get <see cref="ElectricPotential"/> from <see cref="ElectricCurrent"/> * <see cref="ElectricResistance"/>.</summary>
        public static ElectricPotential operator *(ElectricCurrent electricCurrent, ElectricResistance electricResistance)
        {
            return ElectricPotential.FromVolts(electricCurrent.Amperes * electricResistance.Ohms);
        }

        /// <summary>Get <see cref="Power"/> from <see cref="ElectricCurrent"/> * <see cref="ElectricPotential"/>.</summary>
        public static Power operator *(ElectricCurrent electricCurrent, ElectricPotential electricPotential)
        {
            return Power.FromWatts(electricCurrent.Amperes * electricPotential.Volts);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(ElectricCurrent left, ElectricCurrent right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(ElectricCurrent left, ElectricCurrent right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(ElectricCurrent left, ElectricCurrent right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(ElectricCurrent left, ElectricCurrent right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="ElectricCurrent"/> quantities.</summary>
        public static bool operator ==(ElectricCurrent left, ElectricCurrent right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="ElectricCurrent"/> quantities.</summary>
        public static bool operator !=(ElectricCurrent left, ElectricCurrent right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="ElectricCurrent"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not ElectricCurrent otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="ElectricCurrent"/> quantities.</summary>
        public bool Equals(ElectricCurrent other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current ElectricCurrent.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(ElectricCurrent), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(ElectricCurrent)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not ElectricCurrent otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<ElectricCurrent>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="ElectricCurrent"/> with another <see cref="ElectricCurrent"/> and returns an integer that indicates
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
        public int CompareTo(ElectricCurrent other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<ElectricCurrentUnit> IQuantity<ElectricCurrentUnit>.ToUnit(ElectricCurrentUnit unit) => this.ToUnit(unit);

        IQuantity<ElectricCurrentUnit> IQuantity<ElectricCurrentUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
