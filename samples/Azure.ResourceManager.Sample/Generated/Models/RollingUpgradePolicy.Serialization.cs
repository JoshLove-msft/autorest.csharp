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

namespace Azure.ResourceManager.Sample.Models
{
    public partial class RollingUpgradePolicy : IUtf8JsonSerializable, IJsonModel<RollingUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RollingUpgradePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RollingUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxBatchInstancePercent))
            {
                writer.WritePropertyName("maxBatchInstancePercent"u8);
                writer.WriteNumberValue(MaxBatchInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyUpgradedInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyUpgradedInstancePercent.Value);
            }
            if (Optional.IsDefined(PauseTimeBetweenBatches))
            {
                writer.WritePropertyName("pauseTimeBetweenBatches"u8);
                writer.WriteStringValue(PauseTimeBetweenBatches);
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

        RollingUpgradePolicy IJsonModel<RollingUpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRollingUpgradePolicy(document.RootElement, options);
        }

        internal static RollingUpgradePolicy DeserializeRollingUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxBatchInstancePercent = default;
            Optional<int> maxUnhealthyInstancePercent = default;
            Optional<int> maxUnhealthyUpgradedInstancePercent = default;
            Optional<string> pauseTimeBetweenBatches = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxBatchInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBatchInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyUpgradedInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyUpgradedInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pauseTimeBetweenBatches"u8))
                {
                    pauseTimeBetweenBatches = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RollingUpgradePolicy(Optional.ToNullable(maxBatchInstancePercent), Optional.ToNullable(maxUnhealthyInstancePercent), Optional.ToNullable(maxUnhealthyUpgradedInstancePercent), pauseTimeBetweenBatches.Value, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxBatchInstancePercent), out propertyOverride);
            if (Optional.IsDefined(MaxBatchInstancePercent) || hasPropertyOverride)
            {
                builder.Append("  maxBatchInstancePercent: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MaxBatchInstancePercent.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxUnhealthyInstancePercent), out propertyOverride);
            if (Optional.IsDefined(MaxUnhealthyInstancePercent) || hasPropertyOverride)
            {
                builder.Append("  maxUnhealthyInstancePercent: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MaxUnhealthyInstancePercent.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxUnhealthyUpgradedInstancePercent), out propertyOverride);
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent) || hasPropertyOverride)
            {
                builder.Append("  maxUnhealthyUpgradedInstancePercent: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MaxUnhealthyUpgradedInstancePercent.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PauseTimeBetweenBatches), out propertyOverride);
            if (Optional.IsDefined(PauseTimeBetweenBatches) || hasPropertyOverride)
            {
                builder.Append("  pauseTimeBetweenBatches: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (PauseTimeBetweenBatches.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PauseTimeBetweenBatches}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PauseTimeBetweenBatches}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<RollingUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{options.Format}' format.");
            }
        }

        RollingUpgradePolicy IPersistableModel<RollingUpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRollingUpgradePolicy(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RollingUpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
