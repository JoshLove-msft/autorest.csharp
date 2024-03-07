// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using TypeSchemaMapping;

namespace TypeSchemaMapping.Models
{
    public partial class PublicModelWithInternalProperty : IUtf8JsonSerializable, IJsonModel<PublicModelWithInternalProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicModelWithInternalProperty>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PublicModelWithInternalProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicModelWithInternalProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicModelWithInternalProperty)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StringPropertyJson))
            {
                writer.WritePropertyName("InternalProperty"u8);
                StringPropertyJson.WriteTo(writer);
            }
            if (Optional.IsDefined(PublicProperty))
            {
                writer.WritePropertyName("PublicProperty"u8);
                writer.WriteStringValue(PublicProperty);
            }
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

        PublicModelWithInternalProperty IJsonModel<PublicModelWithInternalProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicModelWithInternalProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicModelWithInternalProperty)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicModelWithInternalProperty(document.RootElement, options);
        }

        internal static PublicModelWithInternalProperty DeserializePublicModelWithInternalProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            JsonElement internalProperty = default;
            string publicProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("InternalProperty"u8))
                {
                    internalProperty = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("PublicProperty"u8))
                {
                    publicProperty = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PublicModelWithInternalProperty(internalProperty, publicProperty, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PublicModelWithInternalProperty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicModelWithInternalProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PublicModelWithInternalProperty)} does not support '{options.Format}' format.");
            }
        }

        PublicModelWithInternalProperty IPersistableModel<PublicModelWithInternalProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicModelWithInternalProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublicModelWithInternalProperty(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublicModelWithInternalProperty)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublicModelWithInternalProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
