// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Pagination.Models
{
    public partial class LedgerEntry : IUtf8JsonSerializable, IJsonModel<LedgerEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LedgerEntry>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LedgerEntry>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LedgerEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LedgerEntry)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("contents"u8);
            writer.WriteStringValue(Contents);
            if (options.Format != "W")
            {
                writer.WritePropertyName("collectionId"u8);
                writer.WriteStringValue(CollectionId);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("transactionId"u8);
                writer.WriteStringValue(TransactionId);
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

        LedgerEntry IJsonModel<LedgerEntry>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LedgerEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LedgerEntry)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLedgerEntry(document.RootElement, options);
        }

        internal static LedgerEntry DeserializeLedgerEntry(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contents = default;
            string collectionId = default;
            string transactionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contents"u8))
                {
                    contents = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionId"u8))
                {
                    collectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LedgerEntry(contents, collectionId, transactionId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LedgerEntry>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LedgerEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LedgerEntry)} does not support writing in '{options.Format}' format.");
            }
        }

        LedgerEntry IPersistableModel<LedgerEntry>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LedgerEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLedgerEntry(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LedgerEntry)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<LedgerEntry>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LedgerEntry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLedgerEntry(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
