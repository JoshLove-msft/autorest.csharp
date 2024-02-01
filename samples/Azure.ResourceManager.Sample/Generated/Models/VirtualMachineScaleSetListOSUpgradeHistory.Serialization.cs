// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
::System.ClientModel.Primitives.IPersistableModel<VirtualMachineScaleSetListOSUpgradeHistory>
{
internal static VirtualMachineScaleSetListOSUpgradeHistory DeserializeVirtualMachineScaleSetListOSUpgradeHistory(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IReadOnlyList<UpgradeOperationHistoricalStatusInfo> value = default;
        Optional<ETag> etag = default;
        Optional<string> nextLink = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("value"u8))
            {
                List<UpgradeOperationHistoricalStatusInfo> array = new List<UpgradeOperationHistoricalStatusInfo>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(UpgradeOperationHistoricalStatusInfo.DeserializeUpgradeOperationHistoricalStatusInfo(item));
                }
                value = array;
                continue;
            }
            if (property.NameEquals("etag"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                etag = new ETag(property.Value.GetString());
                continue;
            }
            if (property.NameEquals("nextLink"u8))
            {
                nextLink = property.Value.GetString();
                continue;
            }
        }
        return new VirtualMachineScaleSetListOSUpgradeHistory(value, Optional.ToNullable(etag), nextLink.Value);
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

        if (Optional.IsDefined(Etag))
        {
            builder.Append("  etag:");
            builder.AppendLine($" '{Etag.ToString()}'");
        }

        if (Optional.IsDefined(NextLink))
        {
            builder.Append("  nextLink:");
            builder.AppendLine($" '{NextLink}'");
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
