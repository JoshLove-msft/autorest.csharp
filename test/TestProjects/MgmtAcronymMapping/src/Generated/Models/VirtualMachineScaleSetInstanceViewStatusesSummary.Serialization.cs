// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace MgmtAcronymMapping.Models
{
    internal partial class VirtualMachineScaleSetInstanceViewStatusesSummary
    {
        internal static VirtualMachineScaleSetInstanceViewStatusesSummary DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VirtualMachineStatusCodeCount> statusesSummary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusesSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineStatusCodeCount> array = new List<VirtualMachineStatusCodeCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineStatusCodeCount.DeserializeVirtualMachineStatusCodeCount(item));
                    }
                    statusesSummary = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetInstanceViewStatusesSummary(statusesSummary ?? new ChangeTrackingList<VirtualMachineStatusCodeCount>());
        }
    }
}
