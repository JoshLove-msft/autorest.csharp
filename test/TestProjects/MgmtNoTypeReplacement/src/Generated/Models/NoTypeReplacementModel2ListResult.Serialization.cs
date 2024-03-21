// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace MgmtNoTypeReplacement.Models
{
    internal partial class NoTypeReplacementModel2ListResult
    {
        internal static NoTypeReplacementModel2ListResult DeserializeNoTypeReplacementModel2ListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NoTypeReplacementModel2Data> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NoTypeReplacementModel2Data> array = new List<NoTypeReplacementModel2Data>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NoTypeReplacementModel2Data.DeserializeNoTypeReplacementModel2Data(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NoTypeReplacementModel2ListResult(value ?? new ChangeTrackingList<NoTypeReplacementModel2Data>(), nextLink);
        }
    }
}
