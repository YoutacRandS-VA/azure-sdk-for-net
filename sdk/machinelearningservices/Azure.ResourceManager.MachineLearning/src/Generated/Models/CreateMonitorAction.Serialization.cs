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
    public partial class CreateMonitorAction : IUtf8JsonSerializable, IJsonModel<CreateMonitorAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateMonitorAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateMonitorAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateMonitorAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateMonitorAction)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("monitorDefinition"u8);
            writer.WriteObjectValue<MonitorDefinition>(MonitorDefinition, options);
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        CreateMonitorAction IJsonModel<CreateMonitorAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateMonitorAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateMonitorAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateMonitorAction(document.RootElement, options);
        }

        internal static CreateMonitorAction DeserializeCreateMonitorAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorDefinition monitorDefinition = default;
            ScheduleActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monitorDefinition"u8))
                {
                    monitorDefinition = MonitorDefinition.DeserializeMonitorDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ScheduleActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateMonitorAction(actionType, serializedAdditionalRawData, monitorDefinition);
        }

        BinaryData IPersistableModel<CreateMonitorAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateMonitorAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateMonitorAction)} does not support writing '{options.Format}' format.");
            }
        }

        CreateMonitorAction IPersistableModel<CreateMonitorAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateMonitorAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateMonitorAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateMonitorAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateMonitorAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
