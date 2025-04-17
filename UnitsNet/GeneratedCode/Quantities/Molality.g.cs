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
    ///     Molality is a measure of the amount of solute in a solution relative to a given mass of solvent.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Molality
    /// </remarks>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct Molality :
        IArithmeticQuantity<Molality, MolalityUnit>,
#if NET7_0_OR_GREATER
        IComparisonOperators<Molality, Molality, bool>,
        IParsable<Molality>,
#endif
        IComparable,
        IComparable<Molality>,
        IEquatable<Molality>,
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
        private readonly MolalityUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="Molality"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class MolalityInfo: QuantityInfo<Molality, MolalityUnit>
        {
            /// <inheritdoc />
            public MolalityInfo(string name, MolalityUnit baseUnit, IEnumerable<IUnitDefinition<MolalityUnit>> unitMappings, Molality zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<Molality, MolalityUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public MolalityInfo(string name, MolalityUnit baseUnit, IEnumerable<IUnitDefinition<MolalityUnit>> unitMappings, Molality zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, Molality.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.Molality", typeof(Molality).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="MolalityInfo"/> class with the default settings for the Molality quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="MolalityInfo"/> class with the default settings.</returns>
            public static MolalityInfo CreateDefault()
            {
                return new MolalityInfo(nameof(Molality), DefaultBaseUnit, GetDefaultMappings(), new Molality(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="MolalityInfo"/> class with the default settings for the Molality quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="MolalityInfo"/> class with the default settings.
            /// </returns>
            public static MolalityInfo CreateDefault(Func<IEnumerable<UnitDefinition<MolalityUnit>>, IEnumerable<IUnitDefinition<MolalityUnit>>> customizeUnits)
            {
                return new MolalityInfo(nameof(Molality), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new Molality(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="Molality"/> is M^-1N.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(0, -1, 0, 0, 0, 1, 0);

            /// <summary>
            ///     The default base unit of Molality is MolePerKilogram. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static MolalityUnit DefaultBaseUnit { get; } = MolalityUnit.MolePerKilogram;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="MolalityUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{MolalityUnit}"/> representing the default unit mappings for Molality.</returns>
            public static IEnumerable<UnitDefinition<MolalityUnit>> GetDefaultMappings()
            {
                yield return new (MolalityUnit.MillimolePerKilogram, "MillimolePerKilogram", "MillimolesPerKilogram", new BaseUnits(mass: MassUnit.Kilogram, amount: AmountOfSubstanceUnit.Millimole),
                     1000             
                );
                yield return new (MolalityUnit.MolePerGram, "MolePerGram", "MolesPerGram", new BaseUnits(mass: MassUnit.Gram, amount: AmountOfSubstanceUnit.Mole),
                     new QuantityValue(1, 1000)             
                );
                yield return new (MolalityUnit.MolePerKilogram, "MolePerKilogram", "MolesPerKilogram", new BaseUnits(mass: MassUnit.Kilogram, amount: AmountOfSubstanceUnit.Mole));
            }
        }

        static Molality()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(MolalityInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Molality(QuantityValue value, MolalityUnit unit)
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
        public Molality(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="Molality" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<Molality, MolalityUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of Molality, which is MolePerKilogram. All conversions go via this value.
        /// </summary>
        public static MolalityUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the Molality quantity.
        /// </summary>
        public static IReadOnlyCollection<MolalityUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit MolePerKilogram.
        /// </summary>
        public static Molality Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public MolalityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<Molality, MolalityUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Molality.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<MolalityUnit> IQuantity<MolalityUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<Molality> IQuantityInstance<Molality>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="MolalityUnit.MillimolePerKilogram"/>
        /// </summary>
        public QuantityValue MillimolesPerKilogram => this.As(MolalityUnit.MillimolePerKilogram);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="MolalityUnit.MolePerGram"/>
        /// </summary>
        public QuantityValue MolesPerGram => this.As(MolalityUnit.MolePerGram);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="MolalityUnit.MolePerKilogram"/>
        /// </summary>
        public QuantityValue MolesPerKilogram => this.As(MolalityUnit.MolePerKilogram);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(MolalityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(MolalityUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Molality"/> from <see cref="MolalityUnit.MillimolePerKilogram"/>.
        /// </summary>
        public static Molality FromMillimolesPerKilogram(QuantityValue value)
        {
            return new Molality(value, MolalityUnit.MillimolePerKilogram);
        }

        /// <summary>
        ///     Creates a <see cref="Molality"/> from <see cref="MolalityUnit.MolePerGram"/>.
        /// </summary>
        public static Molality FromMolesPerGram(QuantityValue value)
        {
            return new Molality(value, MolalityUnit.MolePerGram);
        }

        /// <summary>
        ///     Creates a <see cref="Molality"/> from <see cref="MolalityUnit.MolePerKilogram"/>.
        /// </summary>
        public static Molality FromMolesPerKilogram(QuantityValue value)
        {
            return new Molality(value, MolalityUnit.MolePerKilogram);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolalityUnit" /> to <see cref="Molality" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molality unit value.</returns>
        public static Molality From(QuantityValue value, MolalityUnit fromUnit)
        {
            return new Molality(value, fromUnit);
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
        public static Molality Parse(string str)
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
        public static Molality Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<Molality, MolalityUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out Molality result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out Molality result)
        {
            return QuantityParser.Default.TryParse<Molality, MolalityUnit>(str, provider, From, out result);
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
        public static MolalityUnit ParseUnit(string str)
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
        public static MolalityUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.MolalityUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out MolalityUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out MolalityUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static Molality operator -(Molality right)
        {
            return new Molality(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Molality"/> from adding two <see cref="Molality"/>.</summary>
        public static Molality operator +(Molality left, Molality right)
        {
            return new Molality(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Molality"/> from subtracting two <see cref="Molality"/>.</summary>
        public static Molality operator -(Molality left, Molality right)
        {
            return new Molality(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Molality"/> from multiplying value and <see cref="Molality"/>.</summary>
        public static Molality operator *(QuantityValue left, Molality right)
        {
            return new Molality(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Molality"/> from multiplying value and <see cref="Molality"/>.</summary>
        public static Molality operator *(Molality left, QuantityValue right)
        {
            return new Molality(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="Molality"/> from dividing <see cref="Molality"/> by value.</summary>
        public static Molality operator /(Molality left, QuantityValue right)
        {
            return new Molality(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="Molality"/> by <see cref="Molality"/>.</summary>
        public static QuantityValue operator /(Molality left, Molality right)
        {
            return left.MolesPerKilogram / right.MolesPerKilogram;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(Molality left, Molality right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(Molality left, Molality right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(Molality left, Molality right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(Molality left, Molality right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="Molality"/> quantities.</summary>
        public static bool operator ==(Molality left, Molality right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="Molality"/> quantities.</summary>
        public static bool operator !=(Molality left, Molality right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="Molality"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not Molality otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="Molality"/> quantities.</summary>
        public bool Equals(Molality other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Molality.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(Molality), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(Molality)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not Molality otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<Molality>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="Molality"/> with another <see cref="Molality"/> and returns an integer that indicates
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
        public int CompareTo(Molality other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<MolalityUnit> IQuantity<MolalityUnit>.ToUnit(MolalityUnit unit) => this.ToUnit(unit);

        IQuantity<MolalityUnit> IQuantity<MolalityUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
