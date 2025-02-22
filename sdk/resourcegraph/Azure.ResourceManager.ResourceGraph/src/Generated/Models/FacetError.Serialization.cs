// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class FacetError : IUtf8JsonSerializable, IJsonModel<FacetError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FacetError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FacetError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FacetError)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue<FacetErrorDetails>(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        FacetError IJsonModel<FacetError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FacetError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFacetError(document.RootElement, options);
        }

        internal static FacetError DeserializeFacetError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FacetErrorDetails> errors = default;
            string expression = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    List<FacetErrorDetails> array = new List<FacetErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FacetErrorDetails.DeserializeFacetErrorDetails(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FacetError(expression, resultType, serializedAdditionalRawData, errors);
        }

        BinaryData IPersistableModel<FacetError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FacetError)} does not support writing '{options.Format}' format.");
            }
        }

        FacetError IPersistableModel<FacetError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFacetError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FacetError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FacetError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
