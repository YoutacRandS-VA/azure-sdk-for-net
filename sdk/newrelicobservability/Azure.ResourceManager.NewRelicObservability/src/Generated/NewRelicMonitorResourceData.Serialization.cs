// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    public partial class NewRelicMonitorResourceData : IUtf8JsonSerializable, IJsonModel<NewRelicMonitorResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicMonitorResourceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewRelicMonitorResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitorResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicMonitorResourceData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MonitoringStatus))
            {
                writer.WritePropertyName("monitoringStatus"u8);
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceSubscriptionStatus))
            {
                writer.WritePropertyName("marketplaceSubscriptionStatus"u8);
                writer.WriteStringValue(MarketplaceSubscriptionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceSubscriptionId))
            {
                writer.WritePropertyName("marketplaceSubscriptionId"u8);
                writer.WriteStringValue(MarketplaceSubscriptionId);
            }
            if (Optional.IsDefined(NewRelicAccountProperties))
            {
                writer.WritePropertyName("newRelicAccountProperties"u8);
                writer.WriteObjectValue<NewRelicAccountProperties>(NewRelicAccountProperties, options);
            }
            if (Optional.IsDefined(UserInfo))
            {
                writer.WritePropertyName("userInfo"u8);
                writer.WriteObjectValue<NewRelicObservabilityUserInfo>(UserInfo, options);
            }
            if (Optional.IsDefined(PlanData))
            {
                writer.WritePropertyName("planData"u8);
                writer.WriteObjectValue<NewRelicPlanDetails>(PlanData, options);
            }
            if (options.Format != "W" && Optional.IsDefined(LiftrResourceCategory))
            {
                writer.WritePropertyName("liftrResourceCategory"u8);
                writer.WriteStringValue(LiftrResourceCategory.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LiftrResourcePreference))
            {
                writer.WritePropertyName("liftrResourcePreference"u8);
                writer.WriteNumberValue(LiftrResourcePreference.Value);
            }
            if (Optional.IsDefined(OrgCreationSource))
            {
                writer.WritePropertyName("orgCreationSource"u8);
                writer.WriteStringValue(OrgCreationSource.Value.ToString());
            }
            if (Optional.IsDefined(AccountCreationSource))
            {
                writer.WritePropertyName("accountCreationSource"u8);
                writer.WriteStringValue(AccountCreationSource.Value.ToString());
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

        NewRelicMonitorResourceData IJsonModel<NewRelicMonitorResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitorResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicMonitorResourceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicMonitorResourceData(document.RootElement, options);
        }

        internal static NewRelicMonitorResourceData DeserializeNewRelicMonitorResourceData(JsonElement element, ModelReaderWriterOptions options = null)
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
            NewRelicProvisioningState? provisioningState = default;
            NewRelicObservabilityMonitoringStatus? monitoringStatus = default;
            NewRelicObservabilityMarketplaceSubscriptionStatus? marketplaceSubscriptionStatus = default;
            string marketplaceSubscriptionId = default;
            NewRelicAccountProperties newRelicAccountProperties = default;
            NewRelicObservabilityUserInfo userInfo = default;
            NewRelicPlanDetails planData = default;
            NewRelicLiftrResourceCategory? liftrResourceCategory = default;
            int? liftrResourcePreference = default;
            NewRelicObservabilityOrgCreationSource? orgCreationSource = default;
            NewRelicObservabilityAccountCreationSource? accountCreationSource = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NewRelicProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("monitoringStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitoringStatus = new NewRelicObservabilityMonitoringStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceSubscriptionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceSubscriptionStatus = new NewRelicObservabilityMarketplaceSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceSubscriptionId"u8))
                        {
                            marketplaceSubscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("newRelicAccountProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newRelicAccountProperties = NewRelicAccountProperties.DeserializeNewRelicAccountProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("userInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userInfo = NewRelicObservabilityUserInfo.DeserializeNewRelicObservabilityUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("planData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            planData = NewRelicPlanDetails.DeserializeNewRelicPlanDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("liftrResourceCategory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            liftrResourceCategory = new NewRelicLiftrResourceCategory(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("liftrResourcePreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            liftrResourcePreference = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("orgCreationSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            orgCreationSource = new NewRelicObservabilityOrgCreationSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accountCreationSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountCreationSource = new NewRelicObservabilityAccountCreationSource(property0.Value.GetString());
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
            return new NewRelicMonitorResourceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                provisioningState,
                monitoringStatus,
                marketplaceSubscriptionStatus,
                marketplaceSubscriptionId,
                newRelicAccountProperties,
                userInfo,
                planData,
                liftrResourceCategory,
                liftrResourcePreference,
                orgCreationSource,
                accountCreationSource,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicMonitorResourceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitorResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicMonitorResourceData)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicMonitorResourceData IPersistableModel<NewRelicMonitorResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitorResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicMonitorResourceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicMonitorResourceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicMonitorResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
