// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using ModelReaderWriterValidationTypeSpec;

namespace ModelReaderWriterValidationTypeSpec.Models
{
    public partial class ProviderResourceType : IUtf8JsonSerializable, IJsonModel<ProviderResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderResourceType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProviderResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderResourceType)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LocationMappings))
            {
                writer.WritePropertyName("locationMappings"u8);
                writer.WriteStartArray();
                foreach (var item in LocationMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Aliases))
            {
                writer.WritePropertyName("aliases"u8);
                writer.WriteStartArray();
                foreach (var item in Aliases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultApiVersion))
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (Optional.IsCollectionDefined(ZoneMappings))
            {
                writer.WritePropertyName("zoneMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ZoneMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApiProfiles))
            {
                writer.WritePropertyName("apiProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ApiProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStringValue(Capabilities);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProviderResourceType IJsonModel<ProviderResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderResourceType)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderResourceType(document.RootElement, options);
        }

        internal static ProviderResourceType DeserializeProviderResourceType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceType = default;
            IReadOnlyList<string> locations = default;
            IReadOnlyList<ProviderExtendedLocation> locationMappings = default;
            IReadOnlyList<ResourceTypeAlias> aliases = default;
            IReadOnlyList<string> apiVersions = default;
            string defaultApiVersion = default;
            IReadOnlyList<ZoneMapping> zoneMappings = default;
            IReadOnlyList<ApiProfile> apiProfiles = default;
            string capabilities = default;
            IReadOnlyDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderExtendedLocation> array = new List<ProviderExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderExtendedLocation.DeserializeProviderExtendedLocation(item, options));
                    }
                    locationMappings = array;
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeAlias> array = new List<ResourceTypeAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeAlias.DeserializeResourceTypeAlias(item, options));
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zoneMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ZoneMapping> array = new List<ZoneMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ZoneMapping.DeserializeZoneMapping(item, options));
                    }
                    zoneMappings = array;
                    continue;
                }
                if (property.NameEquals("apiProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiProfile> array = new List<ApiProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiProfile.DeserializeApiProfile(item, options));
                    }
                    apiProfiles = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProviderResourceType(
                resourceType,
                locations ?? new ChangeTrackingList<string>(),
                locationMappings ?? new ChangeTrackingList<ProviderExtendedLocation>(),
                aliases ?? new ChangeTrackingList<ResourceTypeAlias>(),
                apiVersions ?? new ChangeTrackingList<string>(),
                defaultApiVersion,
                zoneMappings ?? new ChangeTrackingList<ZoneMapping>(),
                apiProfiles ?? new ChangeTrackingList<ApiProfile>(),
                capabilities,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProviderResourceType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProviderResourceType)} does not support writing in '{options.Format}' format.");
            }
        }

        ProviderResourceType IPersistableModel<ProviderResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProviderResourceType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProviderResourceType)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProviderResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ProviderResourceType FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeProviderResourceType(document.RootElement);
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
