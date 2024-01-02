// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    public partial class UrlRewriteActionParameters : IUtf8JsonSerializable, IJsonModel<UrlRewriteActionParameters>, IPersistableModel<UrlRewriteActionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UrlRewriteActionParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UrlRewriteActionParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlRewriteActionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(UrlRewriteActionParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(TypeName.ToString());
            writer.WritePropertyName("sourcePattern"u8);
            writer.WriteStringValue(SourcePattern);
            writer.WritePropertyName("destination"u8);
            writer.WriteStringValue(Destination);
            if (Optional.IsDefined(PreserveUnmatchedPath))
            {
                writer.WritePropertyName("preserveUnmatchedPath"u8);
                writer.WriteBooleanValue(PreserveUnmatchedPath.Value);
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

        UrlRewriteActionParameters IJsonModel<UrlRewriteActionParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlRewriteActionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(UrlRewriteActionParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUrlRewriteActionParameters(document.RootElement, options);
        }

        internal static UrlRewriteActionParameters DeserializeUrlRewriteActionParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UrlRewriteActionParametersTypeName typeName = default;
            string sourcePattern = default;
            string destination = default;
            Optional<bool> preserveUnmatchedPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new UrlRewriteActionParametersTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourcePattern"u8))
                {
                    sourcePattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preserveUnmatchedPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveUnmatchedPath = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UrlRewriteActionParameters(typeName, sourcePattern, destination, Optional.ToNullable(preserveUnmatchedPath), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"TypeName: '{TypeName}'");
            sb.AppendChildObject(SourcePattern, options);
            sb.AppendChildObject(Destination, options);
            sb.AppendLine($"PreserveUnmatchedPath: '{PreserveUnmatchedPath}'");
            return BinaryData.FromString(sb.ToString());
        }

        BinaryData IPersistableModel<UrlRewriteActionParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlRewriteActionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new InvalidOperationException($"The model {nameof(UrlRewriteActionParameters)} does not support '{options.Format}' format.");
            }
        }

        UrlRewriteActionParameters IPersistableModel<UrlRewriteActionParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlRewriteActionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUrlRewriteActionParameters(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new InvalidOperationException($"The model {nameof(UrlRewriteActionParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UrlRewriteActionParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
