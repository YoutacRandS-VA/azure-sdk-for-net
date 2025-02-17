// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownConnectionInfo))]
    public partial class ConnectionInfo : IUtf8JsonSerializable, IJsonModel<ConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionInfoType);
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        ConnectionInfo IJsonModel<ConnectionInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionInfo(document.RootElement, options);
        }

        internal static ConnectionInfo DeserializeConnectionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "MiSqlConnectionInfo": return MISqlConnectionInfo.DeserializeMISqlConnectionInfo(element, options);
                    case "MongoDbConnectionInfo": return MongoDBConnectionInfo.DeserializeMongoDBConnectionInfo(element, options);
                    case "MySqlConnectionInfo": return MySqlConnectionInfo.DeserializeMySqlConnectionInfo(element, options);
                    case "OracleConnectionInfo": return OracleConnectionInfo.DeserializeOracleConnectionInfo(element, options);
                    case "PostgreSqlConnectionInfo": return PostgreSqlConnectionInfo.DeserializePostgreSqlConnectionInfo(element, options);
                    case "SqlConnectionInfo": return SqlConnectionInfo.DeserializeSqlConnectionInfo(element, options);
                }
            }
            return UnknownConnectionInfo.DeserializeUnknownConnectionInfo(element, options);
        }

        BinaryData IPersistableModel<ConnectionInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectionInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectionInfo IPersistableModel<ConnectionInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectionInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectionInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
