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
::System.ClientModel.Primitives.IPersistableModel<VirtualMachineScaleSetSku>
{
internal static VirtualMachineScaleSetSku DeserializeVirtualMachineScaleSetSku(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        Optional<ResourceType> resourceType = default;
        Optional<SampleSku> sku = default;
        Optional<VirtualMachineScaleSetSkuCapacity> capacity = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("resourceType"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                resourceType = new ResourceType(property.Value.GetString());
                continue;
            }
            if (property.NameEquals("sku"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                sku = SampleSku.DeserializeSampleSku(property.Value);
                continue;
            }
            if (property.NameEquals("capacity"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                capacity = VirtualMachineScaleSetSkuCapacity.DeserializeVirtualMachineScaleSetSkuCapacity(property.Value);
                continue;
            }
        }
        return new VirtualMachineScaleSetSku(Optional.ToNullable(resourceType), sku.Value, capacity.Value);
    }

    private BinaryData SerializeBicep(ModelReaderWriterOptions options)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("{");

        if (Optional.IsDefined(ResourceType))
        {
            builder.Append("  resourceType:");
            builder.AppendLine($" '{ResourceType.ToString()}'");
        }

        if (Optional.IsDefined(Sku))
        {
            builder.Append("  sku:");
            AppendChildObject(builder, Sku, options, 2);
        }

        if (Optional.IsDefined(Capacity))
        {
            builder.Append("  capacity:");
            AppendChildObject(builder, Capacity, options, 2);
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
