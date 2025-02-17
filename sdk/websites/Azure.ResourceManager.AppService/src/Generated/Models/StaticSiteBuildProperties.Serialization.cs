// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteBuildProperties : IUtf8JsonSerializable, IJsonModel<StaticSiteBuildProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteBuildProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StaticSiteBuildProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation);
            }
            if (Optional.IsDefined(ApiLocation))
            {
                writer.WritePropertyName("apiLocation"u8);
                writer.WriteStringValue(ApiLocation);
            }
            if (Optional.IsDefined(AppArtifactLocation))
            {
                writer.WritePropertyName("appArtifactLocation"u8);
                writer.WriteStringValue(AppArtifactLocation);
            }
            if (Optional.IsDefined(OutputLocation))
            {
                writer.WritePropertyName("outputLocation"u8);
                writer.WriteStringValue(OutputLocation);
            }
            if (Optional.IsDefined(AppBuildCommand))
            {
                writer.WritePropertyName("appBuildCommand"u8);
                writer.WriteStringValue(AppBuildCommand);
            }
            if (Optional.IsDefined(ApiBuildCommand))
            {
                writer.WritePropertyName("apiBuildCommand"u8);
                writer.WriteStringValue(ApiBuildCommand);
            }
            if (Optional.IsDefined(SkipGithubActionWorkflowGeneration))
            {
                writer.WritePropertyName("skipGithubActionWorkflowGeneration"u8);
                writer.WriteBooleanValue(SkipGithubActionWorkflowGeneration.Value);
            }
            if (Optional.IsDefined(GithubActionSecretNameOverride))
            {
                writer.WritePropertyName("githubActionSecretNameOverride"u8);
                writer.WriteStringValue(GithubActionSecretNameOverride);
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

        StaticSiteBuildProperties IJsonModel<StaticSiteBuildProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteBuildProperties(document.RootElement, options);
        }

        internal static StaticSiteBuildProperties DeserializeStaticSiteBuildProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string appLocation = default;
            string apiLocation = default;
            string appArtifactLocation = default;
            string outputLocation = default;
            string appBuildCommand = default;
            string apiBuildCommand = default;
            bool? skipGithubActionWorkflowGeneration = default;
            string githubActionSecretNameOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    appLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiLocation"u8))
                {
                    apiLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appArtifactLocation"u8))
                {
                    appArtifactLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputLocation"u8))
                {
                    outputLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appBuildCommand"u8))
                {
                    appBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiBuildCommand"u8))
                {
                    apiBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skipGithubActionWorkflowGeneration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipGithubActionWorkflowGeneration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("githubActionSecretNameOverride"u8))
                {
                    githubActionSecretNameOverride = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StaticSiteBuildProperties(
                appLocation,
                apiLocation,
                appArtifactLocation,
                outputLocation,
                appBuildCommand,
                apiBuildCommand,
                skipGithubActionWorkflowGeneration,
                githubActionSecretNameOverride,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppLocation), out propertyOverride);
            if (Optional.IsDefined(AppLocation) || hasPropertyOverride)
            {
                builder.Append("  appLocation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AppLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiLocation), out propertyOverride);
            if (Optional.IsDefined(ApiLocation) || hasPropertyOverride)
            {
                builder.Append("  apiLocation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ApiLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppArtifactLocation), out propertyOverride);
            if (Optional.IsDefined(AppArtifactLocation) || hasPropertyOverride)
            {
                builder.Append("  appArtifactLocation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AppArtifactLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppArtifactLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppArtifactLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutputLocation), out propertyOverride);
            if (Optional.IsDefined(OutputLocation) || hasPropertyOverride)
            {
                builder.Append("  outputLocation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (OutputLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OutputLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OutputLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppBuildCommand), out propertyOverride);
            if (Optional.IsDefined(AppBuildCommand) || hasPropertyOverride)
            {
                builder.Append("  appBuildCommand: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AppBuildCommand.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppBuildCommand}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppBuildCommand}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiBuildCommand), out propertyOverride);
            if (Optional.IsDefined(ApiBuildCommand) || hasPropertyOverride)
            {
                builder.Append("  apiBuildCommand: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ApiBuildCommand.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiBuildCommand}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiBuildCommand}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SkipGithubActionWorkflowGeneration), out propertyOverride);
            if (Optional.IsDefined(SkipGithubActionWorkflowGeneration) || hasPropertyOverride)
            {
                builder.Append("  skipGithubActionWorkflowGeneration: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = SkipGithubActionWorkflowGeneration.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GithubActionSecretNameOverride), out propertyOverride);
            if (Optional.IsDefined(GithubActionSecretNameOverride) || hasPropertyOverride)
            {
                builder.Append("  githubActionSecretNameOverride: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (GithubActionSecretNameOverride.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GithubActionSecretNameOverride}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GithubActionSecretNameOverride}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StaticSiteBuildProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StaticSiteBuildProperties IPersistableModel<StaticSiteBuildProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticSiteBuildProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSiteBuildProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
