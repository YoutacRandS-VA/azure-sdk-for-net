// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class SingletonPartitionScheme : IUtf8JsonSerializable, IJsonModel<SingletonPartitionScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingletonPartitionScheme>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SingletonPartitionScheme>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        SingletonPartitionScheme IJsonModel<SingletonPartitionScheme>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingletonPartitionScheme(document.RootElement, options);
        }

        internal static SingletonPartitionScheme DeserializeSingletonPartitionScheme(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartitionScheme partitionScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SingletonPartitionScheme(partitionScheme, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SingletonPartitionScheme>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support writing '{options.Format}' format.");
            }
        }

        SingletonPartitionScheme IPersistableModel<SingletonPartitionScheme>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSingletonPartitionScheme(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingletonPartitionScheme>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
