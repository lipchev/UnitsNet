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
    ///     A geometric property of an area that reflects how its points are distributed with regard to an axis.
    /// </summary>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct AreaMomentOfInertia :
        IArithmeticQuantity<AreaMomentOfInertia, AreaMomentOfInertiaUnit>,
#if NET7_0_OR_GREATER
        IDivisionOperators<AreaMomentOfInertia, Volume, Length>,
        IDivisionOperators<AreaMomentOfInertia, Length, Volume>,
#endif
#if NET7_0_OR_GREATER
        IComparisonOperators<AreaMomentOfInertia, AreaMomentOfInertia, bool>,
        IParsable<AreaMomentOfInertia>,
#endif
        IComparable,
        IComparable<AreaMomentOfInertia>,
        IEquatable<AreaMomentOfInertia>,
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
        private readonly AreaMomentOfInertiaUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="AreaMomentOfInertia"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class AreaMomentOfInertiaInfo: QuantityInfo<AreaMomentOfInertia, AreaMomentOfInertiaUnit>
        {
            /// <inheritdoc />
            public AreaMomentOfInertiaInfo(string name, AreaMomentOfInertiaUnit baseUnit, IEnumerable<IUnitDefinition<AreaMomentOfInertiaUnit>> unitMappings, AreaMomentOfInertia zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<AreaMomentOfInertia, AreaMomentOfInertiaUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public AreaMomentOfInertiaInfo(string name, AreaMomentOfInertiaUnit baseUnit, IEnumerable<IUnitDefinition<AreaMomentOfInertiaUnit>> unitMappings, AreaMomentOfInertia zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, AreaMomentOfInertia.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.AreaMomentOfInertia", typeof(AreaMomentOfInertia).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="AreaMomentOfInertiaInfo"/> class with the default settings for the AreaMomentOfInertia quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="AreaMomentOfInertiaInfo"/> class with the default settings.</returns>
            public static AreaMomentOfInertiaInfo CreateDefault()
            {
                return new AreaMomentOfInertiaInfo(nameof(AreaMomentOfInertia), DefaultBaseUnit, GetDefaultMappings(), new AreaMomentOfInertia(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="AreaMomentOfInertiaInfo"/> class with the default settings for the AreaMomentOfInertia quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="AreaMomentOfInertiaInfo"/> class with the default settings.
            /// </returns>
            public static AreaMomentOfInertiaInfo CreateDefault(Func<IEnumerable<UnitDefinition<AreaMomentOfInertiaUnit>>, IEnumerable<IUnitDefinition<AreaMomentOfInertiaUnit>>> customizeUnits)
            {
                return new AreaMomentOfInertiaInfo(nameof(AreaMomentOfInertia), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new AreaMomentOfInertia(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="AreaMomentOfInertia"/> is L^4.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(4, 0, 0, 0, 0, 0, 0);

            /// <summary>
            ///     The default base unit of AreaMomentOfInertia is MeterToTheFourth. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static AreaMomentOfInertiaUnit DefaultBaseUnit { get; } = AreaMomentOfInertiaUnit.MeterToTheFourth;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="AreaMomentOfInertiaUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{AreaMomentOfInertiaUnit}"/> representing the default unit mappings for AreaMomentOfInertia.</returns>
            public static IEnumerable<UnitDefinition<AreaMomentOfInertiaUnit>> GetDefaultMappings()
            {
                yield return new (AreaMomentOfInertiaUnit.CentimeterToTheFourth, "CentimeterToTheFourth", "CentimetersToTheFourth", new BaseUnits(length: LengthUnit.Centimeter),
                     100000000             
                );
                yield return new (AreaMomentOfInertiaUnit.DecimeterToTheFourth, "DecimeterToTheFourth", "DecimetersToTheFourth", new BaseUnits(length: LengthUnit.Decimeter),
                     10000             
                );
                yield return new (AreaMomentOfInertiaUnit.FootToTheFourth, "FootToTheFourth", "FeetToTheFourth", new BaseUnits(length: LengthUnit.Foot),
                     new QuantityValue(2441406250000, 21071715921)             
                );
                yield return new (AreaMomentOfInertiaUnit.InchToTheFourth, "InchToTheFourth", "InchesToTheFourth", new BaseUnits(length: LengthUnit.Inch),
                     new QuantityValue(625000000000000, 260144641)             
                );
                yield return new (AreaMomentOfInertiaUnit.MeterToTheFourth, "MeterToTheFourth", "MetersToTheFourth", new BaseUnits(length: LengthUnit.Meter));
                yield return new (AreaMomentOfInertiaUnit.MillimeterToTheFourth, "MillimeterToTheFourth", "MillimetersToTheFourth", new BaseUnits(length: LengthUnit.Millimeter),
                     1000000000000             
                );
            }
        }

        static AreaMomentOfInertia()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(AreaMomentOfInertiaInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public AreaMomentOfInertia(QuantityValue value, AreaMomentOfInertiaUnit unit)
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
        public AreaMomentOfInertia(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="AreaMomentOfInertia" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<AreaMomentOfInertia, AreaMomentOfInertiaUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of AreaMomentOfInertia, which is MeterToTheFourth. All conversions go via this value.
        /// </summary>
        public static AreaMomentOfInertiaUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the AreaMomentOfInertia quantity.
        /// </summary>
        public static IReadOnlyCollection<AreaMomentOfInertiaUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit MeterToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public AreaMomentOfInertiaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<AreaMomentOfInertia, AreaMomentOfInertiaUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => AreaMomentOfInertia.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<AreaMomentOfInertiaUnit> IQuantity<AreaMomentOfInertiaUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<AreaMomentOfInertia> IQuantityInstance<AreaMomentOfInertia>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="AreaMomentOfInertiaUnit.CentimeterToTheFourth"/>
        /// </summary>
        public QuantityValue CentimetersToTheFourth => this.As(AreaMomentOfInertiaUnit.CentimeterToTheFourth);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="AreaMomentOfInertiaUnit.DecimeterToTheFourth"/>
        /// </summary>
        public QuantityValue DecimetersToTheFourth => this.As(AreaMomentOfInertiaUnit.DecimeterToTheFourth);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="AreaMomentOfInertiaUnit.FootToTheFourth"/>
        /// </summary>
        public QuantityValue FeetToTheFourth => this.As(AreaMomentOfInertiaUnit.FootToTheFourth);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="AreaMomentOfInertiaUnit.InchToTheFourth"/>
        /// </summary>
        public QuantityValue InchesToTheFourth => this.As(AreaMomentOfInertiaUnit.InchToTheFourth);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="AreaMomentOfInertiaUnit.MeterToTheFourth"/>
        /// </summary>
        public QuantityValue MetersToTheFourth => this.As(AreaMomentOfInertiaUnit.MeterToTheFourth);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="AreaMomentOfInertiaUnit.MillimeterToTheFourth"/>
        /// </summary>
        public QuantityValue MillimetersToTheFourth => this.As(AreaMomentOfInertiaUnit.MillimeterToTheFourth);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(AreaMomentOfInertiaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(AreaMomentOfInertiaUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.CentimeterToTheFourth"/>.
        /// </summary>
        public static AreaMomentOfInertia FromCentimetersToTheFourth(QuantityValue value)
        {
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.CentimeterToTheFourth);
        }

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.DecimeterToTheFourth"/>.
        /// </summary>
        public static AreaMomentOfInertia FromDecimetersToTheFourth(QuantityValue value)
        {
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.DecimeterToTheFourth);
        }

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.FootToTheFourth"/>.
        /// </summary>
        public static AreaMomentOfInertia FromFeetToTheFourth(QuantityValue value)
        {
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.FootToTheFourth);
        }

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.InchToTheFourth"/>.
        /// </summary>
        public static AreaMomentOfInertia FromInchesToTheFourth(QuantityValue value)
        {
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.InchToTheFourth);
        }

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.MeterToTheFourth"/>.
        /// </summary>
        public static AreaMomentOfInertia FromMetersToTheFourth(QuantityValue value)
        {
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.MeterToTheFourth);
        }

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.MillimeterToTheFourth"/>.
        /// </summary>
        public static AreaMomentOfInertia FromMillimetersToTheFourth(QuantityValue value)
        {
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.MillimeterToTheFourth);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AreaMomentOfInertiaUnit" /> to <see cref="AreaMomentOfInertia" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AreaMomentOfInertia unit value.</returns>
        public static AreaMomentOfInertia From(QuantityValue value, AreaMomentOfInertiaUnit fromUnit)
        {
            return new AreaMomentOfInertia(value, fromUnit);
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
        public static AreaMomentOfInertia Parse(string str)
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
        public static AreaMomentOfInertia Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<AreaMomentOfInertia, AreaMomentOfInertiaUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out AreaMomentOfInertia result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out AreaMomentOfInertia result)
        {
            return QuantityParser.Default.TryParse<AreaMomentOfInertia, AreaMomentOfInertiaUnit>(str, provider, From, out result);
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
        public static AreaMomentOfInertiaUnit ParseUnit(string str)
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
        public static AreaMomentOfInertiaUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.AreaMomentOfInertiaUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out AreaMomentOfInertiaUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out AreaMomentOfInertiaUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static AreaMomentOfInertia operator -(AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="AreaMomentOfInertia"/> from adding two <see cref="AreaMomentOfInertia"/>.</summary>
        public static AreaMomentOfInertia operator +(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="AreaMomentOfInertia"/> from subtracting two <see cref="AreaMomentOfInertia"/>.</summary>
        public static AreaMomentOfInertia operator -(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="AreaMomentOfInertia"/> from multiplying value and <see cref="AreaMomentOfInertia"/>.</summary>
        public static AreaMomentOfInertia operator *(QuantityValue left, AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="AreaMomentOfInertia"/> from multiplying value and <see cref="AreaMomentOfInertia"/>.</summary>
        public static AreaMomentOfInertia operator *(AreaMomentOfInertia left, QuantityValue right)
        {
            return new AreaMomentOfInertia(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="AreaMomentOfInertia"/> from dividing <see cref="AreaMomentOfInertia"/> by value.</summary>
        public static AreaMomentOfInertia operator /(AreaMomentOfInertia left, QuantityValue right)
        {
            return new AreaMomentOfInertia(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="AreaMomentOfInertia"/> by <see cref="AreaMomentOfInertia"/>.</summary>
        public static QuantityValue operator /(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.MetersToTheFourth / right.MetersToTheFourth;
        }

        #endregion

        #region Relational Operators

        /// <summary>Get <see cref="Length"/> from <see cref="AreaMomentOfInertia"/> / <see cref="Volume"/>.</summary>
        public static Length operator /(AreaMomentOfInertia areaMomentOfInertia, Volume volume)
        {
            return Length.FromMeters(areaMomentOfInertia.MetersToTheFourth / volume.CubicMeters);
        }

        /// <summary>Get <see cref="Volume"/> from <see cref="AreaMomentOfInertia"/> / <see cref="Length"/>.</summary>
        public static Volume operator /(AreaMomentOfInertia areaMomentOfInertia, Length length)
        {
            return Volume.FromCubicMeters(areaMomentOfInertia.MetersToTheFourth / length.Meters);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="AreaMomentOfInertia"/> quantities.</summary>
        public static bool operator ==(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="AreaMomentOfInertia"/> quantities.</summary>
        public static bool operator !=(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="AreaMomentOfInertia"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not AreaMomentOfInertia otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="AreaMomentOfInertia"/> quantities.</summary>
        public bool Equals(AreaMomentOfInertia other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current AreaMomentOfInertia.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(AreaMomentOfInertia), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(AreaMomentOfInertia)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not AreaMomentOfInertia otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<AreaMomentOfInertia>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="AreaMomentOfInertia"/> with another <see cref="AreaMomentOfInertia"/> and returns an integer that indicates
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
        public int CompareTo(AreaMomentOfInertia other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<AreaMomentOfInertiaUnit> IQuantity<AreaMomentOfInertiaUnit>.ToUnit(AreaMomentOfInertiaUnit unit) => this.ToUnit(unit);

        IQuantity<AreaMomentOfInertiaUnit> IQuantity<AreaMomentOfInertiaUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
