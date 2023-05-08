// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class ModelInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSource"u8);
            writer.WriteStringValue(DataSource);
            if (Optional.IsDefined(DataSchema))
            {
                if (DataSchema != null)
                {
                    writer.WritePropertyName("dataSchema"u8);
                    writer.WriteStringValue(DataSchema.Value.ToString());
                }
                else
                {
                    writer.WriteNull("dataSchema");
                }
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndTime, "O");
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(SlidingWindow))
            {
                if (SlidingWindow != null)
                {
                    writer.WritePropertyName("slidingWindow"u8);
                    writer.WriteNumberValue(SlidingWindow.Value);
                }
                else
                {
                    writer.WriteNull("slidingWindow");
                }
            }
            if (Optional.IsDefined(AlignPolicy))
            {
                writer.WritePropertyName("alignPolicy"u8);
                writer.WriteObjectValue(AlignPolicy);
            }
            if (Optional.IsDefined(Status))
            {
                if (Status != null)
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("status");
                }
            }
            if (Optional.IsDefined(DiagnosticsInfo))
            {
                writer.WritePropertyName("diagnosticsInfo"u8);
                writer.WriteObjectValue(DiagnosticsInfo);
            }
            writer.WriteEndObject();
        }

        internal static ModelInfo DeserializeModelInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataSource = default;
            Optional<DataSchema?> dataSchema = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            Optional<string> displayName = default;
            Optional<int?> slidingWindow = default;
            Optional<AlignPolicy> alignPolicy = default;
            Optional<ModelStatus?> status = default;
            Optional<IReadOnlyList<ErrorResponse>> errors = default;
            Optional<DiagnosticsInfo> diagnosticsInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSource"u8))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataSchema = null;
                        continue;
                    }
                    dataSchema = new DataSchema(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slidingWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        slidingWindow = null;
                        continue;
                    }
                    slidingWindow = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("alignPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alignPolicy = AlignPolicy.DeserializeAlignPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        status = null;
                        continue;
                    }
                    status = property.Value.GetString().ToModelStatus();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorResponse.DeserializeErrorResponse(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("diagnosticsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticsInfo = DiagnosticsInfo.DeserializeDiagnosticsInfo(property.Value);
                    continue;
                }
            }
            return new ModelInfo(dataSource, Optional.ToNullable(dataSchema), startTime, endTime, displayName, Optional.ToNullable(slidingWindow), alignPolicy, Optional.ToNullable(status), Optional.ToList(errors), diagnosticsInfo);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ModelInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModelInfo(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}