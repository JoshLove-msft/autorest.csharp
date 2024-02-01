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
::System.ClientModel.Primitives.IPersistableModel<DedicatedHostInstanceViewWithName>
{
internal static DedicatedHostInstanceViewWithName DeserializeDedicatedHostInstanceViewWithName(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        Optional<string> name = default;
        Optional<string> assetId = default;
        Optional<DedicatedHostAvailableCapacity> availableCapacity = default;
        Optional<IReadOnlyList<InstanceViewStatus>> statuses = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("name"u8))
            {
                name = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("assetId"u8))
            {
                assetId = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("availableCapacity"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                availableCapacity = DedicatedHostAvailableCapacity.DeserializeDedicatedHostAvailableCapacity(property.Value);
                continue;
            }
            if (property.NameEquals("statuses"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                }
                statuses = array;
                continue;
            }
        }
        return new DedicatedHostInstanceViewWithName(assetId.Value, availableCapacity.Value, Optional.ToList(statuses), name.Value);
    }

    private BinaryData SerializeBicep(ModelReaderWriterOptions options)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("{");

        if (Optional.IsDefined(Name))
        {
            builder.Append("  name:");
            builder.AppendLine($" '{Name}'");
        }

        if (Optional.IsDefined(AssetId))
        {
            builder.Append("  assetId:");
            builder.AppendLine($" '{AssetId}'");
        }

        if (Optional.IsDefined(AvailableCapacity))
        {
            builder.Append("  availableCapacity:");
            AppendChildObject(builder, AvailableCapacity, options, 2);
        }

        if (Optional.IsCollectionDefined(Statuses))
        {
            builder.Append("  statuses:");
            builder.AppendLine(" [");
            foreach (var item in Statuses)
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
