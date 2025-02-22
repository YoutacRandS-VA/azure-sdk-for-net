// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatRequestAssistantMessage : IUtf8JsonSerializable, IJsonModel<ChatRequestAssistantMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatRequestAssistantMessage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChatRequestAssistantMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatRequestAssistantMessage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Content != null)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            else
            {
                writer.WriteNull("content");
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(ToolCalls))
            {
                writer.WritePropertyName("tool_calls"u8);
                writer.WriteStartArray();
                foreach (var item in ToolCalls)
                {
                    writer.WriteObjectValue<ChatCompletionsToolCall>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FunctionCall))
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue<FunctionCall>(FunctionCall, options);
            }
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
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

        ChatRequestAssistantMessage IJsonModel<ChatRequestAssistantMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatRequestAssistantMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatRequestAssistantMessage(document.RootElement, options);
        }

        internal static ChatRequestAssistantMessage DeserializeChatRequestAssistantMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string content = default;
            string name = default;
            IList<ChatCompletionsToolCall> toolCalls = default;
            FunctionCall functionCall = default;
            ChatRole role = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        content = null;
                        continue;
                    }
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tool_calls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatCompletionsToolCall> array = new List<ChatCompletionsToolCall>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatCompletionsToolCall.DeserializeChatCompletionsToolCall(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionCall = FunctionCall.DeserializeFunctionCall(property.Value, options);
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = new ChatRole(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChatRequestAssistantMessage(
                role,
                serializedAdditionalRawData,
                content,
                name,
                toolCalls ?? new ChangeTrackingList<ChatCompletionsToolCall>(),
                functionCall);
        }

        BinaryData IPersistableModel<ChatRequestAssistantMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatRequestAssistantMessage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatRequestAssistantMessage IPersistableModel<ChatRequestAssistantMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatRequestAssistantMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatRequestAssistantMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatRequestAssistantMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ChatRequestAssistantMessage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatRequestAssistantMessage(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ChatRequestAssistantMessage>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
