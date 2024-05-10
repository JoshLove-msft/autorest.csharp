// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    public partial class DifferentSpreadFloatRecord : IJsonModel<DifferentSpreadFloatRecord>
    {
        void IJsonModel<DifferentSpreadFloatRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DifferentSpreadFloatRecord)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteNumberValue(item.Value);
            }
            writer.WriteEndObject();
        }

        DifferentSpreadFloatRecord IJsonModel<DifferentSpreadFloatRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DifferentSpreadFloatRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDifferentSpreadFloatRecord(document.RootElement, options);
        }

        internal static DifferentSpreadFloatRecord DeserializeDifferentSpreadFloatRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IDictionary<string, float> additionalProperties = default;
            Dictionary<string, float> additionalPropertiesDictionary = new Dictionary<string, float>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetSingle());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DifferentSpreadFloatRecord(name, additionalProperties);
        }

        BinaryData IPersistableModel<DifferentSpreadFloatRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DifferentSpreadFloatRecord)} does not support writing '{options.Format}' format.");
            }
        }

        DifferentSpreadFloatRecord IPersistableModel<DifferentSpreadFloatRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDifferentSpreadFloatRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DifferentSpreadFloatRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DifferentSpreadFloatRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static DifferentSpreadFloatRecord FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDifferentSpreadFloatRecord(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}