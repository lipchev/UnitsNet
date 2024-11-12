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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using UnitsNet.Units;
using System.Numerics;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Turbidity is the cloudiness or haziness of a fluid caused by large numbers of individual particles that are generally invisible to the naked eye, similar to smoke in air. The measurement of turbidity is a key test of water quality.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Turbidity
    /// </remarks>
    [DataContract]
    [DebuggerTypeProxy(typeof(QuantityDisplay))]
    public readonly partial struct Turbidity :
        IArithmeticQuantity<Turbidity, TurbidityUnit>,
        IComparable,
        IComparable<Turbidity>,
        IConvertible,
        IEquatable<Turbidity>,
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
        private readonly TurbidityUnit? _unit;

        static Turbidity()
        {
            BaseDimensions = BaseDimensions.Dimensionless;
            BaseUnit = TurbidityUnit.NTU;
            Units = Enum.GetValues(typeof(TurbidityUnit)).Cast<TurbidityUnit>().ToArray();
            Zero = new Turbidity(0, BaseUnit);
            Info = new QuantityInfo<TurbidityUnit>("Turbidity",
                new UnitInfo<TurbidityUnit>[]
                {
                    new UnitInfo<TurbidityUnit>(TurbidityUnit.NTU, "NTU", BaseUnits.Undefined, "Turbidity"),
                },
                BaseUnit, Zero, BaseDimensions);

            DefaultConversionFunctions = new UnitConverter();
            RegisterDefaultConversions(DefaultConversionFunctions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Turbidity(QuantityValue value, TurbidityUnit unit)
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
        public Turbidity(QuantityValue value, UnitSystem unitSystem)
        {
            if (unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = value;
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="Turbidity" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<TurbidityUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Turbidity, which is NTU. All conversions go via this value.
        /// </summary>
        public static TurbidityUnit BaseUnit { get; }

        /// <summary>
        ///     All units of measurement for the Turbidity quantity.
        /// </summary>
        public static TurbidityUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit NTU.
        /// </summary>
        public static Turbidity Zero { get; }

        /// <inheritdoc cref="Zero"/>
        public static Turbidity AdditiveIdentity => Zero;

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        QuantityValue IQuantity.Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public TurbidityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<TurbidityUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Turbidity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TurbidityUnit.NTU"/>
        /// </summary>
        public QuantityValue NTU => As(TurbidityUnit.NTU);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: TurbidityUnit -> BaseUnit

            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<Turbidity>(TurbidityUnit.NTU, TurbidityUnit.NTU, quantity => quantity);

            // Register in unit converter: BaseUnit -> TurbidityUnit
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(TurbidityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(TurbidityUnit unit, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Turbidity"/> from <see cref="TurbidityUnit.NTU"/>.
        /// </summary>
        public static Turbidity FromNTU(QuantityValue value)
        {
            return new Turbidity(value, TurbidityUnit.NTU);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TurbidityUnit" /> to <see cref="Turbidity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Turbidity unit value.</returns>
        public static Turbidity From(QuantityValue value, TurbidityUnit fromUnit)
        {
            return new Turbidity(value, fromUnit);
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
        public static Turbidity Parse(string str)
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
        public static Turbidity Parse(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.QuantityParser.Parse<Turbidity, TurbidityUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse(string? str, out Turbidity result)
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
        public static bool TryParse(string? str, IFormatProvider? provider, out Turbidity result)
        {
            return UnitsNetSetup.Default.QuantityParser.TryParse<Turbidity, TurbidityUnit>(
                str,
                provider,
                From,
                out result);
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
        public static TurbidityUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static TurbidityUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitsNetSetup.Default.UnitParser.Parse<TurbidityUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.TurbidityUnit)"/>
        public static bool TryParseUnit(string str, out TurbidityUnit unit)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider? provider, out TurbidityUnit unit)
        {
            return UnitsNetSetup.Default.UnitParser.TryParse<TurbidityUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static Turbidity operator -(Turbidity right)
        {
            return new Turbidity(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Turbidity"/> from adding two <see cref="Turbidity"/>.</summary>
        public static Turbidity operator +(Turbidity left, Turbidity right)
        {
            return new Turbidity(left.Value + right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="Turbidity"/> from subtracting two <see cref="Turbidity"/>.</summary>
        public static Turbidity operator -(Turbidity left, Turbidity right)
        {
            return new Turbidity(left.Value - right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="Turbidity"/> from multiplying value and <see cref="Turbidity"/>.</summary>
        public static Turbidity operator *(QuantityValue left, Turbidity right)
        {
            return new Turbidity(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Turbidity"/> from multiplying value and <see cref="Turbidity"/>.</summary>
        public static Turbidity operator *(Turbidity left, QuantityValue right)
        {
            return new Turbidity(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="Turbidity"/> from dividing <see cref="Turbidity"/> by value.</summary>
        public static Turbidity operator /(Turbidity left, QuantityValue right)
        {
            return new Turbidity(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="Turbidity"/> by <see cref="Turbidity"/>.</summary>
        public static QuantityValue operator /(Turbidity left, Turbidity right)
        {
            return left.NTU / right.NTU;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(Turbidity left, Turbidity right)
        {
            return left.Value <= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(Turbidity left, Turbidity right)
        {
            return left.Value >= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(Turbidity left, Turbidity right)
        {
            return left.Value < right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(Turbidity left, Turbidity right)
        {
            return left.Value > right.ToUnit(left.Unit).Value;
        }

        /// <summary>Indicates strict equality of two <see cref="Turbidity"/> quantities.</summary>
        public static bool operator ==(Turbidity left, Turbidity right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="Turbidity"/> quantities.</summary>
        public static bool operator !=(Turbidity left, Turbidity right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="Turbidity"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Turbidity otherQuantity))
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="Turbidity"/> quantities.</summary>
        public bool Equals(Turbidity other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>Compares the current <see cref="Turbidity"/> with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="obj" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="obj" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="obj" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(object? obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Turbidity otherQuantity)) throw new ArgumentException("Expected type Turbidity.", nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>Compares the current <see cref="Turbidity"/> with another <see cref="Turbidity"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="other">A quantity to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(Turbidity other)
        {
            return _value.CompareTo(other.ToUnit(this.Unit).Value);
        }

        /// <inheritdoc />
        public bool Equals(IQuantity? other, IQuantity tolerance)
        {
            return other is Turbidity otherTyped
                   && (tolerance is Turbidity toleranceTyped
                       ? true
                       : throw new ArgumentException($"Tolerance quantity ({tolerance.QuantityInfo.Name}) did not match the other quantities of type 'Turbidity'.", nameof(tolerance)))
                   && Equals(otherTyped, toleranceTyped);
        }

        /// <inheritdoc />
        public bool Equals(Turbidity other, Turbidity tolerance)
        {
            return UnitsNet.Comparison.EqualsAbsolute(
                this.Value,
                other.As(this.Unit),
                tolerance: tolerance.As(this.Unit));
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Turbidity.</returns>
        public override int GetHashCode()
        {
            var valueInBaseUnit = As(BaseUnit);
            #if NET7_0_OR_GREATER
            return HashCode.Combine(Info.Name, valueInBaseUnit);
            #else
            return new { Info.Name, valueInBaseUnit }.GetHashCode();
            #endif
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(TurbidityUnit unit)
        {
            if (Unit == unit)
                return Value;

            return ToUnit(unit).Value;
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public QuantityValue As(UnitSystem unitSystem)
        {
            if (unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if (firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        QuantityValue IQuantity.As(Enum unit)
        {
            if (!(unit is TurbidityUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(TurbidityUnit)} is supported.", nameof(unit));

            return As(typedUnit);
        }

        /// <summary>
        ///     Converts this Turbidity to another Turbidity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A Turbidity with the specified unit.</returns>
        public Turbidity ToUnit(TurbidityUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this <see cref="Turbidity"/> to another <see cref="Turbidity"/> using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A Turbidity with the specified unit.</returns>
        public Turbidity ToUnit(TurbidityUnit unit, UnitConverter unitConverter)
        {
            if (TryToUnit(unit, out var converted))
            {
                // Try to convert using the auto-generated conversion methods.
                return converted!.Value;
            }
            else if (unitConverter.TryGetConversionFunction((typeof(Turbidity), Unit, typeof(Turbidity), unit), out var conversionFunction))
            {
                // See if the unit converter has an extensibility conversion registered.
                return (Turbidity)conversionFunction(this);
            }
            else if (Unit != BaseUnit)
            {
                // Conversion to requested unit NOT found. Try to convert to BaseUnit, and then from BaseUnit to requested unit.
                var inBaseUnits = ToUnit(BaseUnit);
                return inBaseUnits.ToUnit(unit);
            }
            else
            {
                // No possible conversion
                throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        /// <summary>
        ///     Attempts to convert this <see cref="Turbidity"/> to another <see cref="Turbidity"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="converted">The converted <see cref="Turbidity"/> in <paramref name="unit"/>, if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        private bool TryToUnit(TurbidityUnit unit, [NotNullWhen(true)] out Turbidity? converted)
        {
            if (Unit == unit)
            {
                converted = this;
                return true;
            }

            Turbidity? convertedOrNull = (Unit, unit) switch
            {
                // TurbidityUnit -> BaseUnit

                // BaseUnit -> TurbidityUnit

                _ => null
            };

            if (convertedOrNull is null)
            {
                converted = default;
                return false;
            }

            converted = convertedOrNull.Value;
            return true;
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if (!(unit is TurbidityUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(TurbidityUnit)} is supported.", nameof(unit));

            return ToUnit(typedUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public Turbidity ToUnit(UnitSystem unitSystem)
        {
            if (unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if (firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<TurbidityUnit> IQuantity<TurbidityUnit>.ToUnit(TurbidityUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<TurbidityUnit> IQuantity<TurbidityUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentCulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<TurbidityUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(Turbidity)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider? provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(Turbidity)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(Turbidity)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider? provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider? provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider? provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider? provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider? provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider? provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider? provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider? provider)
        {
            if (conversionType == typeof(Turbidity))
                return this;
            else if (conversionType == typeof(TurbidityUnit))
                return Unit;
            else if (conversionType == typeof(QuantityInfo))
                return Turbidity.Info;
            else if (conversionType == typeof(BaseDimensions))
                return Turbidity.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(Turbidity)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider? provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider? provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider? provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}
