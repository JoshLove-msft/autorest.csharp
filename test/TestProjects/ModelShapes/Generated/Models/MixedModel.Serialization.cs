// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ModelShapes.Models
{
    public partial class MixedModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("RequiredString");
            writer.WriteStringValue(RequiredString);
            writer.WritePropertyName("RequiredInt");
            writer.WriteNumberValue(RequiredInt);
            writer.WritePropertyName("RequiredStringList");
            writer.WriteStartArray();
            foreach (var item in RequiredStringList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("RequiredIntList");
            writer.WriteStartArray();
            foreach (var item in RequiredIntList)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            if (NonRequiredString != null)
            {
                writer.WritePropertyName("NonRequiredString");
                writer.WriteStringValue(NonRequiredString);
            }
            if (NonRequiredInt != null)
            {
                writer.WritePropertyName("NonRequiredInt");
                writer.WriteNumberValue(NonRequiredInt.Value);
            }
            if (NonRequiredStringList != null)
            {
                writer.WritePropertyName("NonRequiredStringList");
                writer.WriteStartArray();
                foreach (var item in NonRequiredStringList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (NonRequiredIntList != null)
            {
                writer.WritePropertyName("NonRequiredIntList");
                writer.WriteStartArray();
                foreach (var item in NonRequiredIntList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequiredNullableStringList != null)
            {
                writer.WritePropertyName("RequiredNullableStringList");
                writer.WriteStartArray();
                foreach (var item in RequiredNullableStringList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("RequiredNullableStringList");
            }
            if (RequiredNullableIntList != null)
            {
                writer.WritePropertyName("RequiredNullableIntList");
                writer.WriteStartArray();
                foreach (var item in RequiredNullableIntList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("RequiredNullableIntList");
            }
            writer.WriteEndObject();
        }

        internal static MixedModel DeserializeMixedModel(JsonElement element)
        {
            string requiredString = default;
            int requiredInt = default;
            IList<string> requiredStringList = default;
            IList<int> requiredIntList = default;
            string nonRequiredString = default;
            int? nonRequiredInt = default;
            IList<string> nonRequiredStringList = default;
            IList<int> nonRequiredIntList = default;
            IList<string> requiredNullableStringList = default;
            IList<int> requiredNullableIntList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("RequiredString"))
                {
                    requiredString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("RequiredInt"))
                {
                    requiredInt = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("RequiredStringList"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    requiredStringList = array;
                    continue;
                }
                if (property.NameEquals("RequiredIntList"))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    requiredIntList = array;
                    continue;
                }
                if (property.NameEquals("NonRequiredString"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonRequiredString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NonRequiredInt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonRequiredInt = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("NonRequiredStringList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    nonRequiredStringList = array;
                    continue;
                }
                if (property.NameEquals("NonRequiredIntList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    nonRequiredIntList = array;
                    continue;
                }
                if (property.NameEquals("RequiredNullableStringList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    requiredNullableStringList = array;
                    continue;
                }
                if (property.NameEquals("RequiredNullableIntList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    requiredNullableIntList = array;
                    continue;
                }
            }
            return new MixedModel(requiredString, requiredInt, requiredStringList, requiredIntList, nonRequiredString, nonRequiredInt, nonRequiredStringList, nonRequiredIntList, requiredNullableStringList, requiredNullableIntList);
        }
    }
}
