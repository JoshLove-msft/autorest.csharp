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
    public partial class VirtualMachineSoftwarePatchProperties : IUtf8JsonSerializable, IJsonModel<VirtualMachineSoftwarePatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineSoftwarePatchProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineSoftwarePatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PatchId))
            {
                writer.WritePropertyName("patchId"u8);
                writer.WriteStringValue(PatchId);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(Kbid))
            {
                writer.WritePropertyName("kbid"u8);
                writer.WriteStringValue(Kbid);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Classifications))
            {
                writer.WritePropertyName("classifications"u8);
                writer.WriteStartArray();
                foreach (var item in Classifications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(RebootBehavior))
            {
                writer.WritePropertyName("rebootBehavior"u8);
                writer.WriteStringValue(RebootBehavior.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            if (options.Format != "W" && Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("publishedDate"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AssessmentState))
            {
                writer.WritePropertyName("assessmentState"u8);
                writer.WriteStringValue(AssessmentState.Value.ToString());
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

        VirtualMachineSoftwarePatchProperties IJsonModel<VirtualMachineSoftwarePatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineSoftwarePatchProperties(document.RootElement, options);
        }

        internal static VirtualMachineSoftwarePatchProperties DeserializeVirtualMachineSoftwarePatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string patchId = default;
            string name = default;
            string version = default;
            string kbid = default;
            IReadOnlyList<string> classifications = default;
            SoftwareUpdateRebootBehavior? rebootBehavior = default;
            string activityId = default;
            DateTimeOffset? publishedDate = default;
            DateTimeOffset? lastModifiedDateTime = default;
            PatchAssessmentState? assessmentState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchId"u8))
                {
                    patchId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kbid"u8))
                {
                    kbid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("rebootBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootBehavior = new SoftwareUpdateRebootBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("assessmentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentState = new PatchAssessmentState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineSoftwarePatchProperties(
                patchId,
                name,
                version,
                kbid,
                classifications ?? new ChangeTrackingList<string>(),
                rebootBehavior,
                activityId,
                publishedDate,
                lastModifiedDateTime,
                assessmentState,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PatchId), out propertyOverride);
            if (Optional.IsDefined(PatchId) || hasPropertyOverride)
            {
                builder.Append("  patchId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (PatchId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PatchId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PatchId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (Optional.IsDefined(Name) || hasPropertyOverride)
            {
                builder.Append("  name: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (Optional.IsDefined(Version) || hasPropertyOverride)
            {
                builder.Append("  version: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Version.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Version}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Version}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kbid), out propertyOverride);
            if (Optional.IsDefined(Kbid) || hasPropertyOverride)
            {
                builder.Append("  kbid: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Kbid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kbid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kbid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Classifications), out propertyOverride);
            if (Optional.IsCollectionDefined(Classifications) || hasPropertyOverride)
            {
                if (Classifications.Any() || hasPropertyOverride)
                {
                    builder.Append("  classifications: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Classifications)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RebootBehavior), out propertyOverride);
            if (Optional.IsDefined(RebootBehavior) || hasPropertyOverride)
            {
                builder.Append("  rebootBehavior: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{RebootBehavior.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActivityId), out propertyOverride);
            if (Optional.IsDefined(ActivityId) || hasPropertyOverride)
            {
                builder.Append("  activityId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ActivityId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ActivityId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ActivityId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublishedOn), out propertyOverride);
            if (Optional.IsDefined(PublishedOn) || hasPropertyOverride)
            {
                builder.Append("  publishedDate: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(PublishedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastModifiedOn), out propertyOverride);
            if (Optional.IsDefined(LastModifiedOn) || hasPropertyOverride)
            {
                builder.Append("  lastModifiedDateTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(LastModifiedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssessmentState), out propertyOverride);
            if (Optional.IsDefined(AssessmentState) || hasPropertyOverride)
            {
                builder.Append("  assessmentState: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{AssessmentState.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<VirtualMachineSoftwarePatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineSoftwarePatchProperties IPersistableModel<VirtualMachineSoftwarePatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineSoftwarePatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineSoftwarePatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineSoftwarePatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineSoftwarePatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
