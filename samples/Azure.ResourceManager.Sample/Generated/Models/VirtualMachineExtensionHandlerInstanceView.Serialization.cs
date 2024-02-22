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
    public partial class VirtualMachineExtensionHandlerInstanceView : IUtf8JsonSerializable, IJsonModel<VirtualMachineExtensionHandlerInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineExtensionHandlerInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineExtensionHandlerInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachineExtensionHandlerInstanceViewType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(VirtualMachineExtensionHandlerInstanceViewType);
            }
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
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

        VirtualMachineExtensionHandlerInstanceView IJsonModel<VirtualMachineExtensionHandlerInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineExtensionHandlerInstanceView(document.RootElement, options);
        }

        internal static VirtualMachineExtensionHandlerInstanceView DeserializeVirtualMachineExtensionHandlerInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<InstanceViewStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineExtensionHandlerInstanceView(type.Value, typeHandlerVersion.Value, status.Value, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TypeHandlerVersion), out propertyOverride);
            if (Optional.IsDefined(TypeHandlerVersion) || hasPropertyOverride)
            {
                builder.Append("  typeHandlerVersion: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (TypeHandlerVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TypeHandlerVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TypeHandlerVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (Optional.IsDefined(Status) || hasPropertyOverride)
            {
                builder.Append("  status: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, Status, options, 2, false, "  status: ");
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

        BinaryData IPersistableModel<VirtualMachineExtensionHandlerInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineExtensionHandlerInstanceView IPersistableModel<VirtualMachineExtensionHandlerInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineExtensionHandlerInstanceView(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineExtensionHandlerInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
