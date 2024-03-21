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
using xml_service;

namespace xml_service.Models
{
    public partial class ModelWithByteProperty : IXmlSerializable, IPersistableModel<ModelWithByteProperty>
    {
        private void WriteInternal(XmlWriter writer, string nameHint, ModelReaderWriterOptions options)
        {
            writer.WriteStartElement(nameHint ?? "ModelWithByteProperty");
            if (Optional.IsDefined(Bytes))
            {
                writer.WriteStartElement("Bytes");
                writer.WriteValue(Bytes, "D");
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => WriteInternal(writer, nameHint, new ModelReaderWriterOptions("W"));

        internal static ModelWithByteProperty DeserializeModelWithByteProperty(XElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            byte[] bytes = default;
            if (element.Element("Bytes") is XElement bytesElement)
            {
                bytes = bytesElement.GetBytesFromBase64Value("D");
            }
            return new ModelWithByteProperty(bytes, serializedAdditionalRawData: null);
        }

        BinaryData IPersistableModel<ModelWithByteProperty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithByteProperty>)this).GetFormatFromOptions(options) : options.Format;

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
                    throw new FormatException($"The model {nameof(ModelWithByteProperty)} does not support writing in '{options.Format}' format.");
            }
        }

        ModelWithByteProperty IPersistableModel<ModelWithByteProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithByteProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    return DeserializeModelWithByteProperty(XElement.Load(data.ToStream()), options);
                default:
                    throw new FormatException($"The model {nameof(ModelWithByteProperty)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelWithByteProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "X";
    }
}
