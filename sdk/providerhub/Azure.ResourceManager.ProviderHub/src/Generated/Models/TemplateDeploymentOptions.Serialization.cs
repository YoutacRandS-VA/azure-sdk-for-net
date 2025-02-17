// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class TemplateDeploymentOptions : IUtf8JsonSerializable, IJsonModel<TemplateDeploymentOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TemplateDeploymentOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TemplateDeploymentOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemplateDeploymentOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsPreflightSupported))
            {
                writer.WritePropertyName("preflightSupported"u8);
                writer.WriteBooleanValue(IsPreflightSupported.Value);
            }
            if (Optional.IsCollectionDefined(PreflightOptions))
            {
                writer.WritePropertyName("preflightOptions"u8);
                writer.WriteStartArray();
                foreach (var item in PreflightOptions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        TemplateDeploymentOptions IJsonModel<TemplateDeploymentOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemplateDeploymentOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTemplateDeploymentOptions(document.RootElement, options);
        }

        internal static TemplateDeploymentOptions DeserializeTemplateDeploymentOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? preflightSupported = default;
            IList<PreflightOption> preflightOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preflightSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preflightSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preflightOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PreflightOption> array = new List<PreflightOption>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreflightOption(item.GetString()));
                    }
                    preflightOptions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TemplateDeploymentOptions(preflightSupported, preflightOptions ?? new ChangeTrackingList<PreflightOption>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TemplateDeploymentOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TemplateDeploymentOptions)} does not support writing '{options.Format}' format.");
            }
        }

        TemplateDeploymentOptions IPersistableModel<TemplateDeploymentOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTemplateDeploymentOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TemplateDeploymentOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TemplateDeploymentOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
