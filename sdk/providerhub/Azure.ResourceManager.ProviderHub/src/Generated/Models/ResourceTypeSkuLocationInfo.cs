// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuLocationInfo. </summary>
    public partial class ResourceTypeSkuLocationInfo
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

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuLocationInfo"/>. </summary>
        /// <param name="location"></param>
        public ResourceTypeSkuLocationInfo(AzureLocation location)
        {
            Location = location;
            Zones = new ChangeTrackingList<string>();
            ZoneDetails = new ChangeTrackingList<ResourceTypeSkuZoneDetail>();
            ExtendedLocations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuLocationInfo"/>. </summary>
        /// <param name="location"></param>
        /// <param name="zones"></param>
        /// <param name="zoneDetails"></param>
        /// <param name="extendedLocations"></param>
        /// <param name="extendedLocationType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeSkuLocationInfo(AzureLocation location, IList<string> zones, IList<ResourceTypeSkuZoneDetail> zoneDetails, IList<string> extendedLocations, ProviderHubExtendedLocationType? extendedLocationType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Zones = zones;
            ZoneDetails = zoneDetails;
            ExtendedLocations = extendedLocations;
            ExtendedLocationType = extendedLocationType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuLocationInfo"/> for deserialization. </summary>
        internal ResourceTypeSkuLocationInfo()
        {
        }

        /// <summary> Gets or sets the location. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> Gets the zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> Gets the zone details. </summary>
        public IList<ResourceTypeSkuZoneDetail> ZoneDetails { get; }
        /// <summary> Gets the extended locations. </summary>
        public IList<string> ExtendedLocations { get; }
        /// <summary> Gets or sets the extended location type. </summary>
        public ProviderHubExtendedLocationType? ExtendedLocationType { get; set; }
    }
}
