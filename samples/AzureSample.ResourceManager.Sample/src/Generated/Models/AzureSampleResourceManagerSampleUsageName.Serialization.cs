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
using Azure.ResourceManager;
using AzureSample.ResourceManager.Sample;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class AzureSampleResourceManagerSampleUsageName : IUtf8JsonSerializable, IJsonModel<AzureSampleResourceManagerSampleUsageName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureSampleResourceManagerSampleUsageName>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureSampleResourceManagerSampleUsageName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSampleResourceManagerSampleUsageName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSampleResourceManagerSampleUsageName)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(LocalizedValue))
            {
                writer.WritePropertyName("localizedValue"u8);
                writer.WriteStringValue(LocalizedValue);
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

        AzureSampleResourceManagerSampleUsageName IJsonModel<AzureSampleResourceManagerSampleUsageName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSampleResourceManagerSampleUsageName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSampleResourceManagerSampleUsageName)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureSampleResourceManagerSampleUsageName(document.RootElement, options);
        }

        internal static AzureSampleResourceManagerSampleUsageName DeserializeAzureSampleResourceManagerSampleUsageName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string value = default;
            string localizedValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedValue"u8))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureSampleResourceManagerSampleUsageName(value, localizedValue, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (Optional.IsDefined(Value) || hasPropertyOverride)
            {
                builder.Append("  value: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Value.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Value}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Value}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LocalizedValue), out propertyOverride);
            if (Optional.IsDefined(LocalizedValue) || hasPropertyOverride)
            {
                builder.Append("  localizedValue: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (LocalizedValue.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LocalizedValue}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LocalizedValue}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AzureSampleResourceManagerSampleUsageName>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSampleResourceManagerSampleUsageName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AzureSampleResourceManagerSampleUsageName)} does not support '{options.Format}' format.");
            }
        }

        AzureSampleResourceManagerSampleUsageName IPersistableModel<AzureSampleResourceManagerSampleUsageName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSampleResourceManagerSampleUsageName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureSampleResourceManagerSampleUsageName(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AzureSampleResourceManagerSampleUsageName)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureSampleResourceManagerSampleUsageName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
