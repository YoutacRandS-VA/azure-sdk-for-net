// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    public partial class TextBlocklistMatch : IUtf8JsonSerializable, IJsonModel<TextBlocklistMatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextBlocklistMatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TextBlocklistMatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextBlocklistMatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextBlocklistMatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("blocklistName"u8);
            writer.WriteStringValue(BlocklistName);
            writer.WritePropertyName("blocklistItemId"u8);
            writer.WriteStringValue(BlocklistItemId);
            writer.WritePropertyName("blocklistItemText"u8);
            writer.WriteStringValue(BlocklistItemText);
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

        TextBlocklistMatch IJsonModel<TextBlocklistMatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextBlocklistMatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextBlocklistMatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextBlocklistMatch(document.RootElement, options);
        }

        internal static TextBlocklistMatch DeserializeTextBlocklistMatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string blocklistName = default;
            string blocklistItemId = default;
            string blocklistItemText = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blocklistName"u8))
                {
                    blocklistName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blocklistItemId"u8))
                {
                    blocklistItemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blocklistItemText"u8))
                {
                    blocklistItemText = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TextBlocklistMatch(blocklistName, blocklistItemId, blocklistItemText, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextBlocklistMatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextBlocklistMatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextBlocklistMatch)} does not support writing '{options.Format}' format.");
            }
        }

        TextBlocklistMatch IPersistableModel<TextBlocklistMatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextBlocklistMatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTextBlocklistMatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextBlocklistMatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextBlocklistMatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextBlocklistMatch FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTextBlocklistMatch(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<TextBlocklistMatch>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
