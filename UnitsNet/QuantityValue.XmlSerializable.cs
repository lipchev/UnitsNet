using System.Globalization;
using System.Numerics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Fractions;

namespace UnitsNet;

// public partial struct QuantityValue : IXmlSerializable
// {
//     readonly XmlSchema? IXmlSerializable.GetSchema()
//     {
//         return null;
//     }
//
//     void IXmlSerializable.ReadXml(XmlReader reader)
//     {
//         BigInteger numerator = BigInteger.Zero;
//         BigInteger denominator = BigInteger.One;
//
//         reader.ReadStartElement();
//
//         while (reader.IsStartElement())
//         {
//             var elementName = reader.Name;
//             reader.ReadStartElement();
//             switch (elementName)
//             {
//                 case nameof(_fraction.Numerator):
//                     numerator = BigInteger.Parse(reader.ReadContentAsString(), CultureInfo.InvariantCulture);
//                     break;
//                 case nameof(_fraction.Denominator):
//                     denominator = BigInteger.Parse(reader.ReadContentAsString(), CultureInfo.InvariantCulture);
//                     break;
//                 // case "NormalizationNotApplied":
//                 //     reader.ReadStartElement();
//                 //     normalizationNotApplied = bool.Parse(reader.ReadContentAsString());
//                 //     reader.ReadEndElement();
//                 //     break;
//             }
//
//             reader.ReadEndElement();
//         }
//
//         if (reader.NodeType == XmlNodeType.EndElement)
//         {
//             reader.ReadEndElement();
//         }
//
//         this = new QuantityValue(numerator, denominator);
//     }
//
//     void IXmlSerializable.WriteXml(XmlWriter writer)
//     {
//         writer.WriteStartElement(nameof(_fraction.Numerator));
//         writer.WriteValue(_fraction.Numerator.ToString(CultureInfo.InvariantCulture));
//         writer.WriteEndElement();
//
//         writer.WriteStartElement(nameof(_fraction.Denominator));
//         writer.WriteValue(_fraction.Denominator.ToString(CultureInfo.InvariantCulture));
//         writer.WriteEndElement();
//
//         // if (_normalizationNotApplied)
//         // {
//         //     writer.WriteStartElement("NormalizationNotApplied");
//         //     writer.WriteValue(bool.TrueString);
//         //     writer.WriteEndElement();
//         // }
//     }
// }
