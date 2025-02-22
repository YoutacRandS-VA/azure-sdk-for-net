// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeDataProxyProperties : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeDataProxyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeDataProxyProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeDataProxyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataProxyProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue<SynapseEntityReference>(ConnectVia, options);
            }
            if (Optional.IsDefined(StagingLinkedService))
            {
                writer.WritePropertyName("stagingLinkedService"u8);
                writer.WriteObjectValue<SynapseEntityReference>(StagingLinkedService, options);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
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

        SynapseIntegrationRuntimeDataProxyProperties IJsonModel<SynapseIntegrationRuntimeDataProxyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataProxyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeDataProxyProperties(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeDataProxyProperties DeserializeSynapseIntegrationRuntimeDataProxyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseEntityReference connectVia = default;
            SynapseEntityReference stagingLinkedService = default;
            string path = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = SynapseEntityReference.DeserializeSynapseEntityReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stagingLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stagingLinkedService = SynapseEntityReference.DeserializeSynapseEntityReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeDataProxyProperties(connectVia, stagingLinkedService, path, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataProxyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeDataProxyProperties IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeDataProxyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataProxyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeDataProxyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
