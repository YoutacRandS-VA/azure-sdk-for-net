// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ReclassifyExceptionAction : IUtf8JsonSerializable, IJsonModel<ReclassifyExceptionAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReclassifyExceptionAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReclassifyExceptionAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReclassifyExceptionAction)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClassificationPolicyId))
            {
                writer.WritePropertyName("classificationPolicyId"u8);
                writer.WriteStringValue(ClassificationPolicyId);
            }
            if (Optional.IsCollectionDefined(_labelsToUpsert))
            {
                writer.WritePropertyName("labelsToUpsert"u8);
                writer.WriteStartObject();
                foreach (var item in _labelsToUpsert)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ReclassifyExceptionAction IJsonModel<ReclassifyExceptionAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReclassifyExceptionAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReclassifyExceptionAction(document.RootElement, options);
        }

        internal static ReclassifyExceptionAction DeserializeReclassifyExceptionAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string classificationPolicyId = default;
            IDictionary<string, BinaryData> labelsToUpsert = default;
            string id = default;
            ExceptionActionKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelsToUpsert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    labelsToUpsert = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ExceptionActionKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReclassifyExceptionAction(id, kind, serializedAdditionalRawData, classificationPolicyId, labelsToUpsert ?? new ChangeTrackingDictionary<string, BinaryData>());
        }

        BinaryData IPersistableModel<ReclassifyExceptionAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReclassifyExceptionAction)} does not support writing '{options.Format}' format.");
            }
        }

        ReclassifyExceptionAction IPersistableModel<ReclassifyExceptionAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReclassifyExceptionAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReclassifyExceptionAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReclassifyExceptionAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ReclassifyExceptionAction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeReclassifyExceptionAction(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ReclassifyExceptionAction>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
