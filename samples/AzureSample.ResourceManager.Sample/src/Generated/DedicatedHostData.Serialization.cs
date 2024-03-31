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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using AzureSample.ResourceManager.Sample.Models;

namespace AzureSample.ResourceManager.Sample
{
    public partial class DedicatedHostData : IUtf8JsonSerializable, IJsonModel<DedicatedHostData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHostData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DedicatedHostData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue<AzureSampleResourceManagerSampleSku>(Sku, options);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PlatformFaultDomain))
            {
                writer.WritePropertyName("platformFaultDomain"u8);
                writer.WriteNumberValue(PlatformFaultDomain.Value);
            }
            if (Optional.IsDefined(AutoReplaceOnFailure))
            {
                writer.WritePropertyName("autoReplaceOnFailure"u8);
                writer.WriteBooleanValue(AutoReplaceOnFailure.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HostId))
            {
                writer.WritePropertyName("hostId"u8);
                writer.WriteStringValue(HostId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualMachines))
            {
                writer.WritePropertyName("virtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningOn))
            {
                writer.WritePropertyName("provisioningTime"u8);
                writer.WriteStringValue(ProvisioningOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue<DedicatedHostInstanceView>(InstanceView, options);
            }
            writer.WriteEndObject();
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

        DedicatedHostData IJsonModel<DedicatedHostData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostData(document.RootElement, options);
        }

        internal static DedicatedHostData DeserializeDedicatedHostData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureSampleResourceManagerSampleSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? platformFaultDomain = default;
            bool? autoReplaceOnFailure = default;
            string hostId = default;
            IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> virtualMachines = default;
            DedicatedHostLicenseType? licenseType = default;
            DateTimeOffset? provisioningTime = default;
            string provisioningState = default;
            DedicatedHostInstanceView instanceView = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AzureSampleResourceManagerSampleSku.DeserializeAzureSampleResourceManagerSampleSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("platformFaultDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomain = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("autoReplaceOnFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoReplaceOnFailure = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostId"u8))
                        {
                            hostId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Azure.ResourceManager.Resources.Models.SubResource> array = new List<Azure.ResourceManager.Resources.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<Azure.ResourceManager.Resources.Models.SubResource>(item.GetRawText()));
                            }
                            virtualMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = property0.Value.GetString().ToDedicatedHostLicenseType();
                            continue;
                        }
                        if (property0.NameEquals("provisioningTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = DedicatedHostInstanceView.DeserializeDedicatedHostInstanceView(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DedicatedHostData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                platformFaultDomain,
                autoReplaceOnFailure,
                hostId,
                virtualMachines ?? new ChangeTrackingList<Azure.ResourceManager.Resources.Models.SubResource>(),
                licenseType,
                provisioningTime,
                provisioningState,
                instanceView,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            builder.Append("  location: ");
            if (hasPropertyOverride)
            {
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (Optional.IsCollectionDefined(Tags) || hasPropertyOverride)
            {
                if (Tags.Any() || hasPropertyOverride)
                {
                    builder.Append("  tags: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine(propertyOverride);
                    }
                    else
                    {
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sku), out propertyOverride);
            if (Optional.IsDefined(Sku) || hasPropertyOverride)
            {
                builder.Append("  sku: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (Optional.IsDefined(Id) || hasPropertyOverride)
            {
                builder.Append("  id: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (Optional.IsDefined(SystemData) || hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlatformFaultDomain), out propertyOverride);
            if (Optional.IsDefined(PlatformFaultDomain) || hasPropertyOverride)
            {
                builder.Append("    platformFaultDomain: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    builder.AppendLine($"{PlatformFaultDomain.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AutoReplaceOnFailure), out propertyOverride);
            if (Optional.IsDefined(AutoReplaceOnFailure) || hasPropertyOverride)
            {
                builder.Append("    autoReplaceOnFailure: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    var boolValue = AutoReplaceOnFailure.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostId), out propertyOverride);
            if (Optional.IsDefined(HostId) || hasPropertyOverride)
            {
                builder.Append("    hostId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    if (HostId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HostId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HostId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VirtualMachines), out propertyOverride);
            if (Optional.IsCollectionDefined(VirtualMachines) || hasPropertyOverride)
            {
                if (VirtualMachines.Any() || hasPropertyOverride)
                {
                    builder.Append("    virtualMachines: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine(propertyOverride);
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in VirtualMachines)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    virtualMachines: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LicenseType), out propertyOverride);
            if (Optional.IsDefined(LicenseType) || hasPropertyOverride)
            {
                builder.Append("    licenseType: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    builder.AppendLine($"'{LicenseType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningOn), out propertyOverride);
            if (Optional.IsDefined(ProvisioningOn) || hasPropertyOverride)
            {
                builder.Append("    provisioningTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(ProvisioningOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (Optional.IsDefined(ProvisioningState) || hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    if (ProvisioningState.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProvisioningState}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProvisioningState}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceView), out propertyOverride);
            if (Optional.IsDefined(InstanceView) || hasPropertyOverride)
            {
                builder.Append("    instanceView: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, InstanceView, options, 4, false, "    instanceView: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DedicatedHostData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostData)} does not support writing '{options.Format}' format.");
            }
        }

        DedicatedHostData IPersistableModel<DedicatedHostData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDedicatedHostData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHostData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
