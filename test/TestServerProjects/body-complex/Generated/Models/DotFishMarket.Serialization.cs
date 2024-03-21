// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using body_complex;

namespace body_complex.Models
{
    public partial class DotFishMarket : IUtf8JsonSerializable, IJsonModel<DotFishMarket>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DotFishMarket>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DotFishMarket>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFishMarket>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DotFishMarket)} does not support writing in '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SampleSalmon))
            {
                writer.WritePropertyName("sampleSalmon"u8);
                writer.WriteObjectValue(SampleSalmon);
            }
            if (Optional.IsCollectionDefined(Salmons))
            {
                writer.WritePropertyName("salmons"u8);
                writer.WriteStartArray();
                foreach (var item in Salmons)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SampleFish))
            {
                writer.WritePropertyName("sampleFish"u8);
                writer.WriteObjectValue(SampleFish);
            }
            if (Optional.IsCollectionDefined(Fishes))
            {
                writer.WritePropertyName("fishes"u8);
                writer.WriteStartArray();
                foreach (var item in Fishes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DotFishMarket IJsonModel<DotFishMarket>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFishMarket>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DotFishMarket)} does not support reading in '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDotFishMarket(document.RootElement, options);
        }

        internal static DotFishMarket DeserializeDotFishMarket(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DotSalmon sampleSalmon = default;
            IReadOnlyList<DotSalmon> salmons = default;
            DotFish sampleFish = default;
            IReadOnlyList<DotFish> fishes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sampleSalmon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sampleSalmon = DotSalmon.DeserializeDotSalmon(property.Value, options);
                    continue;
                }
                if (property.NameEquals("salmons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DotSalmon> array = new List<DotSalmon>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DotSalmon.DeserializeDotSalmon(item, options));
                    }
                    salmons = array;
                    continue;
                }
                if (property.NameEquals("sampleFish"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sampleFish = DotFish.DeserializeDotFish(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fishes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DotFish> array = new List<DotFish>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DotFish.DeserializeDotFish(item, options));
                    }
                    fishes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DotFishMarket(sampleSalmon, salmons ?? new ChangeTrackingList<DotSalmon>(), sampleFish, fishes ?? new ChangeTrackingList<DotFish>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DotFishMarket>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFishMarket>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DotFishMarket)} does not support writing in '{options.Format}' format.");
            }
        }

        DotFishMarket IPersistableModel<DotFishMarket>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFishMarket>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDotFishMarket(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DotFishMarket)} does not support reading in '{options.Format}' format.");
            }
        }

        string IPersistableModel<DotFishMarket>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
