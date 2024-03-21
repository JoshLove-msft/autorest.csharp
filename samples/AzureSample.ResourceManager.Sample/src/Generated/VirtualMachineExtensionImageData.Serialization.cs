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
using Azure.ResourceManager.Models;

namespace AzureSample.ResourceManager.Sample
{
    public partial class VirtualMachineExtensionImageData : IUtf8JsonSerializable, IJsonModel<VirtualMachineExtensionImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineExtensionImageData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineExtensionImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(OperatingSystem))
            {
                writer.WritePropertyName("operatingSystem"u8);
                writer.WriteStringValue(OperatingSystem);
            }
            if (Optional.IsDefined(ComputeRole))
            {
                writer.WritePropertyName("computeRole"u8);
                writer.WriteStringValue(ComputeRole);
            }
            if (Optional.IsDefined(HandlerSchema))
            {
                writer.WritePropertyName("handlerSchema"u8);
                writer.WriteStringValue(HandlerSchema);
            }
            if (Optional.IsDefined(VmScaleSetEnabled))
            {
                writer.WritePropertyName("vmScaleSetEnabled"u8);
                writer.WriteBooleanValue(VmScaleSetEnabled.Value);
            }
            if (Optional.IsDefined(SupportsMultipleExtensions))
            {
                writer.WritePropertyName("supportsMultipleExtensions"u8);
                writer.WriteBooleanValue(SupportsMultipleExtensions.Value);
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

        VirtualMachineExtensionImageData IJsonModel<VirtualMachineExtensionImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineExtensionImageData(document.RootElement, options);
        }

        internal static VirtualMachineExtensionImageData DeserializeVirtualMachineExtensionImageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string operatingSystem = default;
            string computeRole = default;
            string handlerSchema = default;
            bool? vmScaleSetEnabled = default;
            bool? supportsMultipleExtensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("operatingSystem"u8))
                        {
                            operatingSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeRole"u8))
                        {
                            computeRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("handlerSchema"u8))
                        {
                            handlerSchema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmScaleSetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmScaleSetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("supportsMultipleExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsMultipleExtensions = property0.Value.GetBoolean();
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
            return new VirtualMachineExtensionImageData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                operatingSystem,
                computeRole,
                handlerSchema,
                vmScaleSetEnabled,
                supportsMultipleExtensions,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            builder.Append("  location:");
            builder.AppendLine($" '{Location.ToString()}'");

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}:");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Value.Contains(Environment.NewLine))
                        {
                            builder.AppendLine(" '''");
                            builder.AppendLine($"{item.Value}'''");
                        }
                        else
                        {
                            builder.AppendLine($" '{item.Value}'");
                        }
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(OperatingSystem))
            {
                builder.Append("    operatingSystem:");
                if (OperatingSystem.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{OperatingSystem}'''");
                }
                else
                {
                    builder.AppendLine($" '{OperatingSystem}'");
                }
            }

            if (Optional.IsDefined(ComputeRole))
            {
                builder.Append("    computeRole:");
                if (ComputeRole.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ComputeRole}'''");
                }
                else
                {
                    builder.AppendLine($" '{ComputeRole}'");
                }
            }

            if (Optional.IsDefined(HandlerSchema))
            {
                builder.Append("    handlerSchema:");
                if (HandlerSchema.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{HandlerSchema}'''");
                }
                else
                {
                    builder.AppendLine($" '{HandlerSchema}'");
                }
            }

            if (Optional.IsDefined(VmScaleSetEnabled))
            {
                builder.Append("    vmScaleSetEnabled:");
                var boolValue = VmScaleSetEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(SupportsMultipleExtensions))
            {
                builder.Append("    supportsMultipleExtensions:");
                var boolValue = SupportsMultipleExtensions.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
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
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<VirtualMachineExtensionImageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support writing in '{options.Format}' format.");
            }
        }

        VirtualMachineExtensionImageData IPersistableModel<VirtualMachineExtensionImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineExtensionImageData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineExtensionImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
