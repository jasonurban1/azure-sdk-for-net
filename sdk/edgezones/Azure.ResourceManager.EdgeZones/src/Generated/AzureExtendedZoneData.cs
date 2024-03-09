// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeZones.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeZones
{
    /// <summary>
    /// A class representing the AzureExtendedZone data model.
    /// An AzureExtendedZone resource
    /// </summary>
    public partial class AzureExtendedZoneData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AzureExtendedZoneData"/>. </summary>
        internal AzureExtendedZoneData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureExtendedZoneData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="registrationState"> AzureExtendedZone registration approved or not. </param>
        /// <param name="displayName"> AzureExtendedZone displayName. </param>
        /// <param name="regionalDisplayName"> AzureExtendedZone regionalDisplayName. </param>
        /// <param name="regionType"> AzureExtendedZone regionType. </param>
        /// <param name="regionCategory"> AzureExtendedZone regionCategory. </param>
        /// <param name="geography"> AzureExtendedZone geography. </param>
        /// <param name="geographyGroup"> AzureExtendedZone geographyGroup. </param>
        /// <param name="longitude"> AzureExtendedZone longitude. </param>
        /// <param name="latitude"> AzureExtendedZone latitude. </param>
        /// <param name="homeLocation"> AzureExtendedZone homeLocation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureExtendedZoneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProvisioningState? provisioningState, RegistrationState? registrationState, string displayName, string regionalDisplayName, string regionType, string regionCategory, string geography, string geographyGroup, string longitude, string latitude, string homeLocation, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            RegistrationState = registrationState;
            DisplayName = displayName;
            RegionalDisplayName = regionalDisplayName;
            RegionType = regionType;
            RegionCategory = regionCategory;
            Geography = geography;
            GeographyGroup = geographyGroup;
            Longitude = longitude;
            Latitude = latitude;
            HomeLocation = homeLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> AzureExtendedZone registration approved or not. </summary>
        public RegistrationState? RegistrationState { get; }
        /// <summary> AzureExtendedZone displayName. </summary>
        public string DisplayName { get; }
        /// <summary> AzureExtendedZone regionalDisplayName. </summary>
        public string RegionalDisplayName { get; }
        /// <summary> AzureExtendedZone regionType. </summary>
        public string RegionType { get; }
        /// <summary> AzureExtendedZone regionCategory. </summary>
        public string RegionCategory { get; }
        /// <summary> AzureExtendedZone geography. </summary>
        public string Geography { get; }
        /// <summary> AzureExtendedZone geographyGroup. </summary>
        public string GeographyGroup { get; }
        /// <summary> AzureExtendedZone longitude. </summary>
        public string Longitude { get; }
        /// <summary> AzureExtendedZone latitude. </summary>
        public string Latitude { get; }
        /// <summary> AzureExtendedZone homeLocation. </summary>
        public string HomeLocation { get; }
    }
}
