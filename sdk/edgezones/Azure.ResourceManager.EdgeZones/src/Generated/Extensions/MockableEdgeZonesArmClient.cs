// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeZones;

namespace Azure.ResourceManager.EdgeZones.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableEdgeZonesArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableEdgeZonesArmClient"/> class for mocking. </summary>
        protected MockableEdgeZonesArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEdgeZonesArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEdgeZonesArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableEdgeZonesArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureExtendedZoneResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureExtendedZoneResource.CreateResourceIdentifier" /> to create an <see cref="AzureExtendedZoneResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureExtendedZoneResource"/> object. </returns>
        public virtual AzureExtendedZoneResource GetAzureExtendedZoneResource(ResourceIdentifier id)
        {
            AzureExtendedZoneResource.ValidateResourceId(id);
            return new AzureExtendedZoneResource(Client, id);
        }
    }
}
