// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using body_complex;

namespace body_complex.Models
{
    public partial class MyDerivedType : IUtf8JsonSerializable, IJsonModel<MyDerivedType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MyDerivedType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MyDerivedType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MyDerivedType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MyDerivedType)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PropD1))
            {
                writer.WritePropertyName("propD1"u8);
                writer.WriteStringValue(PropD1);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(PropB1))
            {
                writer.WritePropertyName("propB1"u8);
                writer.WriteStringValue(PropB1);
            }
            writer.WritePropertyName("helper"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PropBH1))
            {
                writer.WritePropertyName("propBH1"u8);
                writer.WriteStringValue(PropBH1);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MyDerivedType IJsonModel<MyDerivedType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MyDerivedType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MyDerivedType)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMyDerivedType(document.RootElement, options);
        }

        internal static MyDerivedType DeserializeMyDerivedType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string propD1 = default;
            MyKind kind = default;
            string propB1 = default;
            string propBH1 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propD1"u8))
                {
                    propD1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MyKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propB1"u8))
                {
                    propB1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("helper"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("propBH1"u8))
                        {
                            propBH1 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MyDerivedType(kind, propB1, propBH1, serializedAdditionalRawData, propD1);
        }

        BinaryData IPersistableModel<MyDerivedType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MyDerivedType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MyDerivedType)} does not support writing in '{options.Format}' format.");
            }
        }

        MyDerivedType IPersistableModel<MyDerivedType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MyDerivedType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMyDerivedType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MyDerivedType)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<MyDerivedType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
