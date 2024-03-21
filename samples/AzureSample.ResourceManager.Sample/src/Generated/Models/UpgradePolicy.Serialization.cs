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
    public partial class UpgradePolicy : IUtf8JsonSerializable, IJsonModel<UpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpgradePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpgradePolicy)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToSerialString());
            }
            if (Optional.IsDefined(RollingUpgradePolicy))
            {
                writer.WritePropertyName("rollingUpgradePolicy"u8);
                writer.WriteObjectValue(RollingUpgradePolicy);
            }
            if (Optional.IsDefined(AutomaticOSUpgradePolicy))
            {
                writer.WritePropertyName("automaticOSUpgradePolicy"u8);
                writer.WriteObjectValue(AutomaticOSUpgradePolicy);
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

        UpgradePolicy IJsonModel<UpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpgradePolicy)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpgradePolicy(document.RootElement, options);
        }

        internal static UpgradePolicy DeserializeUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpgradeMode? mode = default;
            RollingUpgradePolicy rollingUpgradePolicy = default;
            AutomaticOSUpgradePolicy automaticOSUpgradePolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = property.Value.GetString().ToUpgradeMode();
                    continue;
                }
                if (property.NameEquals("rollingUpgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingUpgradePolicy = RollingUpgradePolicy.DeserializeRollingUpgradePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("automaticOSUpgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticOSUpgradePolicy = AutomaticOSUpgradePolicy.DeserializeAutomaticOSUpgradePolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpgradePolicy(mode, rollingUpgradePolicy, automaticOSUpgradePolicy, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Mode))
            {
                builder.Append("  mode:");
                builder.AppendLine($" '{Mode.Value.ToSerialString()}'");
            }

            if (Optional.IsDefined(RollingUpgradePolicy))
            {
                builder.Append("  rollingUpgradePolicy:");
                AppendChildObject(builder, RollingUpgradePolicy, options, 2, false);
            }

            if (Optional.IsDefined(AutomaticOSUpgradePolicy))
            {
                builder.Append("  automaticOSUpgradePolicy:");
                AppendChildObject(builder, AutomaticOSUpgradePolicy, options, 2, false);
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

        BinaryData IPersistableModel<UpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UpgradePolicy)} does not support writing in '{options.Format}' format.");
            }
        }

        UpgradePolicy IPersistableModel<UpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpgradePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpgradePolicy)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
