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
::System.ClientModel.Primitives.IPersistableModel<VirtualMachineHealthStatus>
{
internal static VirtualMachineHealthStatus DeserializeVirtualMachineHealthStatus(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        Optional<InstanceViewStatus> status = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("status"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value);
                continue;
            }
        }
        return new VirtualMachineHealthStatus(status.Value);
    }

    private BinaryData SerializeBicep(ModelReaderWriterOptions options)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("{");

        if (Optional.IsDefined(Status))
        {
            builder.Append("  status:");
            AppendChildObject(builder, Status, options, 2);
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
