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
using Azure.ResourceManager.Resources.Models;
using AzureSample.ResourceManager.Sample;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings);
            }
            if (Optional.IsCollectionDefined(IPTags))
            {
                writer.WritePropertyName("ipTags"u8);
                writer.WriteStartArray();
                foreach (var item in IPTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPPrefix))
            {
                writer.WritePropertyName("publicIPPrefix"u8);
                JsonSerializer.Serialize(writer, PublicIPPrefix);
            }
            if (Optional.IsDefined(PublicIPAddressVersion))
            {
                writer.WritePropertyName("publicIPAddressVersion"u8);
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
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

        VirtualMachineScaleSetPublicIPAddressConfiguration IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetPublicIPAddressConfiguration DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? idleTimeoutInMinutes = default;
            VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings = default;
            IList<VirtualMachineScaleSetIPTag> ipTags = default;
            WritableSubResource publicIPPrefix = default;
            IPVersion? publicIPAddressVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("idleTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings.DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualMachineScaleSetIPTag> array = new List<VirtualMachineScaleSetIPTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachineScaleSetIPTag.DeserializeVirtualMachineScaleSetIPTag(item, options));
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPPrefix = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
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
            return new VirtualMachineScaleSetPublicIPAddressConfiguration(
                name,
                idleTimeoutInMinutes,
                dnsSettings,
                ipTags ?? new ChangeTrackingList<VirtualMachineScaleSetIPTag>(),
                publicIPPrefix,
                publicIPAddressVersion,
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

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdleTimeoutInMinutes), out propertyOverride);
            if (Optional.IsDefined(IdleTimeoutInMinutes) || hasPropertyOverride)
            {
                builder.Append("    idleTimeoutInMinutes: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{IdleTimeoutInMinutes.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsSettings), out propertyOverride);
            if (Optional.IsDefined(DnsSettings) || hasPropertyOverride)
            {
                builder.Append("    dnsSettings: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, DnsSettings, options, 4, false, "    dnsSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IPTags), out propertyOverride);
            if (Optional.IsCollectionDefined(IPTags) || hasPropertyOverride)
            {
                if (IPTags.Any() || hasPropertyOverride)
                {
                    builder.Append("    ipTags: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in IPTags)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    ipTags: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicIPPrefix), out propertyOverride);
            if (Optional.IsDefined(PublicIPPrefix) || hasPropertyOverride)
            {
                builder.Append("    publicIPPrefix: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, PublicIPPrefix, options, 4, false, "    publicIPPrefix: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicIPAddressVersion), out propertyOverride);
            if (Optional.IsDefined(PublicIPAddressVersion) || hasPropertyOverride)
            {
                builder.Append("    publicIPAddressVersion: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{PublicIPAddressVersion.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetPublicIPAddressConfiguration IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}