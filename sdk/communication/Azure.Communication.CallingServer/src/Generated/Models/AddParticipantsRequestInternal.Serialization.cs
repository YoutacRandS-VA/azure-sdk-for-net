// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class AddParticipantsRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceCallerId))
            {
                writer.WritePropertyName("sourceCallerId"u8);
                writer.WriteObjectValue<PhoneNumberIdentifierModel>(SourceCallerId);
            }
            writer.WritePropertyName("participantsToAdd"u8);
            writer.WriteStartArray();
            foreach (var item in ParticipantsToAdd)
            {
                writer.WriteObjectValue<CommunicationIdentifierModel>(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(InvitationTimeoutInSeconds))
            {
                writer.WritePropertyName("invitationTimeoutInSeconds"u8);
                writer.WriteNumberValue(InvitationTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            writer.WriteEndObject();
        }
    }
}
