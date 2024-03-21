// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace TypeSchemaMapping.Models
{
    [PersistableModelProxy(typeof(UnknownAbstractModel))]
    public partial class AbstractModel : IUtf8JsonSerializable, IJsonModel<AbstractModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AbstractModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AbstractModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbstractModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AbstractModel)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("DiscriminatorProperty"u8);
            writer.WriteStringValue(DiscriminatorProperty);
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

        AbstractModel IJsonModel<AbstractModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbstractModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AbstractModel)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAbstractModel(document.RootElement, options);
        }

        internal static AbstractModel DeserializeAbstractModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("DiscriminatorProperty", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DerivedFromAbstractModel": return DerivedFromAbstractModel.DeserializeDerivedFromAbstractModel(element, options);
                }
            }
            return UnknownAbstractModel.DeserializeUnknownAbstractModel(element, options);
        }

        BinaryData IPersistableModel<AbstractModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbstractModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AbstractModel)} does not support writing in '{options.Format}' format.");
            }
        }

        AbstractModel IPersistableModel<AbstractModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbstractModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAbstractModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AbstractModel)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<AbstractModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
