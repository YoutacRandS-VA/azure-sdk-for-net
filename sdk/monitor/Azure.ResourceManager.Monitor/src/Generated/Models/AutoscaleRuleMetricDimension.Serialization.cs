// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleRuleMetricDimension : IUtf8JsonSerializable, IJsonModel<AutoscaleRuleMetricDimension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleRuleMetricDimension>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoscaleRuleMetricDimension>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleRuleMetricDimension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleRuleMetricDimension)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("DimensionName"u8);
            writer.WriteStringValue(DimensionName);
            writer.WritePropertyName("Operator"u8);
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("Values"u8);
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        AutoscaleRuleMetricDimension IJsonModel<AutoscaleRuleMetricDimension>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleRuleMetricDimension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleRuleMetricDimension)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleRuleMetricDimension(document.RootElement, options);
        }

        internal static AutoscaleRuleMetricDimension DeserializeAutoscaleRuleMetricDimension(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimensionName = default;
            ScaleRuleMetricDimensionOperationType @operator = default;
            IList<string> values = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("DimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Operator"u8))
                {
                    @operator = new ScaleRuleMetricDimensionOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Values"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoscaleRuleMetricDimension(dimensionName, @operator, values, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleRuleMetricDimension>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleRuleMetricDimension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleRuleMetricDimension)} does not support writing '{options.Format}' format.");
            }
        }

        AutoscaleRuleMetricDimension IPersistableModel<AutoscaleRuleMetricDimension>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleRuleMetricDimension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleRuleMetricDimension(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleRuleMetricDimension)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleRuleMetricDimension>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
