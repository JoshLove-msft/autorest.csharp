// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class FloatWrapper : IUtf8JsonSerializable, IJsonModel<FloatWrapper>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FloatWrapper>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FloatWrapper>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FloatWrapper>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FloatWrapper)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Field1))
            {
                writer.WritePropertyName("field1"u8);
                writer.WriteNumberValue(Field1.Value);
            }
            if (Optional.IsDefined(Field2))
            {
                writer.WritePropertyName("field2"u8);
                writer.WriteNumberValue(Field2.Value);
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

        FloatWrapper IJsonModel<FloatWrapper>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FloatWrapper>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FloatWrapper)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFloatWrapper(document.RootElement, options);
        }

        internal static FloatWrapper DeserializeFloatWrapper(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> field1 = default;
            Optional<float> field2 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    field1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("field2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    field2 = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FloatWrapper(Optional.ToNullable(field1), Optional.ToNullable(field2), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FloatWrapper>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FloatWrapper>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(FloatWrapper)} does not support '{options.Format}' format.");
            }
        }

        FloatWrapper IPersistableModel<FloatWrapper>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FloatWrapper>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFloatWrapper(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(FloatWrapper)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FloatWrapper>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
