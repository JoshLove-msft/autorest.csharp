// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.Models;
using ExactMatchInheritance.Models;

namespace ExactMatchInheritance
{
    public partial class ExactMatchModel1Data : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(New))
            {
                writer.WritePropertyName("new");
                writer.WriteStringValue(New);
            }
            if (Optional.IsCollectionDefined(SupportingUris))
            {
                writer.WritePropertyName("supportingUris");
                writer.WriteStartArray();
                foreach (var item in SupportingUris)
                {
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Type1))
            {
                writer.WritePropertyName("type1");
                writer.WriteStringValue(Type1.Value.ToString());
            }
            if (Optional.IsDefined(Type2))
            {
                writer.WritePropertyName("type2");
                writer.WriteStringValue(Type2.Value.ToString());
            }
            if (Optional.IsDefined(Type3))
            {
                writer.WritePropertyName("type3");
                writer.WriteStringValue(Type3.ToString());
            }
            if (Optional.IsDefined(Type4))
            {
                writer.WritePropertyName("type4");
                writer.WriteObjectValue(Type4);
            }
            if (Optional.IsDefined(Type5))
            {
                writer.WritePropertyName("type5");
                JsonSerializer.Serialize(writer, Type5);
            }
            if (Optional.IsDefined(Type6))
            {
                writer.WritePropertyName("type6");
                JsonSerializer.Serialize(writer, Type6);
            }
            if (Optional.IsDefined(Type7))
            {
                writer.WritePropertyName("type7");
                JsonSerializer.Serialize(writer, Type7);
            }
            if (Optional.IsDefined(Type8))
            {
                writer.WritePropertyName("type8");
                JsonSerializer.Serialize(writer, Type8);
            }
            if (Optional.IsDefined(Type9))
            {
                writer.WritePropertyName("type9");
                JsonSerializer.Serialize(writer, Type9);
            }
            writer.WriteEndObject();
        }

        internal static ExactMatchModel1Data DeserializeExactMatchModel1Data(JsonElement element)
        {
            Optional<string> @new = default;
            Optional<IList<Uri>> supportingUris = default;
            Optional<Type1> type1 = default;
            Optional<Type2> type2 = default;
            Optional<IPAddress> type3 = default;
            Optional<object> type4 = default;
            Optional<DataFactoryExpression<string>> type5 = default;
            Optional<DataFactoryExpression<double>> type6 = default;
            Optional<DataFactoryExpression<bool>> type7 = default;
            Optional<DataFactoryExpression<int>> type8 = default;
            Optional<DataFactoryExpression<Array>> type9 = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("new"))
                {
                    @new = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportingUris"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new Uri(item.GetString()));
                    }
                    supportingUris = array;
                    continue;
                }
                if (property.NameEquals("type1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type1 = new Type1(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type2"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type2 = new Type2(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type3"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type3 = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type4"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type4 = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type5"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type5 = JsonSerializer.Deserialize<DataFactoryExpression<string>>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("type6"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type6 = JsonSerializer.Deserialize<DataFactoryExpression<double>>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("type7"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type7 = JsonSerializer.Deserialize<DataFactoryExpression<bool>>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("type8"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type8 = JsonSerializer.Deserialize<DataFactoryExpression<int>>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("type9"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type9 = JsonSerializer.Deserialize<DataFactoryExpression<Array>>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
            }
            return new ExactMatchModel1Data(id, name, type, systemData.Value, @new.Value, Optional.ToList(supportingUris), Optional.ToNullable(type1), Optional.ToNullable(type2), type3.Value, type4.Value, type5.Value, type6.Value, type7.Value, type8.Value, type9.Value);
        }
    }
}
