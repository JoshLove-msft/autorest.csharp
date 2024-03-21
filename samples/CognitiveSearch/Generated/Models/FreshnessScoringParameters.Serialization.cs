// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class FreshnessScoringParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("boostingDuration"u8);
            writer.WriteStringValue(BoostingDuration, "P");
            writer.WriteEndObject();
        }

        internal static FreshnessScoringParameters DeserializeFreshnessScoringParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan boostingDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boostingDuration"u8))
                {
                    boostingDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new FreshnessScoringParameters(boostingDuration);
        }
    }
}
