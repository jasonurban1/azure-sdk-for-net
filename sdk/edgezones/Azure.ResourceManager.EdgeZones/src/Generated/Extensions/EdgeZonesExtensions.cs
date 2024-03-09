// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeZones.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeZones
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EdgeZones. </summary>
    public static partial class EdgeZonesExtensions
    {
        private static MockableEdgeZonesArmClient GetMockableEdgeZonesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableEdgeZonesArmClient(client0));
        }

        private static MockableEdgeZonesSubscriptionResource GetMockableEdgeZonesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableEdgeZonesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureExtendedZoneResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureExtendedZoneResource.CreateResourceIdentifier" /> to create an <see cref="AzureExtendedZoneResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableEdgeZonesArmClient.GetAzureExtendedZoneResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AzureExtendedZoneResource"/> object. </returns>
        public static AzureExtendedZoneResource GetAzureExtendedZoneResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableEdgeZonesArmClient(client).GetAzureExtendedZoneResource(id);
        }

        /// <summary>
        /// Gets a collection of AzureExtendedZoneResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableEdgeZonesSubscriptionResource.GetAzureExtendedZones()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An object representing collection of AzureExtendedZoneResources and their operations over a AzureExtendedZoneResource. </returns>
        public static AzureExtendedZoneCollection GetAzureExtendedZones(this SubscriptionResource subscriptionResource)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableEdgeZonesSubscriptionResource(subscriptionResource).GetAzureExtendedZones();
        }

        /// <summary>
        /// Get an Azure Extended Zone for a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeZones/azureExtendedZones/{azureExtendedZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureExtendedZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureExtendedZoneResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableEdgeZonesSubscriptionResource.GetAzureExtendedZoneAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="azureExtendedZoneName"> The name of the AzureExtendedZone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="azureExtendedZoneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureExtendedZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AzureExtendedZoneResource>> GetAzureExtendedZoneAsync(this SubscriptionResource subscriptionResource, string azureExtendedZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableEdgeZonesSubscriptionResource(subscriptionResource).GetAzureExtendedZoneAsync(azureExtendedZoneName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an Azure Extended Zone for a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeZones/azureExtendedZones/{azureExtendedZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureExtendedZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureExtendedZoneResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableEdgeZonesSubscriptionResource.GetAzureExtendedZone(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="azureExtendedZoneName"> The name of the AzureExtendedZone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="azureExtendedZoneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureExtendedZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AzureExtendedZoneResource> GetAzureExtendedZone(this SubscriptionResource subscriptionResource, string azureExtendedZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableEdgeZonesSubscriptionResource(subscriptionResource).GetAzureExtendedZone(azureExtendedZoneName, cancellationToken);
        }
    }
}
