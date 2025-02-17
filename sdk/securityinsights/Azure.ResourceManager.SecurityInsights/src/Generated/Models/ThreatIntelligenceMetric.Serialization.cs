// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceMetric : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceMetric>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreatIntelligenceMetric>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceMetric)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedOn);
            }
            if (Optional.IsCollectionDefined(ThreatTypeMetrics))
            {
                writer.WritePropertyName("threatTypeMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatTypeMetrics)
                {
                    writer.WriteObjectValue<ThreatIntelligenceMetricEntity>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternTypeMetrics))
            {
                writer.WritePropertyName("patternTypeMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in PatternTypeMetrics)
                {
                    writer.WriteObjectValue<ThreatIntelligenceMetricEntity>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceMetrics))
            {
                writer.WritePropertyName("sourceMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in SourceMetrics)
                {
                    writer.WriteObjectValue<ThreatIntelligenceMetricEntity>(item, options);
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

        ThreatIntelligenceMetric IJsonModel<ThreatIntelligenceMetric>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceMetric)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceMetric(document.RootElement, options);
        }

        internal static ThreatIntelligenceMetric DeserializeThreatIntelligenceMetric(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string lastUpdatedTimeUtc = default;
            IReadOnlyList<ThreatIntelligenceMetricEntity> threatTypeMetrics = default;
            IReadOnlyList<ThreatIntelligenceMetricEntity> patternTypeMetrics = default;
            IReadOnlyList<ThreatIntelligenceMetricEntity> sourceMetrics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimeUtc"u8))
                {
                    lastUpdatedTimeUtc = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threatTypeMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThreatIntelligenceMetricEntity> array = new List<ThreatIntelligenceMetricEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceMetricEntity.DeserializeThreatIntelligenceMetricEntity(item, options));
                    }
                    threatTypeMetrics = array;
                    continue;
                }
                if (property.NameEquals("patternTypeMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThreatIntelligenceMetricEntity> array = new List<ThreatIntelligenceMetricEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceMetricEntity.DeserializeThreatIntelligenceMetricEntity(item, options));
                    }
                    patternTypeMetrics = array;
                    continue;
                }
                if (property.NameEquals("sourceMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThreatIntelligenceMetricEntity> array = new List<ThreatIntelligenceMetricEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceMetricEntity.DeserializeThreatIntelligenceMetricEntity(item, options));
                    }
                    sourceMetrics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreatIntelligenceMetric(lastUpdatedTimeUtc, threatTypeMetrics ?? new ChangeTrackingList<ThreatIntelligenceMetricEntity>(), patternTypeMetrics ?? new ChangeTrackingList<ThreatIntelligenceMetricEntity>(), sourceMetrics ?? new ChangeTrackingList<ThreatIntelligenceMetricEntity>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreatIntelligenceMetric>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceMetric)} does not support writing '{options.Format}' format.");
            }
        }

        ThreatIntelligenceMetric IPersistableModel<ThreatIntelligenceMetric>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreatIntelligenceMetric(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceMetric)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceMetric>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
