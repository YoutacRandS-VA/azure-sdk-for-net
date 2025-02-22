// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to indicate the information about the restore. </summary>
    public partial class RestoreParametersBase
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RestoreParametersBase"/>. </summary>
        public RestoreParametersBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestoreParametersBase"/>. </summary>
        /// <param name="restoreSource"> The id of the restorable database account from which the restore has to be initiated. For example: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}. </param>
        /// <param name="restoreTimestampInUtc"> Time to which the account has to be restored (ISO-8601 format). </param>
        /// <param name="restoreWithTtlDisabled"> Specifies whether the restored account will have Time-To-Live disabled upon the successful restore. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestoreParametersBase(string restoreSource, DateTimeOffset? restoreTimestampInUtc, bool? restoreWithTtlDisabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RestoreSource = restoreSource;
            RestoreTimestampInUtc = restoreTimestampInUtc;
            RestoreWithTtlDisabled = restoreWithTtlDisabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the restorable database account from which the restore has to be initiated. For example: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}. </summary>
        [WirePath("restoreSource")]
        public string RestoreSource { get; set; }
        /// <summary> Time to which the account has to be restored (ISO-8601 format). </summary>
        [WirePath("restoreTimestampInUtc")]
        public DateTimeOffset? RestoreTimestampInUtc { get; set; }
        /// <summary> Specifies whether the restored account will have Time-To-Live disabled upon the successful restore. </summary>
        [WirePath("restoreWithTtlDisabled")]
        public bool? RestoreWithTtlDisabled { get; set; }
    }
}
