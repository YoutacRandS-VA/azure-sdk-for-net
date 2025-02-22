// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServiceFabricManagedNetworkSecurityRule : IUtf8JsonSerializable, IJsonModel<ServiceFabricManagedNetworkSecurityRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricManagedNetworkSecurityRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceFabricManagedNetworkSecurityRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricManagedNetworkSecurityRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            if (Optional.IsCollectionDefined(SourceAddressPrefixes))
            {
                writer.WritePropertyName("sourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in SourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationAddressPrefixes))
            {
                writer.WritePropertyName("destinationAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourcePortRanges))
            {
                writer.WritePropertyName("sourcePortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPortRanges))
            {
                writer.WritePropertyName("destinationPortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SourceAddressPrefix))
            {
                writer.WritePropertyName("sourceAddressPrefix"u8);
                writer.WriteStringValue(SourceAddressPrefix);
            }
            if (Optional.IsDefined(DestinationAddressPrefix))
            {
                writer.WritePropertyName("destinationAddressPrefix"u8);
                writer.WriteStringValue(DestinationAddressPrefix);
            }
            if (Optional.IsDefined(SourcePortRange))
            {
                writer.WritePropertyName("sourcePortRange"u8);
                writer.WriteStringValue(SourcePortRange);
            }
            if (Optional.IsDefined(DestinationPortRange))
            {
                writer.WritePropertyName("destinationPortRange"u8);
                writer.WriteStringValue(DestinationPortRange);
            }
            writer.WritePropertyName("access"u8);
            writer.WriteStringValue(Access.ToString());
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
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

        ServiceFabricManagedNetworkSecurityRule IJsonModel<ServiceFabricManagedNetworkSecurityRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricManagedNetworkSecurityRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricManagedNetworkSecurityRule(document.RootElement, options);
        }

        internal static ServiceFabricManagedNetworkSecurityRule DeserializeServiceFabricManagedNetworkSecurityRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string description = default;
            ServiceFabricManagedNsgProtocol protocol = default;
            IList<string> sourceAddressPrefixes = default;
            IList<string> destinationAddressPrefixes = default;
            IList<string> sourcePortRanges = default;
            IList<string> destinationPortRanges = default;
            string sourceAddressPrefix = default;
            string destinationAddressPrefix = default;
            string sourcePortRange = default;
            string destinationPortRange = default;
            ServiceFabricManagedNetworkTrafficAccess access = default;
            int priority = default;
            ServiceFabricManagedNetworkSecurityRuleDirection direction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new ServiceFabricManagedNsgProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinationAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("sourcePortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourcePortRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationPortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinationPortRanges = array;
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefix"u8))
                {
                    sourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefix"u8))
                {
                    destinationAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePortRange"u8))
                {
                    sourcePortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPortRange"u8))
                {
                    destinationPortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("access"u8))
                {
                    access = new ServiceFabricManagedNetworkTrafficAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new ServiceFabricManagedNetworkSecurityRuleDirection(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceFabricManagedNetworkSecurityRule(
                name,
                description,
                protocol,
                sourceAddressPrefixes ?? new ChangeTrackingList<string>(),
                destinationAddressPrefixes ?? new ChangeTrackingList<string>(),
                sourcePortRanges ?? new ChangeTrackingList<string>(),
                destinationPortRanges ?? new ChangeTrackingList<string>(),
                sourceAddressPrefix,
                destinationAddressPrefix,
                sourcePortRange,
                destinationPortRange,
                access,
                priority,
                direction,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricManagedNetworkSecurityRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricManagedNetworkSecurityRule)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceFabricManagedNetworkSecurityRule IPersistableModel<ServiceFabricManagedNetworkSecurityRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricManagedNetworkSecurityRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricManagedNetworkSecurityRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricManagedNetworkSecurityRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
