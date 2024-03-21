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
using AzureSample.ResourceManager.Sample;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetSkuCapacity : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetSkuCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetSkuCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetSkuCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetSkuCapacity)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Minimum))
            {
                writer.WritePropertyName("minimum"u8);
                writer.WriteNumberValue(Minimum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Maximum))
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultCapacity))
            {
                writer.WritePropertyName("defaultCapacity"u8);
                writer.WriteNumberValue(DefaultCapacity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScaleType))
            {
                writer.WritePropertyName("scaleType"u8);
                writer.WriteStringValue(ScaleType.Value.ToSerialString());
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

        VirtualMachineScaleSetSkuCapacity IJsonModel<VirtualMachineScaleSetSkuCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetSkuCapacity)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetSkuCapacity(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetSkuCapacity DeserializeVirtualMachineScaleSetSkuCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? minimum = default;
            long? maximum = default;
            long? defaultCapacity = default;
            VirtualMachineScaleSetSkuScaleType? scaleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = property.Value.GetString().ToVirtualMachineScaleSetSkuScaleType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetSkuCapacity(minimum, maximum, defaultCapacity, scaleType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Minimum))
            {
                builder.Append("  minimum:");
                builder.AppendLine($" '{Minimum.Value.ToString()}'");
            }

            if (Optional.IsDefined(Maximum))
            {
                builder.Append("  maximum:");
                builder.AppendLine($" '{Maximum.Value.ToString()}'");
            }

            if (Optional.IsDefined(DefaultCapacity))
            {
                builder.Append("  defaultCapacity:");
                builder.AppendLine($" '{DefaultCapacity.Value.ToString()}'");
            }

            if (Optional.IsDefined(ScaleType))
            {
                builder.Append("  scaleType:");
                builder.AppendLine($" '{ScaleType.Value.ToSerialString()}'");
            }

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

        BinaryData IPersistableModel<VirtualMachineScaleSetSkuCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetSkuCapacity)} does not support writing in '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetSkuCapacity IPersistableModel<VirtualMachineScaleSetSkuCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetSkuCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetSkuCapacity)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetSkuCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
