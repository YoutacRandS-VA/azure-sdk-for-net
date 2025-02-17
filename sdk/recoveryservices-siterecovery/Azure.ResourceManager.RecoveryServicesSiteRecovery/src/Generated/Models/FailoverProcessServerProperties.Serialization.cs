// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class FailoverProcessServerProperties : IUtf8JsonSerializable, IJsonModel<FailoverProcessServerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverProcessServerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FailoverProcessServerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProcessServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverProcessServerProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(SourceProcessServerId))
            {
                writer.WritePropertyName("sourceProcessServerId"u8);
                writer.WriteStringValue(SourceProcessServerId.Value);
            }
            if (Optional.IsDefined(TargetProcessServerId))
            {
                writer.WritePropertyName("targetProcessServerId"u8);
                writer.WriteStringValue(TargetProcessServerId.Value);
            }
            if (Optional.IsCollectionDefined(VmsToMigrate))
            {
                writer.WritePropertyName("vmsToMigrate"u8);
                writer.WriteStartArray();
                foreach (var item in VmsToMigrate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("updateType"u8);
                writer.WriteStringValue(UpdateType);
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

        FailoverProcessServerProperties IJsonModel<FailoverProcessServerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProcessServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverProcessServerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverProcessServerProperties(document.RootElement, options);
        }

        internal static FailoverProcessServerProperties DeserializeFailoverProcessServerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string containerName = default;
            Guid? sourceProcessServerId = default;
            Guid? targetProcessServerId = default;
            IList<string> vmsToMigrate = default;
            string updateType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceProcessServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceProcessServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("targetProcessServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProcessServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("vmsToMigrate"u8))
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
                    vmsToMigrate = array;
                    continue;
                }
                if (property.NameEquals("updateType"u8))
                {
                    updateType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FailoverProcessServerProperties(
                containerName,
                sourceProcessServerId,
                targetProcessServerId,
                vmsToMigrate ?? new ChangeTrackingList<string>(),
                updateType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FailoverProcessServerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProcessServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailoverProcessServerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        FailoverProcessServerProperties IPersistableModel<FailoverProcessServerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProcessServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverProcessServerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverProcessServerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverProcessServerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
