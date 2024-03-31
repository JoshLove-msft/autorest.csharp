// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class DedicatedHostInstanceViewWithName : IUtf8JsonSerializable, IJsonModel<DedicatedHostInstanceViewWithName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHostInstanceViewWithName>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DedicatedHostInstanceViewWithName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostInstanceViewWithName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostInstanceViewWithName)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(AssetId))
            {
                writer.WritePropertyName("assetId"u8);
                writer.WriteStringValue(AssetId);
            }
            if (Optional.IsDefined(AvailableCapacity))
            {
                writer.WritePropertyName("availableCapacity"u8);
                writer.WriteObjectValue<DedicatedHostAvailableCapacity>(AvailableCapacity, options);
            }
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue<InstanceViewStatus>(item, options);
                }
                writer.WriteEndArray();
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

        DedicatedHostInstanceViewWithName IJsonModel<DedicatedHostInstanceViewWithName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostInstanceViewWithName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostInstanceViewWithName)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostInstanceViewWithName(document.RootElement, options);
        }

        internal static DedicatedHostInstanceViewWithName DeserializeDedicatedHostInstanceViewWithName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string assetId = default;
            DedicatedHostAvailableCapacity availableCapacity = default;
            IReadOnlyList<InstanceViewStatus> statuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetId"u8))
                {
                    assetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableCapacity = DedicatedHostAvailableCapacity.DeserializeDedicatedHostAvailableCapacity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item, options));
                    }
                    statuses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DedicatedHostInstanceViewWithName(assetId, availableCapacity, statuses ?? new ChangeTrackingList<InstanceViewStatus>(), serializedAdditionalRawData, name);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (Optional.IsDefined(Name) || hasPropertyOverride)
            {
                builder.Append("  name: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssetId), out propertyOverride);
            if (Optional.IsDefined(AssetId) || hasPropertyOverride)
            {
                builder.Append("  assetId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    if (AssetId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AssetId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AssetId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AvailableCapacityAllocatableVms", out propertyOverride);
            if (Optional.IsDefined(AvailableCapacity) || hasPropertyOverride)
            {
                builder.Append("  availableCapacity: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine("{");
                    builder.Append("    allocatableVMs: ");
                    builder.AppendLine(propertyOverride);
                    builder.AppendLine("  }");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, AvailableCapacity, options, 2, false, "  availableCapacity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Statuses), out propertyOverride);
            if (Optional.IsCollectionDefined(Statuses) || hasPropertyOverride)
            {
                if (Statuses.Any() || hasPropertyOverride)
                {
                    builder.Append("  statuses: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine(propertyOverride);
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Statuses)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  statuses: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DedicatedHostInstanceViewWithName>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostInstanceViewWithName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostInstanceViewWithName)} does not support writing '{options.Format}' format.");
            }
        }

        DedicatedHostInstanceViewWithName IPersistableModel<DedicatedHostInstanceViewWithName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostInstanceViewWithName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDedicatedHostInstanceViewWithName(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostInstanceViewWithName)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHostInstanceViewWithName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
