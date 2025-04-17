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
    ///     Angular acceleration is the rate of change of rotational speed.
    /// </summary>
    [DataContract]
    [DebuggerDisplay(QuantityDebugProxy.DisplayFormat)]
    [DebuggerTypeProxy(typeof(QuantityDebugProxy))]
    public readonly partial struct RotationalAcceleration :
        IArithmeticQuantity<RotationalAcceleration, RotationalAccelerationUnit>,
#if NET7_0_OR_GREATER
        IComparisonOperators<RotationalAcceleration, RotationalAcceleration, bool>,
        IParsable<RotationalAcceleration>,
#endif
        IComparable,
        IComparable<RotationalAcceleration>,
        IEquatable<RotationalAcceleration>,
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
        private readonly RotationalAccelerationUnit? _unit;

        /// <summary>
        ///     Provides detailed information about the <see cref="RotationalAcceleration"/> quantity, including its name, base unit, unit mappings, base dimensions, and conversion functions.
        /// </summary>
        public sealed class RotationalAccelerationInfo: QuantityInfo<RotationalAcceleration, RotationalAccelerationUnit>
        {
            /// <inheritdoc />
            public RotationalAccelerationInfo(string name, RotationalAccelerationUnit baseUnit, IEnumerable<IUnitDefinition<RotationalAccelerationUnit>> unitMappings, RotationalAcceleration zero, BaseDimensions baseDimensions,
                QuantityFromDelegate<RotationalAcceleration, RotationalAccelerationUnit> fromDelegate, ResourceManager? unitAbbreviations)
                : base(name, baseUnit, unitMappings, zero, baseDimensions, fromDelegate, unitAbbreviations)
            {
            }

            /// <inheritdoc />
            public RotationalAccelerationInfo(string name, RotationalAccelerationUnit baseUnit, IEnumerable<IUnitDefinition<RotationalAccelerationUnit>> unitMappings, RotationalAcceleration zero, BaseDimensions baseDimensions)
                : this(name, baseUnit, unitMappings, zero, baseDimensions, RotationalAcceleration.From, new ResourceManager("UnitsNet.GeneratedCode.Resources.RotationalAcceleration", typeof(RotationalAcceleration).Assembly))
            {
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="RotationalAccelerationInfo"/> class with the default settings for the RotationalAcceleration quantity.
            /// </summary>
            /// <returns>A new instance of the <see cref="RotationalAccelerationInfo"/> class with the default settings.</returns>
            public static RotationalAccelerationInfo CreateDefault()
            {
                return new RotationalAccelerationInfo(nameof(RotationalAcceleration), DefaultBaseUnit, GetDefaultMappings(), new RotationalAcceleration(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     Creates a new instance of the <see cref="RotationalAccelerationInfo"/> class with the default settings for the RotationalAcceleration quantity and a callback for customizing the default unit mappings.
            /// </summary>
            /// <param name="customizeUnits">
            ///     A callback function for customizing the default unit mappings.
            /// </param>
            /// <returns>
            ///     A new instance of the <see cref="RotationalAccelerationInfo"/> class with the default settings.
            /// </returns>
            public static RotationalAccelerationInfo CreateDefault(Func<IEnumerable<UnitDefinition<RotationalAccelerationUnit>>, IEnumerable<IUnitDefinition<RotationalAccelerationUnit>>> customizeUnits)
            {
                return new RotationalAccelerationInfo(nameof(RotationalAcceleration), DefaultBaseUnit, customizeUnits(GetDefaultMappings()), new RotationalAcceleration(0, DefaultBaseUnit), DefaultBaseDimensions);
            }

            /// <summary>
            ///     The <see cref="BaseDimensions" /> for <see cref="RotationalAcceleration"/> is T^-2.
            /// </summary>
            public static BaseDimensions DefaultBaseDimensions { get; } = new BaseDimensions(0, 0, -2, 0, 0, 0, 0);

            /// <summary>
            ///     The default base unit of RotationalAcceleration is RadianPerSecondSquared. All conversions, as defined in the <see cref="GetDefaultMappings"/>, go via this value.
            /// </summary>
            public static RotationalAccelerationUnit DefaultBaseUnit { get; } = RotationalAccelerationUnit.RadianPerSecondSquared;

            /// <summary>
            ///     Retrieves the default mappings for <see cref="RotationalAccelerationUnit"/>.
            /// </summary>
            /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="UnitDefinition{RotationalAccelerationUnit}"/> representing the default unit mappings for RotationalAcceleration.</returns>
            public static IEnumerable<UnitDefinition<RotationalAccelerationUnit>> GetDefaultMappings()
            {
                yield return new (RotationalAccelerationUnit.DegreePerSecondSquared, "DegreePerSecondSquared", "DegreesPerSecondSquared", BaseUnits.Undefined,
                     new QuantityValue(180000000000000000, 3141592653589793)             
                );
                yield return new (RotationalAccelerationUnit.RadianPerSecondSquared, "RadianPerSecondSquared", "RadiansPerSecondSquared", new BaseUnits(time: DurationUnit.Second));
                yield return new (RotationalAccelerationUnit.RevolutionPerMinutePerSecond, "RevolutionPerMinutePerSecond", "RevolutionsPerMinutePerSecond", BaseUnits.Undefined,
                     new QuantityValue(30000000000000000, 3141592653589793)             
                );
                yield return new (RotationalAccelerationUnit.RevolutionPerSecondSquared, "RevolutionPerSecondSquared", "RevolutionsPerSecondSquared", BaseUnits.Undefined,
                     new QuantityValue(500000000000000, 3141592653589793)             
                );
            }
        }

        static RotationalAcceleration()
        {
            Info = UnitsNetSetup.CreateQuantityInfo(RotationalAccelerationInfo.CreateDefault);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public RotationalAcceleration(QuantityValue value, RotationalAccelerationUnit unit)
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
        public RotationalAcceleration(QuantityValue value, UnitSystem unitSystem)
        {
            _value = value;
            _unit = Info.GetDefaultUnit(unitSystem);
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="RotationalAcceleration" /> instances.
        /// </summary>
        [Obsolete("Replaced by UnitConverter.Default")]
        public static UnitConverter DefaultConversionFunctions => UnitConverter.Default;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<RotationalAcceleration, RotationalAccelerationUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions => Info.BaseDimensions;

        /// <summary>
        ///     The base unit of RotationalAcceleration, which is RadianPerSecondSquared. All conversions go via this value.
        /// </summary>
        public static RotationalAccelerationUnit BaseUnit => Info.BaseUnitInfo.Value;

        /// <summary>
        ///     All units of measurement for the RotationalAcceleration quantity.
        /// </summary>
        public static IReadOnlyCollection<RotationalAccelerationUnit> Units => Info.Units;

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit RadianPerSecondSquared.
        /// </summary>
        public static RotationalAcceleration Zero => Info.Zero;

        #endregion

        #region Properties

        /// <inheritdoc />
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public RotationalAccelerationUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<RotationalAcceleration, RotationalAccelerationUnit> QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => RotationalAcceleration.BaseDimensions;

        #region Explicit implementations

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Enum IQuantity.Unit => Unit;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        UnitKey IQuantity.UnitKey => UnitKey.ForUnit(Unit);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo IQuantity.QuantityInfo => Info;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        QuantityInfo<RotationalAccelerationUnit> IQuantity<RotationalAccelerationUnit>.QuantityInfo => Info;

#if NETSTANDARD2_0
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IQuantityInstanceInfo<RotationalAcceleration> IQuantityInstance<RotationalAcceleration>.QuantityInfo => Info;
#endif

        #endregion

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.DegreePerSecondSquared"/>
        /// </summary>
        public QuantityValue DegreesPerSecondSquared => this.As(RotationalAccelerationUnit.DegreePerSecondSquared);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.RadianPerSecondSquared"/>
        /// </summary>
        public QuantityValue RadiansPerSecondSquared => this.As(RotationalAccelerationUnit.RadianPerSecondSquared);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.RevolutionPerMinutePerSecond"/>
        /// </summary>
        public QuantityValue RevolutionsPerMinutePerSecond => this.As(RotationalAccelerationUnit.RevolutionPerMinutePerSecond);

        /// <summary>
        ///     Gets a <see cref="QuantityValue"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.RevolutionPerSecondSquared"/>
        /// </summary>
        public QuantityValue RevolutionsPerSecondSquared => this.As(RotationalAccelerationUnit.RevolutionPerSecondSquared);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(RotationalAccelerationUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(RotationalAccelerationUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.DegreePerSecondSquared"/>.
        /// </summary>
        public static RotationalAcceleration FromDegreesPerSecondSquared(QuantityValue value)
        {
            return new RotationalAcceleration(value, RotationalAccelerationUnit.DegreePerSecondSquared);
        }

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.RadianPerSecondSquared"/>.
        /// </summary>
        public static RotationalAcceleration FromRadiansPerSecondSquared(QuantityValue value)
        {
            return new RotationalAcceleration(value, RotationalAccelerationUnit.RadianPerSecondSquared);
        }

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.RevolutionPerMinutePerSecond"/>.
        /// </summary>
        public static RotationalAcceleration FromRevolutionsPerMinutePerSecond(QuantityValue value)
        {
            return new RotationalAcceleration(value, RotationalAccelerationUnit.RevolutionPerMinutePerSecond);
        }

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.RevolutionPerSecondSquared"/>.
        /// </summary>
        public static RotationalAcceleration FromRevolutionsPerSecondSquared(QuantityValue value)
        {
            return new RotationalAcceleration(value, RotationalAccelerationUnit.RevolutionPerSecondSquared);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalAccelerationUnit" /> to <see cref="RotationalAcceleration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalAcceleration unit value.</returns>
        public static RotationalAcceleration From(QuantityValue value, RotationalAccelerationUnit fromUnit)
        {
            return new RotationalAcceleration(value, fromUnit);
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
        public static RotationalAcceleration Parse(string str)
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
        public static RotationalAcceleration Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<RotationalAcceleration, RotationalAccelerationUnit>(str, provider, From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse([NotNullWhen(true)]string? str, out RotationalAcceleration result)
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
        public static bool TryParse([NotNullWhen(true)]string? str, IFormatProvider? provider, out RotationalAcceleration result)
        {
            return QuantityParser.Default.TryParse<RotationalAcceleration, RotationalAccelerationUnit>(str, provider, From, out result);
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
        public static RotationalAccelerationUnit ParseUnit(string str)
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
        public static RotationalAccelerationUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse(str, Info.UnitInfos, provider).Value;
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider?,out UnitsNet.Units.RotationalAccelerationUnit)"/>
        public static bool TryParseUnit([NotNullWhen(true)]string? str, out RotationalAccelerationUnit unit)
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
        public static bool TryParseUnit([NotNullWhen(true)]string? str, IFormatProvider? provider, out RotationalAccelerationUnit unit)
        {
            return UnitParser.Default.TryParse(str, Info, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static RotationalAcceleration operator -(RotationalAcceleration right)
        {
            return new RotationalAcceleration(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="RotationalAcceleration"/> from adding two <see cref="RotationalAcceleration"/>.</summary>
        public static RotationalAcceleration operator +(RotationalAcceleration left, RotationalAcceleration right)
        {
            return new RotationalAcceleration(left.Value + right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="RotationalAcceleration"/> from subtracting two <see cref="RotationalAcceleration"/>.</summary>
        public static RotationalAcceleration operator -(RotationalAcceleration left, RotationalAcceleration right)
        {
            return new RotationalAcceleration(left.Value - right.As(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="RotationalAcceleration"/> from multiplying value and <see cref="RotationalAcceleration"/>.</summary>
        public static RotationalAcceleration operator *(QuantityValue left, RotationalAcceleration right)
        {
            return new RotationalAcceleration(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="RotationalAcceleration"/> from multiplying value and <see cref="RotationalAcceleration"/>.</summary>
        public static RotationalAcceleration operator *(RotationalAcceleration left, QuantityValue right)
        {
            return new RotationalAcceleration(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="RotationalAcceleration"/> from dividing <see cref="RotationalAcceleration"/> by value.</summary>
        public static RotationalAcceleration operator /(RotationalAcceleration left, QuantityValue right)
        {
            return new RotationalAcceleration(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="RotationalAcceleration"/> by <see cref="RotationalAcceleration"/>.</summary>
        public static QuantityValue operator /(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left.RadiansPerSecondSquared / right.RadiansPerSecondSquared;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left.Value <= right.As(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left.Value >= right.As(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left.Value < right.As(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left.Value > right.As(left.Unit);
        }

        /// <summary>Indicates strict equality of two <see cref="RotationalAcceleration"/> quantities.</summary>
        public static bool operator ==(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="RotationalAcceleration"/> quantities.</summary>
        public static bool operator !=(RotationalAcceleration left, RotationalAcceleration right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="RotationalAcceleration"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is not RotationalAcceleration otherQuantity)
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="RotationalAcceleration"/> quantities.</summary>
        public bool Equals(RotationalAcceleration other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current RotationalAcceleration.</returns>
        public override int GetHashCode()
        {
            return Comparison.GetHashCode(typeof(RotationalAcceleration), this.As(BaseUnit));
        }
        
        /// <inheritdoc  cref="CompareTo(RotationalAcceleration)" />
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object? obj)
        {
            if (obj is not RotationalAcceleration otherQuantity)
                throw obj is null ? new ArgumentNullException(nameof(obj)) : ExceptionHelper.CreateArgumentException<RotationalAcceleration>(obj, nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>
        ///     Compares the current <see cref="RotationalAcceleration"/> with another <see cref="RotationalAcceleration"/> and returns an integer that indicates
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
        public int CompareTo(RotationalAcceleration other)
        {
            return _value.CompareTo(other.As(this.Unit));
        }

        #endregion

        #region Conversion Methods (explicit implementations for netstandard2.0)

#if NETSTANDARD2_0
        QuantityValue IQuantity.As(Enum unit) => UnitConverter.Default.ConvertValue(Value, UnitKey.ForUnit(Unit), unit);

        IQuantity IQuantity.ToUnit(Enum unit) => UnitConverter.Default.ConvertTo(this, unit);

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);

        IQuantity<RotationalAccelerationUnit> IQuantity<RotationalAccelerationUnit>.ToUnit(RotationalAccelerationUnit unit) => this.ToUnit(unit);

        IQuantity<RotationalAccelerationUnit> IQuantity<RotationalAccelerationUnit>.ToUnit(UnitSystem unitSystem) => this.ToUnit(unitSystem);
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
