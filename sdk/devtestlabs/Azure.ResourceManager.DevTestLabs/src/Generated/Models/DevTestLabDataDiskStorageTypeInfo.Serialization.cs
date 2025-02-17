// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabDataDiskStorageTypeInfo : IUtf8JsonSerializable, IJsonModel<DevTestLabDataDiskStorageTypeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabDataDiskStorageTypeInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabDataDiskStorageTypeInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskStorageTypeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabDataDiskStorageTypeInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun"u8);
                writer.WriteStringValue(Lun);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
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

        DevTestLabDataDiskStorageTypeInfo IJsonModel<DevTestLabDataDiskStorageTypeInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskStorageTypeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabDataDiskStorageTypeInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabDataDiskStorageTypeInfo(document.RootElement, options);
        }

        internal static DevTestLabDataDiskStorageTypeInfo DeserializeDevTestLabDataDiskStorageTypeInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string lun = default;
            DevTestLabStorageType? storageType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"u8))
                {
                    lun = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new DevTestLabStorageType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabDataDiskStorageTypeInfo(lun, storageType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabDataDiskStorageTypeInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskStorageTypeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabDataDiskStorageTypeInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabDataDiskStorageTypeInfo IPersistableModel<DevTestLabDataDiskStorageTypeInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskStorageTypeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabDataDiskStorageTypeInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabDataDiskStorageTypeInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabDataDiskStorageTypeInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
