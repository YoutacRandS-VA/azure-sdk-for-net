// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ProgressMetrics : IUtf8JsonSerializable, IJsonModel<ProgressMetrics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProgressMetrics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProgressMetrics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProgressMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProgressMetrics)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CompletedDatapointCount))
            {
                if (CompletedDatapointCount != null)
                {
                    writer.WritePropertyName("completedDatapointCount"u8);
                    writer.WriteNumberValue(CompletedDatapointCount.Value);
                }
                else
                {
                    writer.WriteNull("completedDatapointCount");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(IncrementalDataLastRefreshOn))
            {
                if (IncrementalDataLastRefreshOn != null)
                {
                    writer.WritePropertyName("incrementalDataLastRefreshDateTime"u8);
                    writer.WriteStringValue(IncrementalDataLastRefreshOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("incrementalDataLastRefreshDateTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(SkippedDatapointCount))
            {
                if (SkippedDatapointCount != null)
                {
                    writer.WritePropertyName("skippedDatapointCount"u8);
                    writer.WriteNumberValue(SkippedDatapointCount.Value);
                }
                else
                {
                    writer.WriteNull("skippedDatapointCount");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(TotalDatapointCount))
            {
                if (TotalDatapointCount != null)
                {
                    writer.WritePropertyName("totalDatapointCount"u8);
                    writer.WriteNumberValue(TotalDatapointCount.Value);
                }
                else
                {
                    writer.WriteNull("totalDatapointCount");
                }
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

        ProgressMetrics IJsonModel<ProgressMetrics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProgressMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProgressMetrics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProgressMetrics(document.RootElement, options);
        }

        internal static ProgressMetrics DeserializeProgressMetrics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? completedDatapointCount = default;
            DateTimeOffset? incrementalDataLastRefreshDateTime = default;
            long? skippedDatapointCount = default;
            long? totalDatapointCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completedDatapointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        completedDatapointCount = null;
                        continue;
                    }
                    completedDatapointCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("incrementalDataLastRefreshDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        incrementalDataLastRefreshDateTime = null;
                        continue;
                    }
                    incrementalDataLastRefreshDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("skippedDatapointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        skippedDatapointCount = null;
                        continue;
                    }
                    skippedDatapointCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDatapointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        totalDatapointCount = null;
                        continue;
                    }
                    totalDatapointCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProgressMetrics(completedDatapointCount, incrementalDataLastRefreshDateTime, skippedDatapointCount, totalDatapointCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProgressMetrics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProgressMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProgressMetrics)} does not support writing '{options.Format}' format.");
            }
        }

        ProgressMetrics IPersistableModel<ProgressMetrics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProgressMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProgressMetrics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProgressMetrics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProgressMetrics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
