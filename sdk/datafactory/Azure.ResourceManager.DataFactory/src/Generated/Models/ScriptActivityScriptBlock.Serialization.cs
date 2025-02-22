// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ScriptActivityScriptBlock : IUtf8JsonSerializable, IJsonModel<ScriptActivityScriptBlock>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptActivityScriptBlock>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScriptActivityScriptBlock>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActivityScriptBlock>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptActivityScriptBlock)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            JsonSerializer.Serialize(writer, Text);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ScriptType.ToString());
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue<ScriptActivityParameter>(item, options);
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

        ScriptActivityScriptBlock IJsonModel<ScriptActivityScriptBlock>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActivityScriptBlock>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptActivityScriptBlock)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptActivityScriptBlock(document.RootElement, options);
        }

        internal static ScriptActivityScriptBlock DeserializeScriptActivityScriptBlock(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> text = default;
            DataFactoryScriptType type = default;
            IList<ScriptActivityParameter> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new DataFactoryScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActivityParameter> array = new List<ScriptActivityParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActivityParameter.DeserializeScriptActivityParameter(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScriptActivityScriptBlock(text, type, parameters ?? new ChangeTrackingList<ScriptActivityParameter>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScriptActivityScriptBlock>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActivityScriptBlock>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScriptActivityScriptBlock)} does not support writing '{options.Format}' format.");
            }
        }

        ScriptActivityScriptBlock IPersistableModel<ScriptActivityScriptBlock>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActivityScriptBlock>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScriptActivityScriptBlock(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScriptActivityScriptBlock)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScriptActivityScriptBlock>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
