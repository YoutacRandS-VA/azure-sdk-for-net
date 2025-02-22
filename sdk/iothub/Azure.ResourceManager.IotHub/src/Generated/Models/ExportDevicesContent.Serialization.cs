// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class ExportDevicesContent : IUtf8JsonSerializable, IJsonModel<ExportDevicesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportDevicesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExportDevicesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDevicesContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("exportBlobContainerUri"u8);
            writer.WriteStringValue(ExportBlobContainerUri.AbsoluteUri);
            writer.WritePropertyName("excludeKeys"u8);
            writer.WriteBooleanValue(ExcludeKeys);
            if (Optional.IsDefined(ExportBlobName))
            {
                writer.WritePropertyName("exportBlobName"u8);
                writer.WriteStringValue(ExportBlobName);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue<ManagedIdentity>(Identity, options);
            }
            if (Optional.IsDefined(IncludeConfigurations))
            {
                writer.WritePropertyName("includeConfigurations"u8);
                writer.WriteBooleanValue(IncludeConfigurations.Value);
            }
            if (Optional.IsDefined(ConfigurationsBlobName))
            {
                writer.WritePropertyName("configurationsBlobName"u8);
                writer.WriteStringValue(ConfigurationsBlobName);
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

        ExportDevicesContent IJsonModel<ExportDevicesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDevicesContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportDevicesContent(document.RootElement, options);
        }

        internal static ExportDevicesContent DeserializeExportDevicesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri exportBlobContainerUri = default;
            bool excludeKeys = default;
            string exportBlobName = default;
            IotHubAuthenticationType? authenticationType = default;
            ManagedIdentity identity = default;
            bool? includeConfigurations = default;
            string configurationsBlobName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exportBlobContainerUri"u8))
                {
                    exportBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("excludeKeys"u8))
                {
                    excludeKeys = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exportBlobName"u8))
                {
                    exportBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new IotHubAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("includeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeConfigurations = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationsBlobName"u8))
                {
                    configurationsBlobName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExportDevicesContent(
                exportBlobContainerUri,
                excludeKeys,
                exportBlobName,
                authenticationType,
                identity,
                includeConfigurations,
                configurationsBlobName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportDevicesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportDevicesContent)} does not support writing '{options.Format}' format.");
            }
        }

        ExportDevicesContent IPersistableModel<ExportDevicesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportDevicesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportDevicesContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportDevicesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
