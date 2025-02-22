// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaServicesAccountData : IUtf8JsonSerializable, IJsonModel<MediaServicesAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaServicesAccountData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaServicesAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaServicesAccountData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MediaServicesAccountId))
            {
                writer.WritePropertyName("mediaServiceId"u8);
                writer.WriteStringValue(MediaServicesAccountId.Value);
            }
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue<MediaServicesStorageAccount>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAuthentication))
            {
                if (StorageAuthentication != null)
                {
                    writer.WritePropertyName("storageAuthentication"u8);
                    writer.WriteStringValue(StorageAuthentication.Value.ToString());
                }
                else
                {
                    writer.WriteNull("storageAuthentication");
                }
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue<AccountEncryption>(Encryption, options);
            }
            if (Optional.IsDefined(KeyDelivery))
            {
                writer.WritePropertyName("keyDelivery"u8);
                writer.WriteObjectValue<MediaKeyDelivery>(KeyDelivery, options);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                if (PublicNetworkAccess != null)
                {
                    writer.WritePropertyName("publicNetworkAccess"u8);
                    writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
                }
                else
                {
                    writer.WriteNull("publicNetworkAccess");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue<MediaServicesPrivateEndpointConnectionData>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            writer.WriteEndObject();
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

        MediaServicesAccountData IJsonModel<MediaServicesAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaServicesAccountData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaServicesAccountData(document.RootElement, options);
        }

        internal static MediaServicesAccountData DeserializeMediaServicesAccountData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? mediaServiceId = default;
            IList<MediaServicesStorageAccount> storageAccounts = default;
            MediaStorageAuthentication? storageAuthentication = default;
            AccountEncryption encryption = default;
            MediaKeyDelivery keyDelivery = default;
            MediaServicesPublicNetworkAccess? publicNetworkAccess = default;
            MediaServicesProvisioningState? provisioningState = default;
            IReadOnlyList<MediaServicesPrivateEndpointConnectionData> privateEndpointConnections = default;
            MediaServicesMinimumTlsVersion? minimumTlsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("mediaServiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mediaServiceId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaServicesStorageAccount> array = new List<MediaServicesStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaServicesStorageAccount.DeserializeMediaServicesStorageAccount(item, options));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageAuthentication = null;
                                continue;
                            }
                            storageAuthentication = new MediaStorageAuthentication(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = AccountEncryption.DeserializeAccountEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("keyDelivery"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyDelivery = MediaKeyDelivery.DeserializeMediaKeyDelivery(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicNetworkAccess = null;
                                continue;
                            }
                            publicNetworkAccess = new MediaServicesPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MediaServicesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaServicesPrivateEndpointConnectionData> array = new List<MediaServicesPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaServicesPrivateEndpointConnectionData.DeserializeMediaServicesPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new MediaServicesMinimumTlsVersion(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaServicesAccountData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                mediaServiceId,
                storageAccounts ?? new ChangeTrackingList<MediaServicesStorageAccount>(),
                storageAuthentication,
                encryption,
                keyDelivery,
                publicNetworkAccess,
                provisioningState,
                privateEndpointConnections ?? new ChangeTrackingList<MediaServicesPrivateEndpointConnectionData>(),
                minimumTlsVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaServicesAccountData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaServicesAccountData)} does not support writing '{options.Format}' format.");
            }
        }

        MediaServicesAccountData IPersistableModel<MediaServicesAccountData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaServicesAccountData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaServicesAccountData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaServicesAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
