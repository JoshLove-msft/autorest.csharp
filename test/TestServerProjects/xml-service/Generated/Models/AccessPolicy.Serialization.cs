// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class AccessPolicy : IXmlSerializable, IPersistableModel<AccessPolicy>
    {
        private void WriteInternal(XmlWriter writer, string nameHint, ModelReaderWriterOptions options)
        {
            writer.WriteStartElement(nameHint ?? "AccessPolicy");
            writer.WriteStartElement("Start");
            writer.WriteValue(Start, "O");
            writer.WriteEndElement();
            writer.WriteStartElement("Expiry");
            writer.WriteValue(Expiry, "O");
            writer.WriteEndElement();
            writer.WriteStartElement("Permission");
            writer.WriteValue(Permission);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => WriteInternal(writer, nameHint, new ModelReaderWriterOptions("W"));

        internal static AccessPolicy DeserializeAccessPolicy(XElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            DateTimeOffset start = default;
            DateTimeOffset expiry = default;
            string permission = default;
            if (element.Element("Start") is XElement startElement)
            {
                start = startElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Expiry") is XElement expiryElement)
            {
                expiry = expiryElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Permission") is XElement permissionElement)
            {
                permission = (string)permissionElement;
            }
            return new AccessPolicy(start, expiry, permission, serializedAdditionalRawData: null);
        }

        BinaryData IPersistableModel<AccessPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    {
                        using MemoryStream stream = new MemoryStream();
                        using XmlWriter writer = XmlWriter.Create(stream);
                        WriteInternal(writer, null, options);
                        writer.Flush();
                        return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessPolicy)} does not support writing in '{options.Format}' format.");
            }
        }

        AccessPolicy IPersistableModel<AccessPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    return DeserializeAccessPolicy(XElement.Load(data.ToStream()), options);
                default:
                    throw new FormatException($"The model {nameof(AccessPolicy)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "X";
    }
}
