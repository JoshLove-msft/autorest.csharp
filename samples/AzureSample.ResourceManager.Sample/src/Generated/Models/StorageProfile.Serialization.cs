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
    public partial class StorageProfile : IUtf8JsonSerializable, IJsonModel<StorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference"u8);
                writer.WriteObjectValue<ImageReference>(ImageReference, options);
            }
            if (Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue<OSDisk>(OSDisk, options);
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue<DataDisk>(item, options);
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

        StorageProfile IJsonModel<StorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageProfile(document.RootElement, options);
        }

        internal static StorageProfile DeserializeStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageReference imageReference = default;
            OSDisk osDisk = default;
            IList<DataDisk> dataDisks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = ImageReference.DeserializeImageReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = OSDisk.DeserializeOSDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataDisk> array = new List<DataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataDisk.DeserializeDataDisk(item, options));
                    }
                    dataDisks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageProfile(imageReference, osDisk, dataDisks ?? new ChangeTrackingList<DataDisk>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImageReference), out propertyOverride);
            if (Optional.IsDefined(ImageReference) || hasPropertyOverride)
            {
                builder.Append("  imageReference: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, ImageReference, options, 2, false, "  imageReference: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OSDisk), out propertyOverride);
            if (Optional.IsDefined(OSDisk) || hasPropertyOverride)
            {
                builder.Append("  osDisk: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine(propertyOverride);
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, OSDisk, options, 2, false, "  osDisk: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataDisks), out propertyOverride);
            if (Optional.IsCollectionDefined(DataDisks) || hasPropertyOverride)
            {
                if (DataDisks.Any() || hasPropertyOverride)
                {
                    builder.Append("  dataDisks: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine(propertyOverride);
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in DataDisks)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  dataDisks: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageProfile)} does not support writing '{options.Format}' format.");
            }
        }

        StorageProfile IPersistableModel<StorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
