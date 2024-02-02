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
    public partial class CacheKeyQueryStringActionParameters : IUtf8JsonSerializable, IJsonModel<CacheKeyQueryStringActionParameters>, IPersistableModel<CacheKeyQueryStringActionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CacheKeyQueryStringActionParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CacheKeyQueryStringActionParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CacheKeyQueryStringActionParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(TypeName.ToString());
            writer.WritePropertyName("queryStringBehavior"u8);
            writer.WriteStringValue(QueryStringBehavior.ToString());
            if (Optional.IsDefined(QueryParameters))
            {
                if (QueryParameters != null)
                {
                    writer.WritePropertyName("queryParameters"u8);
                    writer.WriteStringValue(QueryParameters);
                }
                else
                {
                    writer.WriteNull("queryParameters");
                }
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

        CacheKeyQueryStringActionParameters IJsonModel<CacheKeyQueryStringActionParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CacheKeyQueryStringActionParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCacheKeyQueryStringActionParameters(document.RootElement, options);
        }

        internal static CacheKeyQueryStringActionParameters DeserializeCacheKeyQueryStringActionParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CacheKeyQueryStringActionParametersTypeName typeName = default;
            QueryStringBehavior queryStringBehavior = default;
            Optional<string> queryParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new CacheKeyQueryStringActionParametersTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryStringBehavior"u8))
                {
                    queryStringBehavior = new QueryStringBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        queryParameters = null;
                        continue;
                    }
                    queryParameters = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CacheKeyQueryStringActionParameters(typeName, queryStringBehavior, queryParameters.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TypeName))
            {
                builder.Append("  typeName:");
                builder.AppendLine($" '{TypeName.ToString()}'");
            }

            if (Optional.IsDefined(QueryStringBehavior))
            {
                builder.Append("  queryStringBehavior:");
                builder.AppendLine($" '{QueryStringBehavior.ToString()}'");
            }

            if (Optional.IsDefined(QueryParameters))
            {
                builder.Append("  queryParameters:");
                builder.AppendLine($" '{QueryParameters}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            string firstLineIndent = new string(' ', spaces - 1);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{firstLineIndent}{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<CacheKeyQueryStringActionParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CacheKeyQueryStringActionParameters)} does not support '{options.Format}' format.");
            }
        }

        CacheKeyQueryStringActionParameters IPersistableModel<CacheKeyQueryStringActionParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCacheKeyQueryStringActionParameters(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CacheKeyQueryStringActionParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CacheKeyQueryStringActionParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
