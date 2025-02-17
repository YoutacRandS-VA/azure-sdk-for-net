// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class SmbSetting : IUtf8JsonSerializable, IJsonModel<SmbSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SmbSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SmbSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmbSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmbSetting)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Multichannel))
            {
                writer.WritePropertyName("multichannel"u8);
                writer.WriteObjectValue<Multichannel>(Multichannel, options);
            }
            if (Optional.IsDefined(Versions))
            {
                writer.WritePropertyName("versions"u8);
                writer.WriteStringValue(Versions);
            }
            if (Optional.IsDefined(AuthenticationMethods))
            {
                writer.WritePropertyName("authenticationMethods"u8);
                writer.WriteStringValue(AuthenticationMethods);
            }
            if (Optional.IsDefined(KerberosTicketEncryption))
            {
                writer.WritePropertyName("kerberosTicketEncryption"u8);
                writer.WriteStringValue(KerberosTicketEncryption);
            }
            if (Optional.IsDefined(ChannelEncryption))
            {
                writer.WritePropertyName("channelEncryption"u8);
                writer.WriteStringValue(ChannelEncryption);
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

        SmbSetting IJsonModel<SmbSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmbSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmbSetting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSmbSetting(document.RootElement, options);
        }

        internal static SmbSetting DeserializeSmbSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Multichannel multichannel = default;
            string versions = default;
            string authenticationMethods = default;
            string kerberosTicketEncryption = default;
            string channelEncryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("multichannel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multichannel = Multichannel.DeserializeMultichannel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("versions"u8))
                {
                    versions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationMethods"u8))
                {
                    authenticationMethods = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kerberosTicketEncryption"u8))
                {
                    kerberosTicketEncryption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelEncryption"u8))
                {
                    channelEncryption = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SmbSetting(
                multichannel,
                versions,
                authenticationMethods,
                kerberosTicketEncryption,
                channelEncryption,
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

            if (propertyOverrides != null)
            {
                TransformFlattenedOverrides(bicepOptions, propertyOverrides);
            }

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Multichannel), out propertyOverride);
            if (Optional.IsDefined(Multichannel) || hasPropertyOverride)
            {
                builder.Append("  multichannel: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, Multichannel, options, 2, false, "  multichannel: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Versions), out propertyOverride);
            if (Optional.IsDefined(Versions) || hasPropertyOverride)
            {
                builder.Append("  versions: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Versions.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Versions}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Versions}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthenticationMethods), out propertyOverride);
            if (Optional.IsDefined(AuthenticationMethods) || hasPropertyOverride)
            {
                builder.Append("  authenticationMethods: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AuthenticationMethods.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AuthenticationMethods}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AuthenticationMethods}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KerberosTicketEncryption), out propertyOverride);
            if (Optional.IsDefined(KerberosTicketEncryption) || hasPropertyOverride)
            {
                builder.Append("  kerberosTicketEncryption: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (KerberosTicketEncryption.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KerberosTicketEncryption}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KerberosTicketEncryption}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ChannelEncryption), out propertyOverride);
            if (Optional.IsDefined(ChannelEncryption) || hasPropertyOverride)
            {
                builder.Append("  channelEncryption: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ChannelEncryption.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ChannelEncryption}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ChannelEncryption}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void TransformFlattenedOverrides(BicepModelReaderWriterOptions bicepOptions, IDictionary<string, string> propertyOverrides)
        {
            foreach (var item in propertyOverrides.ToList())
            {
                switch (item.Key)
                {
                    case "IsMultiChannelEnabled":
                        Dictionary<string, string> propertyDictionary = new Dictionary<string, string>();
                        propertyDictionary.Add("IsMultiChannelEnabled", item.Value);
                        bicepOptions.PropertyOverrides.Add(Multichannel, propertyDictionary);
                        break;
                    default:
                        continue;
                }
            }
        }

        BinaryData IPersistableModel<SmbSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmbSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SmbSetting)} does not support writing '{options.Format}' format.");
            }
        }

        SmbSetting IPersistableModel<SmbSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmbSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSmbSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SmbSetting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SmbSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
