// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class OnlineInferenceConfiguration : IUtf8JsonSerializable, IJsonModel<OnlineInferenceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnlineInferenceConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OnlineInferenceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnlineInferenceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnlineInferenceConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Configurations))
            {
                if (Configurations != null)
                {
                    writer.WritePropertyName("configurations"u8);
                    writer.WriteStartObject();
                    foreach (var item in Configurations)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurations");
                }
            }
            if (Optional.IsDefined(EntryScript))
            {
                if (EntryScript != null)
                {
                    writer.WritePropertyName("entryScript"u8);
                    writer.WriteStringValue(EntryScript);
                }
                else
                {
                    writer.WriteNull("entryScript");
                }
            }
            if (Optional.IsDefined(LivenessRoute))
            {
                if (LivenessRoute != null)
                {
                    writer.WritePropertyName("livenessRoute"u8);
                    writer.WriteObjectValue<MachineLearningInferenceContainerRoute>(LivenessRoute, options);
                }
                else
                {
                    writer.WriteNull("livenessRoute");
                }
            }
            if (Optional.IsDefined(ReadinessRoute))
            {
                if (ReadinessRoute != null)
                {
                    writer.WritePropertyName("readinessRoute"u8);
                    writer.WriteObjectValue<MachineLearningInferenceContainerRoute>(ReadinessRoute, options);
                }
                else
                {
                    writer.WriteNull("readinessRoute");
                }
            }
            if (Optional.IsDefined(ScoringRoute))
            {
                if (ScoringRoute != null)
                {
                    writer.WritePropertyName("scoringRoute"u8);
                    writer.WriteObjectValue<MachineLearningInferenceContainerRoute>(ScoringRoute, options);
                }
                else
                {
                    writer.WriteNull("scoringRoute");
                }
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

        OnlineInferenceConfiguration IJsonModel<OnlineInferenceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnlineInferenceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnlineInferenceConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnlineInferenceConfiguration(document.RootElement, options);
        }

        internal static OnlineInferenceConfiguration DeserializeOnlineInferenceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> configurations = default;
            string entryScript = default;
            MachineLearningInferenceContainerRoute livenessRoute = default;
            MachineLearningInferenceContainerRoute readinessRoute = default;
            MachineLearningInferenceContainerRoute scoringRoute = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        configurations = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    configurations = dictionary;
                    continue;
                }
                if (property.NameEquals("entryScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entryScript = null;
                        continue;
                    }
                    entryScript = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("livenessRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        livenessRoute = null;
                        continue;
                    }
                    livenessRoute = MachineLearningInferenceContainerRoute.DeserializeMachineLearningInferenceContainerRoute(property.Value, options);
                    continue;
                }
                if (property.NameEquals("readinessRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readinessRoute = null;
                        continue;
                    }
                    readinessRoute = MachineLearningInferenceContainerRoute.DeserializeMachineLearningInferenceContainerRoute(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scoringRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scoringRoute = null;
                        continue;
                    }
                    scoringRoute = MachineLearningInferenceContainerRoute.DeserializeMachineLearningInferenceContainerRoute(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OnlineInferenceConfiguration(
                configurations ?? new ChangeTrackingDictionary<string, string>(),
                entryScript,
                livenessRoute,
                readinessRoute,
                scoringRoute,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OnlineInferenceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnlineInferenceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OnlineInferenceConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        OnlineInferenceConfiguration IPersistableModel<OnlineInferenceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnlineInferenceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnlineInferenceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OnlineInferenceConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnlineInferenceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
