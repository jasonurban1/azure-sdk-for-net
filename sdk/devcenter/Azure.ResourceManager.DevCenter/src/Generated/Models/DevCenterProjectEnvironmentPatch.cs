// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The project environment type for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterProjectEnvironmentPatch
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

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectEnvironmentPatch"/>. </summary>
        public DevCenterProjectEnvironmentPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            UserRoleAssignments = new ChangeTrackingDictionary<string, DevCenterUserRoleAssignments>();
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectEnvironmentPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> Managed identity properties. </param>
        /// <param name="deploymentTargetId"> Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription. </param>
        /// <param name="status"> Defines whether this Environment Type can be used in this Project. </param>
        /// <param name="creatorRoleAssignment"> The role definition assigned to the environment creator on backing resources. </param>
        /// <param name="userRoleAssignments"> Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterProjectEnvironmentPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, ResourceIdentifier deploymentTargetId, EnvironmentTypeEnableStatus? status, ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment creatorRoleAssignment, IDictionary<string, DevCenterUserRoleAssignments> userRoleAssignments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            DeploymentTargetId = deploymentTargetId;
            Status = status;
            CreatorRoleAssignment = creatorRoleAssignment;
            UserRoleAssignments = userRoleAssignments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Managed identity properties. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription. </summary>
        public ResourceIdentifier DeploymentTargetId { get; set; }
        /// <summary> Defines whether this Environment Type can be used in this Project. </summary>
        public EnvironmentTypeEnableStatus? Status { get; set; }
        /// <summary> The role definition assigned to the environment creator on backing resources. </summary>
        internal ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment CreatorRoleAssignment { get; set; }
        /// <summary> A map of roles to assign to the environment creator. </summary>
        public IDictionary<string, DevCenterEnvironmentRole> Roles
        {
            get
            {
                if (CreatorRoleAssignment is null)
                    CreatorRoleAssignment = new ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment();
                return CreatorRoleAssignment.Roles;
            }
        }

        /// <summary> Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs. </summary>
        public IDictionary<string, DevCenterUserRoleAssignments> UserRoleAssignments { get; }
    }
}
