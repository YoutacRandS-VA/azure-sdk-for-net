// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class TranslatedTextItem : IUtf8JsonSerializable, IJsonModel<TranslatedTextItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TranslatedTextItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TranslatedTextItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslatedTextItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranslatedTextItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DetectedLanguage))
            {
                writer.WritePropertyName("detectedLanguage"u8);
                writer.WriteObjectValue<DetectedLanguage>(DetectedLanguage, options);
            }
            writer.WritePropertyName("translations"u8);
            writer.WriteStartArray();
            foreach (var item in Translations)
            {
                writer.WriteObjectValue<Translation>(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SourceText))
            {
                writer.WritePropertyName("sourceText"u8);
                writer.WriteObjectValue<SourceText>(SourceText, options);
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

        TranslatedTextItem IJsonModel<TranslatedTextItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslatedTextItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranslatedTextItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTranslatedTextItem(document.RootElement, options);
        }

        internal static TranslatedTextItem DeserializeTranslatedTextItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DetectedLanguage detectedLanguage = default;
            IReadOnlyList<Translation> translations = default;
            SourceText sourceText = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("detectedLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectedLanguage = DetectedLanguage.DeserializeDetectedLanguage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("translations"u8))
                {
                    List<Translation> array = new List<Translation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Translation.DeserializeTranslation(item, options));
                    }
                    translations = array;
                    continue;
                }
                if (property.NameEquals("sourceText"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceText = SourceText.DeserializeSourceText(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TranslatedTextItem(detectedLanguage, translations, sourceText, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TranslatedTextItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslatedTextItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TranslatedTextItem)} does not support writing '{options.Format}' format.");
            }
        }

        TranslatedTextItem IPersistableModel<TranslatedTextItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslatedTextItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTranslatedTextItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TranslatedTextItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TranslatedTextItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TranslatedTextItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTranslatedTextItem(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<TranslatedTextItem>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
