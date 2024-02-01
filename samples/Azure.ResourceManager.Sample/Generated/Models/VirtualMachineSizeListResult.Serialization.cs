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

namespace Azure.ResourceManager.Sample.Models
{
::System.ClientModel.Primitives.IPersistableModel<VirtualMachineSizeListResult>
{
internal static VirtualMachineSizeListResult DeserializeVirtualMachineSizeListResult(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        Optional<IReadOnlyList<VirtualMachineSize>> value = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("value"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                List<VirtualMachineSize> array = new List<VirtualMachineSize>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(VirtualMachineSize.DeserializeVirtualMachineSize(item));
                }
                value = array;
                continue;
            }
        }
        return new VirtualMachineSizeListResult(Optional.ToList(value));
    }

    private BinaryData SerializeBicep(ModelReaderWriterOptions options)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("{");

        if (Optional.IsCollectionDefined(Value))
        {
            builder.Append("  value:");
            builder.AppendLine(" [");
            foreach (var item in Value)
            {
                AppendChildObject(builder, item, options, 4);
            }
            builder.AppendLine("  ]");
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
