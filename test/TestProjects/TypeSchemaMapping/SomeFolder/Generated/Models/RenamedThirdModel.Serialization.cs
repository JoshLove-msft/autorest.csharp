// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace CustomNamespace
{
    internal partial class RenamedThirdModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomizedETagProperty))
            {
                writer.WritePropertyName("ETag");
                writer.WriteStringValue(CustomizedETagProperty.ToString());
            }
            if (Optional.IsDefined(CustomizedCreatedAtProperty))
            {
                writer.WritePropertyName("CreatedAt");
                writer.WriteStringValue(CustomizedCreatedAtProperty);
            }
            writer.WriteEndObject();
        }

        internal static RenamedThirdModel DeserializeRenamedThirdModel(JsonElement element)
        {
            Optional<ETag> eTag = default;
            Optional<DateTime> createdAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ETag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("CreatedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdAt = property.Value.GetDateTime();
                    continue;
                }
            }
            return new RenamedThirdModel(eTag, createdAt);
        }
    }
}