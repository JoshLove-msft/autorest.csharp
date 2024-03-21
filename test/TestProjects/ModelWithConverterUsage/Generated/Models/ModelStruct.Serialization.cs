// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace ModelWithConverterUsage.Models
{
    [JsonConverter(typeof(ModelStructConverter))]
    public partial struct ModelStruct : IUtf8JsonSerializable, IJsonModel<ModelStruct>, IJsonModel<object>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelStruct>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ModelStruct>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelStruct>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelStruct)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ModelProperty))
            {
                writer.WritePropertyName("Model_Property"u8);
                writer.WriteStringValue(ModelProperty);
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

        ModelStruct IJsonModel<ModelStruct>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelStruct>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelStruct)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelStruct(document.RootElement, options);
        }

        void IJsonModel<object>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ModelStruct>)this).Write(writer, options);

        object IJsonModel<object>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ModelStruct>)this).Create(ref reader, options);

        internal static ModelStruct DeserializeModelStruct(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            string modelProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Model_Property"u8))
                {
                    modelProperty = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ModelStruct(modelProperty, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModelStruct>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelStruct>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelStruct)} does not support writing in '{options.Format}' format.");
            }
        }

        ModelStruct IPersistableModel<ModelStruct>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelStruct>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelStruct(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelStruct)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelStruct>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        BinaryData IPersistableModel<object>.Write(ModelReaderWriterOptions options) => ((IPersistableModel<ModelStruct>)this).Write(options);

        object IPersistableModel<object>.Create(BinaryData data, ModelReaderWriterOptions options) => ((IPersistableModel<ModelStruct>)this).Create(data, options);

        string IPersistableModel<object>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ModelStruct>)this).GetFormatFromOptions(options);

        internal partial class ModelStructConverter : JsonConverter<ModelStruct>
        {
            public override void Write(Utf8JsonWriter writer, ModelStruct model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ModelStruct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeModelStruct(document.RootElement);
            }
        }
    }
}
