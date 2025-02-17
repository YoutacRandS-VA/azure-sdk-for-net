// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    [PersistableModelProxy(typeof(UnknownDataConnectionPayload))]
    public partial class DataConnectionPayload : IUtf8JsonSerializable, IJsonModel<DataConnectionPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataConnectionPayload>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataConnectionPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataConnectionPayload)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content.Value.ToString());
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(FrequencyOffset))
            {
                writer.WritePropertyName("frequencyOffset"u8);
                writer.WriteNumberValue(FrequencyOffset.Value);
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

        DataConnectionPayload IJsonModel<DataConnectionPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataConnectionPayload)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataConnectionPayload(document.RootElement, options);
        }

        internal static DataConnectionPayload DeserializeDataConnectionPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "azureDataExplorer": return AzureDataExplorerDataConnectionPayload.DeserializeAzureDataExplorerDataConnectionPayload(element, options);
                    case "logAnalytics": return LogAnalyticsDataConnectionPayload.DeserializeLogAnalyticsDataConnectionPayload(element, options);
                }
            }
            return UnknownDataConnectionPayload.DeserializeUnknownDataConnectionPayload(element, options);
        }

        BinaryData IPersistableModel<DataConnectionPayload>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataConnectionPayload)} does not support writing '{options.Format}' format.");
            }
        }

        DataConnectionPayload IPersistableModel<DataConnectionPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataConnectionPayload(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataConnectionPayload)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataConnectionPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataConnectionPayload FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataConnectionPayload(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DataConnectionPayload>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
