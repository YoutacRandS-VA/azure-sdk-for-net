// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewaySku : IUtf8JsonSerializable, IJsonModel<ApplicationGatewaySku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewaySku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewaySku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewaySku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewaySku)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
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

        ApplicationGatewaySku IJsonModel<ApplicationGatewaySku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewaySku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewaySku)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewaySku(document.RootElement, options);
        }

        internal static ApplicationGatewaySku DeserializeApplicationGatewaySku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplicationGatewaySkuName? name = default;
            ApplicationGatewayTier? tier = default;
            int? capacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new ApplicationGatewaySkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new ApplicationGatewayTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewaySku(name, tier, capacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewaySku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewaySku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewaySku)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewaySku IPersistableModel<ApplicationGatewaySku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewaySku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewaySku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewaySku)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewaySku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
