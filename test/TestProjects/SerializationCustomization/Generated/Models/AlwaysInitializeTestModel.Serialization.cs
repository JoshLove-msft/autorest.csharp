// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace SerializationCustomization.Models
{
    public partial class AlwaysInitializeTestModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (AlwaysInitializeList != null)
            {
                writer.WritePropertyName("AlwaysInitializeList");
                writer.WriteStartArray();
                foreach (var item in AlwaysInitializeList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("RequiredList");
            writer.WriteStartArray();
            foreach (var item in RequiredList)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (RequiredAlwaysInitializeList != null)
            {
                writer.WritePropertyName("RequiredAlwaysInitializeList");
                writer.WriteStartArray();
                foreach (var item in RequiredAlwaysInitializeList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("RequiredAlwaysInitializeList");
            }
            if (DefaultList != null)
            {
                writer.WritePropertyName("DefaultList");
                writer.WriteStartArray();
                foreach (var item in DefaultList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequiredAlwaysInitializeObject != null)
            {
                writer.WritePropertyName("RequiredAlwaysInitializeObject");
                writer.WriteObjectValue(RequiredAlwaysInitializeObject);
            }
            else
            {
                writer.WriteNull("RequiredAlwaysInitializeObject");
            }
            if (AlwaysInitializeObject != null)
            {
                writer.WritePropertyName("AlwaysInitializeObject");
                writer.WriteObjectValue(AlwaysInitializeObject);
            }
            if (DefaultObject != null)
            {
                writer.WritePropertyName("DefaultObject");
                writer.WriteObjectValue(DefaultObject);
            }
            writer.WriteEndObject();
        }

        internal static AlwaysInitializeTestModel DeserializeAlwaysInitializeTestModel(JsonElement element)
        {
            IList<Item> alwaysInitializeList = default;
            IList<Item> requiredList = default;
            IList<Item> requiredAlwaysInitializeList = default;
            IList<Item> defaultList = default;
            Item requiredAlwaysInitializeObject = default;
            Item alwaysInitializeObject = default;
            Item defaultObject = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("AlwaysInitializeList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Item> array = new List<Item>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Item.DeserializeItem(item));
                        }
                    }
                    alwaysInitializeList = array;
                    continue;
                }
                if (property.NameEquals("RequiredList"))
                {
                    List<Item> array = new List<Item>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Item.DeserializeItem(item));
                        }
                    }
                    requiredList = array;
                    continue;
                }
                if (property.NameEquals("RequiredAlwaysInitializeList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Item> array = new List<Item>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Item.DeserializeItem(item));
                        }
                    }
                    requiredAlwaysInitializeList = array;
                    continue;
                }
                if (property.NameEquals("DefaultList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Item> array = new List<Item>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Item.DeserializeItem(item));
                        }
                    }
                    defaultList = array;
                    continue;
                }
                if (property.NameEquals("RequiredAlwaysInitializeObject"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiredAlwaysInitializeObject = Item.DeserializeItem(property.Value);
                    continue;
                }
                if (property.NameEquals("AlwaysInitializeObject"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alwaysInitializeObject = Item.DeserializeItem(property.Value);
                    continue;
                }
                if (property.NameEquals("DefaultObject"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultObject = Item.DeserializeItem(property.Value);
                    continue;
                }
            }
            return new AlwaysInitializeTestModel(alwaysInitializeList, requiredList, requiredAlwaysInitializeList, defaultList, requiredAlwaysInitializeObject, alwaysInitializeObject, defaultObject);
        }
    }
}
