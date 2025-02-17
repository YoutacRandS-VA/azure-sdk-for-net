// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WebClientCertificateAuthenticationConverter))]
    public partial class WebClientCertificateAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pfx"u8);
            writer.WriteObjectValue<SecretBase>(Pfx);
            writer.WritePropertyName("password"u8);
            writer.WriteObjectValue<SecretBase>(Password);
            writer.WritePropertyName("url"u8);
            writer.WriteObjectValue<object>(Url);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static WebClientCertificateAuthentication DeserializeWebClientCertificateAuthentication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecretBase pfx = default;
            SecretBase password = default;
            object url = default;
            WebAuthenticationType authenticationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pfx"u8))
                {
                    pfx = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
            }
            return new WebClientCertificateAuthentication(url, authenticationType, pfx, password);
        }

        internal partial class WebClientCertificateAuthenticationConverter : JsonConverter<WebClientCertificateAuthentication>
        {
            public override void Write(Utf8JsonWriter writer, WebClientCertificateAuthentication model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<WebClientCertificateAuthentication>(model);
            }
            public override WebClientCertificateAuthentication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebClientCertificateAuthentication(document.RootElement);
            }
        }
    }
}
