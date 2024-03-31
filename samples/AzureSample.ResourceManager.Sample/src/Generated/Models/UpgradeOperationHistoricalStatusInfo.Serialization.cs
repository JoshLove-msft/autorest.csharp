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

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class UpgradeOperationHistoricalStatusInfo : IUtf8JsonSerializable, IJsonModel<UpgradeOperationHistoricalStatusInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpgradeOperationHistoricalStatusInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpgradeOperationHistoricalStatusInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue<UpgradeOperationHistoricalStatusInfoProperties>(Properties, options);
            }
            if (options.Format != "W" && Optional.IsDefined(UpgradeOperationHistoricalStatusInfoType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(UpgradeOperationHistoricalStatusInfoType);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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

        UpgradeOperationHistoricalStatusInfo IJsonModel<UpgradeOperationHistoricalStatusInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpgradeOperationHistoricalStatusInfo(document.RootElement, options);
        }

        internal static UpgradeOperationHistoricalStatusInfo DeserializeUpgradeOperationHistoricalStatusInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpgradeOperationHistoricalStatusInfoProperties properties = default;
            string type = default;
            AzureLocation? location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = UpgradeOperationHistoricalStatusInfoProperties.DeserializeUpgradeOperationHistoricalStatusInfoProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpgradeOperationHistoricalStatusInfo(properties, type, location, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (Optional.IsDefined(Properties) || hasPropertyOverride)
            {
                builder.Append("  properties: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, Properties, options, 2, false, "  properties: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeOperationHistoricalStatusInfoType), out propertyOverride);
            if (Optional.IsDefined(UpgradeOperationHistoricalStatusInfoType) || hasPropertyOverride)
            {
                builder.Append("  type: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    if (UpgradeOperationHistoricalStatusInfoType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UpgradeOperationHistoricalStatusInfoType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UpgradeOperationHistoricalStatusInfoType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (Optional.IsDefined(Location) || hasPropertyOverride)
            {
                builder.Append("  location: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    builder.AppendLine($"'{Location.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<UpgradeOperationHistoricalStatusInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support writing '{options.Format}' format.");
            }
        }

        UpgradeOperationHistoricalStatusInfo IPersistableModel<UpgradeOperationHistoricalStatusInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpgradeOperationHistoricalStatusInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpgradeOperationHistoricalStatusInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
