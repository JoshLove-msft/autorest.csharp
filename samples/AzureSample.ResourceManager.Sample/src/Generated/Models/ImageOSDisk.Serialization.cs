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
using Azure.ResourceManager.Resources.Models;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class ImageOSDisk : IUtf8JsonSerializable, IJsonModel<ImageOSDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageOSDisk>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageOSDisk>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageOSDisk>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageOSDisk)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToSerialString());
            writer.WritePropertyName("osState"u8);
            writer.WriteStringValue(OSState.ToSerialString());
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot"u8);
                JsonSerializer.Serialize(writer, Snapshot);
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk"u8);
                JsonSerializer.Serialize(writer, ManagedDisk);
            }
            if (Optional.IsDefined(BlobUri))
            {
                writer.WritePropertyName("blobUri"u8);
                writer.WriteStringValue(BlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching"u8);
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType"u8);
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(DiskEncryptionSet))
            {
                writer.WritePropertyName("diskEncryptionSet"u8);
                JsonSerializer.Serialize(writer, DiskEncryptionSet);
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

        ImageOSDisk IJsonModel<ImageOSDisk>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageOSDisk>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageOSDisk)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageOSDisk(document.RootElement, options);
        }

        internal static ImageOSDisk DeserializeImageOSDisk(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperatingSystemType osType = default;
            OperatingSystemStateType osState = default;
            WritableSubResource snapshot = default;
            WritableSubResource managedDisk = default;
            Uri blobUri = default;
            CachingType? caching = default;
            int? diskSizeGB = default;
            StorageAccountType? storageAccountType = default;
            WritableSubResource diskEncryptionSet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString().ToOperatingSystemType();
                    continue;
                }
                if (property.NameEquals("osState"u8))
                {
                    osState = property.Value.GetString().ToOperatingSystemStateType();
                    continue;
                }
                if (property.NameEquals("snapshot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshot = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("managedDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedDisk = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("blobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("caching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingType();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new StorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSet = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageOSDisk(
                snapshot,
                managedDisk,
                blobUri,
                caching,
                diskSizeGB,
                storageAccountType,
                diskEncryptionSet,
                serializedAdditionalRawData,
                osType,
                osState);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OSType), out propertyOverride);
            builder.Append("  osType: ");
            if (hasPropertyOverride)
            {
                builder.AppendLine($"{propertyOverride}");
            }
            else
            {
                builder.AppendLine($"'{OSType.ToSerialString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OSState), out propertyOverride);
            builder.Append("  osState: ");
            if (hasPropertyOverride)
            {
                builder.AppendLine($"{propertyOverride}");
            }
            else
            {
                builder.AppendLine($"'{OSState.ToSerialString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Snapshot), out propertyOverride);
            if (Optional.IsDefined(Snapshot) || hasPropertyOverride)
            {
                builder.Append("  snapshot: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, Snapshot, options, 2, false, "  snapshot: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedDisk), out propertyOverride);
            if (Optional.IsDefined(ManagedDisk) || hasPropertyOverride)
            {
                builder.Append("  managedDisk: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, ManagedDisk, options, 2, false, "  managedDisk: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobUri), out propertyOverride);
            if (Optional.IsDefined(BlobUri) || hasPropertyOverride)
            {
                builder.Append("  blobUri: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{BlobUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Caching), out propertyOverride);
            if (Optional.IsDefined(Caching) || hasPropertyOverride)
            {
                builder.Append("  caching: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Caching.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DiskSizeGB), out propertyOverride);
            if (Optional.IsDefined(DiskSizeGB) || hasPropertyOverride)
            {
                builder.Append("  diskSizeGB: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{DiskSizeGB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountType), out propertyOverride);
            if (Optional.IsDefined(StorageAccountType) || hasPropertyOverride)
            {
                builder.Append("  storageAccountType: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{StorageAccountType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DiskEncryptionSet), out propertyOverride);
            if (Optional.IsDefined(DiskEncryptionSet) || hasPropertyOverride)
            {
                builder.Append("  diskEncryptionSet: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, DiskEncryptionSet, options, 2, false, "  diskEncryptionSet: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ImageOSDisk>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageOSDisk>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ImageOSDisk)} does not support writing in '{options.Format}' format.");
            }
        }

        ImageOSDisk IPersistableModel<ImageOSDisk>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageOSDisk>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageOSDisk(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageOSDisk)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageOSDisk>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
