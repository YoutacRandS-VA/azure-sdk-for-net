// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextJobsInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("analysisInput"u8);
            writer.WriteObjectValue<MultiLanguageAnalysisInput>(AnalysisInput);
            writer.WritePropertyName("tasks"u8);
            writer.WriteStartArray();
            foreach (var item in Tasks)
            {
                writer.WriteObjectValue<AnalyzeTextLROTask>(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
