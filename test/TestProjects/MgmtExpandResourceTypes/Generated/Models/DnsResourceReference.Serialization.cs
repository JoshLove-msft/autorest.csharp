// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.ResourceManager.Resources.Models;
using MgmtExpandResourceTypes;

namespace MgmtExpandResourceTypes.Models
{
    public partial class DnsResourceReference
    {
        internal static DnsResourceReference DeserializeDnsResourceReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<WritableSubResource> dnsResources = default;
            WritableSubResource targetResource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    dnsResources = array;
                    continue;
                }
                if (property.NameEquals("targetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResource = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new DnsResourceReference(dnsResources ?? new ChangeTrackingList<WritableSubResource>(), targetResource);
        }
    }
}
