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
    ///     Reciprocal area (Inverse-square) quantity is used to specify a physical quantity inversely proportional to the square of the distance.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Inverse-square_law
    /// </remarks>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct ReciprocalArea :
        IArithmeticQuantity<ReciprocalArea, ReciprocalAreaUnit>,
#if NET7_0_OR_GREATER
        IMultiplyOperators<ReciprocalArea, Volume, Length>,
        IMultiplyOperators<ReciprocalArea, Force, Pressure>,
        IMultiplyOperators<ReciprocalArea, Area, Ratio>,
        IMultiplyOperators<ReciprocalArea, Length, ReciprocalLength>,
        IDivisionOperators<ReciprocalArea, ReciprocalLength, ReciprocalLength>,
#endif
#if NET7_0_OR_GREATER
        IComparisonOperators<ReciprocalArea, ReciprocalArea, bool>,
        IParsable<ReciprocalArea>,
#endif
        IComparable,
        IComparable<ReciprocalArea>,
        IEquatable<ReciprocalArea>,
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
        private readonly ReciprocalAreaUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="ReciprocalArea"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class ReciprocalAreaInfo: QuantityInfo<ReciprocalArea, ReciprocalAreaUnit>
        {
            /// <inheritdoc />
            public ReciprocalAreaInfo(string name, ReciprocalAreaUnit baseUnit, IEnumerable<IUnitDefinition<ReciprocalAreaUnit>> unitMappings, ReciprocalArea zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<ReciprocalArea, ReciprocalAreaUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public ReciprocalAreaInfo(string name, ReciprocalAreaUnit baseUnit, IEnumerable<IUnitDefinition<ReciprocalAreaUnit>> unitMappings, ReciprocalArea zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, ReciprocalArea.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.ReciprocalArea", typeof(ReciprocalArea).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="ReciprocalAreaInfo"/> class with the default settings for the ReciprocalArea quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="ReciprocalAreaInfo"/> class with the default settings.</returns>
            public static ReciprocalAreaInfo CreateDefault()
            {
                return new ReciprocalAreaInfo(nameof(ReciprocalArea), DefaultBaseUnit, GetDefaultMappings(), new ReciprocalArea(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="ReciprocalAreaInfo"/> class with the default settings for the ReciprocalArea quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="ReciprocalAreaInfo"/> class with the default settings.
            /// </returns>
            public static ReciprocalAreaInfo CreateDefault(Func<IEnumerable<UnitDefinition<ReciprocalAreaUnit>>, IEnumerable<IUnitDefinition<ReciprocalAreaUnit>>> customizeUnits)
            {
                return new ReciprocalAreaInfo(nameof(ReciprocalArea), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new ReciprocalArea(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="ReciprocalArea"/> is L^-2.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(-2, 0, 0, 0, 0, 0, 0);

            /// <summary>
            ///     The default base unit of ReciprocalArea is InverseSquareMeter. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static ReciprocalAreaUnit DefaultBaseUnit { get; } = ReciprocalAreaUnit.InverseSquareMeter;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="ReciprocalAreaUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{ReciprocalAreaUnit}"/> representing the default unit mappings for ReciprocalArea.</returns>
            public static IEnumerable<UnitDefinition<ReciprocalAreaUnit>> GetDefaultMappings()
            {
                yield return new (ReciprocalAreaUnit.InverseSquareCentimeter, "InverseSquareCentimeter", "InverseSquareCentimeters", new BaseUnits(length: LengthUnit.Centimeter),
                     new QuantityValue(1, 10000)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareDecimeter, "InverseSquareDecimeter", "InverseSquareDecimeters", new BaseUnits(length: LengthUnit.Decimeter),
                     new QuantityValue(1, 100)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareFoot, "InverseSquareFoot", "InverseSquareFeet", new BaseUnits(length: LengthUnit.Foot),
                     new QuantityValue(145161, 1562500)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareInch, "InverseSquareInch", "InverseSquareInches", new BaseUnits(length: LengthUnit.Inch),
                     new QuantityValue(16129, 25000000)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareKilometer, "InverseSquareKilometer", "InverseSquareKilometers", new BaseUnits(length: LengthUnit.Kilometer),
                     1000000             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareMeter, "InverseSquareMeter", "InverseSquareMeters", new BaseUnits(length: LengthUnit.Meter));
                yield return new (ReciprocalAreaUnit.InverseSquareMicrometer, "InverseSquareMicrometer", "InverseSquareMicrometers", new BaseUnits(length: LengthUnit.Micrometer),
                     new QuantityValue(1, 1000000000000)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareMile, "InverseSquareMile", "InverseSquareMiles", new BaseUnits(length: LengthUnit.Mile),
                     new QuantityValue(40468564224, 15625)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareMillimeter, "InverseSquareMillimeter", "InverseSquareMillimeters", new BaseUnits(length: LengthUnit.Millimeter),
                     new QuantityValue(1, 1000000)             
                );
                yield return new (ReciprocalAreaUnit.InverseSquareYard, "InverseSquareYard", "InverseSquareYards", new BaseUnits(length: LengthUnit.Yard),
                     new QuantityValue(1306449, 1562500)             
                );
                yield return new (ReciprocalAreaUnit.InverseUsSurveySquareFoot, "InverseUsSurveySquareFoot", "InverseUsSurveySquareFeet", new BaseUnits(length: LengthUnit.UsSurveyFoot),
                     new QuantityValue(1440000, 15499969)             
                );
            }
        }

        static ReciprocalArea()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(ReciprocalAreaInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ReciprocalArea(QuantityValue value, ReciprocalAreaUnit unit)
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
        public ReciprocalArea(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="ReciprocalArea" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<ReciprocalArea, ReciprocalAreaUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of ReciprocalArea, which is InverseSquareMeter. All conversions go via this value.
        /// </summary>
        public static ReciprocalAreaUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the ReciprocalArea quantity.
        /// </summary>
        public static IReadOnlyCollection<ReciprocalAreaUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit InverseSquareMeter.
        /// </summary>
        public static ReciprocalArea Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ReciprocalAreaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<ReciprocalArea, ReciprocalAreaUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ReciprocalArea.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<ReciprocalAreaUnit> IQuantity<ReciprocalAreaUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<ReciprocalArea> IQuantityInstance<ReciprocalArea>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareCentimeter"/>
        /// </summary>
        public QuantityValue InverseSquareCentimeters => this.As(ReciprocalAreaUnit.InverseSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareDecimeter"/>
        /// </summary>
        public QuantityValue InverseSquareDecimeters => this.As(ReciprocalAreaUnit.InverseSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareFoot"/>
        /// </summary>
        public QuantityValue InverseSquareFeet => this.As(ReciprocalAreaUnit.InverseSquareFoot);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareInch"/>
        /// </summary>
        public QuantityValue InverseSquareInches => this.As(ReciprocalAreaUnit.InverseSquareInch);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareKilometer"/>
        /// </summary>
        public QuantityValue InverseSquareKilometers => this.As(ReciprocalAreaUnit.InverseSquareKilometer);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMeter"/>
        /// </summary>
        public QuantityValue InverseSquareMeters => this.As(ReciprocalAreaUnit.InverseSquareMeter);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMicrometer"/>
        /// </summary>
        public QuantityValue InverseSquareMicrometers => this.As(ReciprocalAreaUnit.InverseSquareMicrometer);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMile"/>
        /// </summary>
        public QuantityValue InverseSquareMiles => this.As(ReciprocalAreaUnit.InverseSquareMile);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMillimeter"/>
        /// </summary>
        public QuantityValue InverseSquareMillimeters => this.As(ReciprocalAreaUnit.InverseSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareYard"/>
        /// </summary>
        public QuantityValue InverseSquareYards => this.As(ReciprocalAreaUnit.InverseSquareYard);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseUsSurveySquareFoot"/>
        /// </summary>
        public QuantityValue InverseUsSurveySquareFeet => this.As(ReciprocalAreaUnit.InverseUsSurveySquareFoot);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ReciprocalAreaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(ReciprocalAreaUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareCentimeter"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareCentimeters(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareCentimeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareDecimeter"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareDecimeters(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareDecimeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareFoot"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareFeet(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareFoot);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareInch"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareInches(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareInch);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareKilometer"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareKilometers(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareKilometer);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMeter"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareMeters(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMicrometer"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareMicrometers(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareMicrometer);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMile"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareMiles(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareMile);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMillimeter"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareMillimeters(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareMillimeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareYard"/>.
        /// </summary>
        public static ReciprocalArea FromInverseSquareYards(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseSquareYard);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseUsSurveySquareFoot"/>.
        /// </summary>
        public static ReciprocalArea FromInverseUsSurveySquareFeet(QuantityValue value)
        {
            return new ReciprocalArea(value, ReciprocalAreaUnit.InverseUsSurveySquareFoot);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReciprocalAreaUnit" /> to <see cref="ReciprocalArea" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReciprocalArea unit value.</returns>
        public static ReciprocalArea From(QuantityValue value, ReciprocalAreaUnit fromUnit)
        {
            return new ReciprocalArea(value, fromUnit);
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
        public static ReciprocalArea Parse(string str)
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
        public static ReciprocalArea Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<ReciprocalArea, ReciprocalAreaUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out ReciprocalArea result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out ReciprocalArea result)
        {
            return QuantityParser.Default.TryParse<ReciprocalArea, ReciprocalAreaUnit>(str, provider, From, out result);
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
        public static ReciprocalAreaUnit ParseUnit(string str)
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
        public static ReciprocalAreaUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.ReciprocalAreaUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out ReciprocalAreaUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out ReciprocalAreaUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static ReciprocalArea operator -(ReciprocalArea right)
        {
            return new ReciprocalArea(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="ReciprocalArea"/> from adding two <see cref="ReciprocalArea"/>.</summary>
        public static ReciprocalArea operator +(ReciprocalArea left, ReciprocalArea right)
        {
            return new ReciprocalArea(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="ReciprocalArea"/> from subtracting two <see cref="ReciprocalArea"/>.</summary>
        public static ReciprocalArea operator -(ReciprocalArea left, ReciprocalArea right)
        {
            return new ReciprocalArea(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="ReciprocalArea"/> from multiplying value and <see cref="ReciprocalArea"/>.</summary>
        public static ReciprocalArea operator *(QuantityValue left, ReciprocalArea right)
        {
            return new ReciprocalArea(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="ReciprocalArea"/> from multiplying value and <see cref="ReciprocalArea"/>.</summary>
        public static ReciprocalArea operator *(ReciprocalArea left, QuantityValue right)
        {
            return new ReciprocalArea(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="ReciprocalArea"/> from dividing <see cref="ReciprocalArea"/> by value.</summary>
        public static ReciprocalArea operator /(ReciprocalArea left, QuantityValue right)
        {
            return new ReciprocalArea(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="ReciprocalArea"/> by <see cref="ReciprocalArea"/>.</summary>
        public static QuantityValue operator /(ReciprocalArea left, ReciprocalArea right)
        {
            return left.InverseSquareMeters / right.InverseSquareMeters;
        }

        #endregion

        #region Relational Operators

        /// <summary>Calculates the inverse of this quantity.</summary>
        /// <returns>The corresponding inverse quantity, <see cref="Area"/>.</returns>
        public Area Inverse()
        {
            return UnitConverter.Default.ConvertTo(Value, Unit, Area.Info);
        }

        /// <summary>Get <see cref="Length"/> from <see cref="ReciprocalArea"/> * <see cref="Volume"/>.</summary>
        public static Length operator *(ReciprocalArea reciprocalArea, Volume volume)
        {
            return Length.FromMeters(reciprocalArea.InverseSquareMeters * volume.CubicMeters);
        }

        /// <summary>Get <see cref="Pressure"/> from <see cref="ReciprocalArea"/> * <see cref="Force"/>.</summary>
        public static Pressure operator *(ReciprocalArea reciprocalArea, Force force)
        {
            return Pressure.FromNewtonsPerSquareMeter(reciprocalArea.InverseSquareMeters * force.Newtons);
        }

        /// <summary>Get <see cref="Ratio"/> from <see cref="ReciprocalArea"/> * <see cref="Area"/>.</summary>
        public static Ratio operator *(ReciprocalArea reciprocalArea, Area area)
        {
            return Ratio.FromDecimalFractions(reciprocalArea.InverseSquareMeters * area.SquareMeters);
        }

        /// <summary>Get <see cref="ReciprocalLength"/> from <see cref="ReciprocalArea"/> * <see cref="Length"/>.</summary>
        public static ReciprocalLength operator *(ReciprocalArea reciprocalArea, Length length)
        {
            return ReciprocalLength.FromInverseMeters(reciprocalArea.InverseSquareMeters * length.Meters);
        }

        /// <summary>Get <see cref="ReciprocalLength"/> from <see cref="ReciprocalArea"/> / <see cref="ReciprocalLength"/>.</summary>
        public static ReciprocalLength operator /(ReciprocalArea reciprocalArea, ReciprocalLength reciprocalLength)
        {
            return ReciprocalLength.FromInverseMeters(reciprocalArea.InverseSquareMeters / reciprocalLength.InverseMeters);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(ReciprocalArea left, ReciprocalArea right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(ReciprocalArea left, ReciprocalArea right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(ReciprocalArea left, ReciprocalArea right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(ReciprocalArea left, ReciprocalArea right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="ReciprocalArea"/> quantities.</summary>
        public static bool operator ==(ReciprocalArea left, ReciprocalArea right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="ReciprocalArea"/> quantities.</summary>
        public static bool operator !=(ReciprocalArea left, ReciprocalArea right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="ReciprocalArea"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not ReciprocalArea otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="ReciprocalArea"/> quantities.</summary>
        public bool Equals(ReciprocalArea other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current ReciprocalArea.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(ReciprocalArea), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(ReciprocalArea)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not ReciprocalArea otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<ReciprocalArea>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="ReciprocalArea"/> with another <see cref="ReciprocalArea"/> and returns an integer that indicates
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
        public int CompareTo(ReciprocalArea other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<ReciprocalAreaUnit> IQuantity<ReciprocalAreaUnit>.ToUnit(ReciprocalAreaUnit unit) => this.ToUnit(unit);

        IQuantity<ReciprocalAreaUnit> IQuantity<ReciprocalAreaUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
