// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxCustomerDiskCopyLogDetails : IUtf8JsonSerializable, IJsonModel<DataBoxCustomerDiskCopyLogDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxCustomerDiskCopyLogDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxCustomerDiskCopyLogDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyLogDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorLogLink))
            {
                writer.WritePropertyName("errorLogLink"u8);
                writer.WriteStringValue(ErrorLogLink);
            }
            if (options.Format != "W" && Optional.IsDefined(VerboseLogLink))
            {
                writer.WritePropertyName("verboseLogLink"u8);
                writer.WriteStringValue(VerboseLogLink);
            }
            writer.WritePropertyName("copyLogDetailsType"u8);
            writer.WriteStringValue(CopyLogDetailsType.ToSerialString());
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

        DataBoxCustomerDiskCopyLogDetails IJsonModel<DataBoxCustomerDiskCopyLogDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyLogDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxCustomerDiskCopyLogDetails(document.RootElement, options);
        }

        internal static DataBoxCustomerDiskCopyLogDetails DeserializeDataBoxCustomerDiskCopyLogDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serialNumber = default;
            string errorLogLink = default;
            string verboseLogLink = default;
            DataBoxOrderType copyLogDetailsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorLogLink"u8))
                {
                    errorLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verboseLogLink"u8))
                {
                    verboseLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyLogDetailsType"u8))
                {
                    copyLogDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxCustomerDiskCopyLogDetails(copyLogDetailsType, serializedAdditionalRawData, serialNumber, errorLogLink, verboseLogLink);
        }

        BinaryData IPersistableModel<DataBoxCustomerDiskCopyLogDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyLogDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxCustomerDiskCopyLogDetails IPersistableModel<DataBoxCustomerDiskCopyLogDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxCustomerDiskCopyLogDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyLogDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxCustomerDiskCopyLogDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
