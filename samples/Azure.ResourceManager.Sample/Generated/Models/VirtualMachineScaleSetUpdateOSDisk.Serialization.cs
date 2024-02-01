// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetUpdateOSDisk : IUtf8JsonSerializable, IPersistableModel<VirtualMachineScaleSetUpdateOSDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching"u8);
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (Optional.IsDefined(WriteAcceleratorEnabled))
            {
                writer.WritePropertyName("writeAcceleratorEnabled"u8);
                writer.WriteBooleanValue(WriteAcceleratorEnabled.Value);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteObjectValue(Image);
            }
            if (Optional.IsCollectionDefined(VhdContainers))
            {
                writer.WritePropertyName("vhdContainers"u8);
                writer.WriteStartArray();
                foreach (var item in VhdContainers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk"u8);
                writer.WriteObjectValue(ManagedDisk);
            }
            writer.WriteEndObject();
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Caching))
            {
                builder.Append("  caching:");
                builder.AppendLine($" '{Caching.ToString()}'");
            }

            if (Optional.IsDefined(WriteAcceleratorEnabled))
            {
                builder.Append("  writeAcceleratorEnabled:");
                var boolValue = WriteAcceleratorEnabled == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(DiskSizeGB))
            {
                builder.Append("  diskSizeGB:");
                builder.AppendLine($" '{DiskSizeGB.ToString()}'");
            }

            if (Optional.IsDefined(Image))
            {
                builder.Append("  image:");
                AppendChildObject(builder, Image, options, 2);
            }

            if (Optional.IsCollectionDefined(VhdContainers))
            {
                builder.Append("  vhdContainers:");
                builder.AppendLine(" [");
                foreach (var item in VhdContainers)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(ManagedDisk))
            {
                builder.Append("  managedDisk:");
                AppendChildObject(builder, ManagedDisk, options, 2);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }
    }
}
