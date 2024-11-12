﻿using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using UnitsNet.Serialization;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.Serialization.Json
{
    /// <summary>
    ///     These tests demonstrate the default behavior of the DataContractJsonSerializer when dealing with quantities
    ///     <remarks>
    ///         <para>Note that the produced schema is different from the one generated using the UnitsNet.Json package</para>
    ///         <para>
    ///             The default schema can easily be modified using a converter, a.k.a. DataContractSurrogate (.NET Framework)
    ///         </para>
    ///     </remarks>
    /// </summary>
    public class DefaultDataContractJsonSerializerTests : SerializationTestsBase<string>
    {
        // this is how the DataContractJsonSerializer formats an IXmlSerializable...
        private const string OnePointTwoJson =
            """
            "<QuantityValue xmlns=\"http:\/\/schemas.datacontract.org\/2004\/07\/UnitsNet\"><N>12<\/N><D>10<\/D><\/QuantityValue>"
            """;
        
        protected override string SerializeObject(object obj)
        {
            var serializer = new DataContractJsonSerializer(obj.GetType(), new DataContractJsonSerializerSettings(){SerializeReadOnlyTypes = true});
            serializer.SetSerializationSurrogateProvider(QuantityValueSurrogateSerializationProvider.Instance); // this doesn't work as expected because of https://github.com/dotnet/runtime/issues/100553
            using var stream = new MemoryStream();
            serializer.WriteObject(stream, obj);
            stream.Position = 0;
            using var streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        }

        protected override T DeserializeObject<T>(string json)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            serializer.SetSerializationSurrogateProvider(QuantityValueSurrogateSerializationProvider.Instance); // this doesn't work as expected because of https://github.com/dotnet/runtime/issues/100553
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;
            return (T)(serializer.ReadObject(stream) ?? throw new InvalidOperationException("Read 'null' from stream."));
        }

        #region Serialization tests

        [Fact(Skip = "https://github.com/dotnet/runtime/issues/100553")]
        public void DoubleQuantity_SerializedWithDoubleValueAndunitInt()
        {
            var quantity = new Mass(1.20, MassUnit.Milligram);
            var unitInt = (int)quantity.Unit;
            var expectedJson = $$"""{"Value":"QuantityValue":{"N":"1","D":2"},"Unit":{{unitInt}}}""";

            var json = SerializeObject(quantity);

            Assert.Equal(expectedJson, json);
        }

        #endregion

        #region Deserialization tests

        [Fact(Skip = "https://github.com/dotnet/runtime/issues/100553")]
        public void DoubleQuantity_DeserializedFromXmlValueAndIntegerUnit()
        {
            var expectedUnit = MassUnit.Milligram;
            var unitInt = (int)expectedUnit;
            var json = $$"""{"Value":"QuantityValue":{"N":"1","D":2"},"Unit":{{unitInt}}}""";

            var quantity = DeserializeObject<Mass>(json);

            Assert.Equal(1.2, quantity.Value);
            Assert.Equal(expectedUnit, quantity.Unit);
        }

        [Fact]
        public void DoubleZeroQuantity_DeserializedFromIntegerUnitAndNoValue()
        {
            var expectedUnit = MassUnit.Milligram;
            var unitInt = (int)expectedUnit;
            var json = $"{{\"Unit\":{unitInt}}}";

            var quantity = DeserializeObject<Mass>(json);

            Assert.Equal(0, quantity.Value);
            Assert.Equal(expectedUnit, quantity.Unit);
        }

        [Fact(Skip = "https://github.com/dotnet/runtime/issues/100553")]
        public void InterfaceObject_IncludesTypeInformation()
        {
            var unit = InformationUnit.Exabyte;
            var unitInt = (int)unit;
            var testObject = new TestInterfaceObject { Quantity = new Information(1.2, unit) };
            var expectedJson = $$$"""{"Quantity":{"__type":"Information:#UnitsNet","Value":"QuantityValue":{"N":"1","D":2"},"Unit":{{{unitInt}}}}}""";

            var json = SerializeObject(testObject);

            Assert.Equal(expectedJson, json);
        }

        [Fact(Skip = "https://github.com/dotnet/runtime/issues/100553")]
        public void DoubleBaseUnitQuantity_DeserializedFromXmlValueAndNoUnit()
        {
            var json = """{"Value":"QuantityValue":{"N":"1","D":2"}""";

            var quantity = DeserializeObject<Mass>(json);

            Assert.Equal(1.2, quantity.Value);
            Assert.Equal(Mass.BaseUnit, quantity.Unit);
        }

        [Fact]
        public void DoubleZeroBaseQuantity_DeserializedFromEmptyInput()
        {
            var json = "{}";

            var quantity = DeserializeObject<Mass>(json);

            Assert.Equal(0, quantity.Value);
            Assert.Equal(Mass.BaseUnit, quantity.Unit);
        }

        [Fact]
        public void InterfaceObject_WithMissingKnownTypeInformation_ThrowsSerializationException()
        {
            var testObject = new TestInterfaceObject { Quantity = new Volume(1.2, VolumeUnit.Microliter) };

            Assert.Throws<SerializationException>(() => SerializeObject(testObject));
        }

        [Fact]
        public void DecimalZeroQuantity_DeserializedFromUnitIntAndNoValue()
        {
            var expectedUnit = InformationUnit.Exabyte;
            var unitInt = (int)expectedUnit;
            var json = $$"""{"Unit":{{unitInt}}}""";

            var quantity = DeserializeObject<Information>(json);

            Assert.Equal(0, quantity.Value);
            Assert.Equal(expectedUnit, quantity.Unit);
        }

        [Fact]
        public void DecimalZeroBaseQuantity_DeserializedFromEmptyInput()
        {
            var json = "{}";

            var quantity = DeserializeObject<Information>(json);

            Assert.Equal(0, quantity.Value);
            Assert.Equal(Information.BaseUnit, quantity.Unit);
        }

        #endregion
    }
}
