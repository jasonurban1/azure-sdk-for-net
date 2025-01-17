// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> RCM proxy details. </summary>
    public partial class RcmProxyDetails
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RcmProxyDetails"/>. </summary>
        internal RcmProxyDetails()
        {
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="RcmProxyDetails"/>. </summary>
        /// <param name="id"> The RCM proxy Id. </param>
        /// <param name="name"> The RCM proxy name. </param>
        /// <param name="biosId"> The RCM proxy Bios Id. </param>
        /// <param name="fabricObjectId"> The fabric object Id. </param>
        /// <param name="fqdn"> The RCM proxy Fqdn. </param>
        /// <param name="clientAuthenticationType"> The client authentication type. </param>
        /// <param name="version"> The version. </param>
        /// <param name="lastHeartbeatReceivedOn"> The last heartbeat received from the RCM proxy. </param>
        /// <param name="health"> The health of the RCM proxy. </param>
        /// <param name="healthErrors"> The health errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RcmProxyDetails(string id, string name, string biosId, ResourceIdentifier fabricObjectId, string fqdn, string clientAuthenticationType, string version, DateTimeOffset? lastHeartbeatReceivedOn, SiteRecoveryProtectionHealth? health, IReadOnlyList<SiteRecoveryHealthError> healthErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            FabricObjectId = fabricObjectId;
            Fqdn = fqdn;
            ClientAuthenticationType = clientAuthenticationType;
            Version = version;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            Health = health;
            HealthErrors = healthErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The RCM proxy Id. </summary>
        public string Id { get; }
        /// <summary> The RCM proxy name. </summary>
        public string Name { get; }
        /// <summary> The RCM proxy Bios Id. </summary>
        public string BiosId { get; }
        /// <summary> The fabric object Id. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> The RCM proxy Fqdn. </summary>
        public string Fqdn { get; }
        /// <summary> The client authentication type. </summary>
        public string ClientAuthenticationType { get; }
        /// <summary> The version. </summary>
        public string Version { get; }
        /// <summary> The last heartbeat received from the RCM proxy. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> The health of the RCM proxy. </summary>
        public SiteRecoveryProtectionHealth? Health { get; }
        /// <summary> The health errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
    }
}
