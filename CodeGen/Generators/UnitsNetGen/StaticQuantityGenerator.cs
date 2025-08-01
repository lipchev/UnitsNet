﻿using CodeGen.JsonTypes;

namespace CodeGen.Generators.UnitsNetGen
{
    internal class StaticQuantityGenerator : GeneratorBase
    {
        private readonly Quantity[] _quantities;

        public StaticQuantityGenerator(Quantity[] quantities)
        {
            _quantities = quantities;
        }

        public string Generate()
        {
            Writer.WL(GeneratedFileHeader);
            Writer.WL(@"

#nullable enable

namespace UnitsNet;

/// <summary>
///     Dynamically parse or construct quantities when types are only known at runtime.
/// </summary>
public partial class Quantity
{
    /// <summary>
    ///     Serves as a repository for predefined quantity conversion mappings, facilitating the automatic generation and retrieval of unit conversions in the UnitsNet library.
    /// </summary>
    internal static class DefaultProvider
    {
        /// <summary>
        ///     All QuantityInfo instances that are present in UnitsNet by default.
        /// </summary>
        internal static IReadOnlyList<QuantityInfo> Quantities { get; } =
        [");
            foreach (var quantity in _quantities)
                Writer.WL($@"
            {quantity.Name}.Info,");
            Writer.WL(@"
        ];

        internal static void RegisterUnitConversions(UnitConverter unitConverter)
        {");
            foreach (Quantity quantity in _quantities)
            {
                Writer.WL($@"
            {quantity.Name}.RegisterDefaultConversions(unitConverter);");
            }

            Writer.WL(@"
        }
    }
}");
            return Writer.ToString();
        }
    }
}
