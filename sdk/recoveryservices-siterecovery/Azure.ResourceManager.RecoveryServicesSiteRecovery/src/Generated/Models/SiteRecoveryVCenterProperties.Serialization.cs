// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryVCenterProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryVCenterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryVCenterProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryVCenterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVCenterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryVCenterProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(InternalId))
            {
                writer.WritePropertyName("internalId"u8);
                writer.WriteStringValue(InternalId);
            }
            if (Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartbeat"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (Optional.IsDefined(DiscoveryStatus))
            {
                writer.WritePropertyName("discoveryStatus"u8);
                writer.WriteStringValue(DiscoveryStatus);
            }
            if (Optional.IsDefined(ProcessServerId))
            {
                writer.WritePropertyName("processServerId"u8);
                writer.WriteStringValue(ProcessServerId.Value);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(InfrastructureId))
            {
                writer.WritePropertyName("infrastructureId"u8);
                writer.WriteStringValue(InfrastructureId);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteStringValue(Port);
            }
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            if (Optional.IsDefined(FabricArmResourceName))
            {
                writer.WritePropertyName("fabricArmResourceName"u8);
                writer.WriteStringValue(FabricArmResourceName);
            }
            if (Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue<SiteRecoveryHealthError>(item, options);
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

        SiteRecoveryVCenterProperties IJsonModel<SiteRecoveryVCenterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVCenterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryVCenterProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryVCenterProperties(document.RootElement, options);
        }

        internal static SiteRecoveryVCenterProperties DeserializeSiteRecoveryVCenterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            string internalId = default;
            DateTimeOffset? lastHeartbeat = default;
            string discoveryStatus = default;
            Guid? processServerId = default;
            IPAddress ipAddress = default;
            string infrastructureId = default;
            string port = default;
            string runAsAccountId = default;
            string fabricArmResourceName = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalId"u8))
                {
                    internalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("discoveryStatus"u8))
                {
                    discoveryStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureId"u8))
                {
                    infrastructureId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricArmResourceName"u8))
                {
                    fabricArmResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryVCenterProperties(
                friendlyName,
                internalId,
                lastHeartbeat,
                discoveryStatus,
                processServerId,
                ipAddress,
                infrastructureId,
                port,
                runAsAccountId,
                fabricArmResourceName,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryVCenterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVCenterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryVCenterProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryVCenterProperties IPersistableModel<SiteRecoveryVCenterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVCenterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryVCenterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryVCenterProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryVCenterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
