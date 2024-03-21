// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;
using ModelsTypeSpec;

namespace ModelsTypeSpec.Models
{
    [PersistableModelProxy(typeof(UnknownBaseModelWithDiscriminatorDefinedOnBase))]
    public partial class BaseModelWithDiscriminatorDefinedOnBase : IUtf8JsonSerializable, IJsonModel<BaseModelWithDiscriminatorDefinedOnBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BaseModelWithDiscriminatorDefinedOnBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BaseModelWithDiscriminatorDefinedOnBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorDefinedOnBase)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OptionalString))
            {
                writer.WritePropertyName("optionalString"u8);
                writer.WriteStringValue(OptionalString);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        BaseModelWithDiscriminatorDefinedOnBase IJsonModel<BaseModelWithDiscriminatorDefinedOnBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorDefinedOnBase)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBaseModelWithDiscriminatorDefinedOnBase(document.RootElement, options);
        }

        internal static BaseModelWithDiscriminatorDefinedOnBase DeserializeBaseModelWithDiscriminatorDefinedOnBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A": return DerivedWithDiscriminatorDefinedOnBase.DeserializeDerivedWithDiscriminatorDefinedOnBase(element, options);
                }
            }
            return UnknownBaseModelWithDiscriminatorDefinedOnBase.DeserializeUnknownBaseModelWithDiscriminatorDefinedOnBase(element, options);
        }

        BinaryData IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorDefinedOnBase)} does not support writing in '{options.Format}' format.");
            }
        }

        BaseModelWithDiscriminatorDefinedOnBase IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBaseModelWithDiscriminatorDefinedOnBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorDefinedOnBase)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<BaseModelWithDiscriminatorDefinedOnBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new BaseModelWithDiscriminatorDefinedOnBase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBaseModelWithDiscriminatorDefinedOnBase(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
