// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PlaywrightTesting;
using Azure.ResourceManager.PlaywrightTesting.Models;

namespace Azure.ResourceManager.PlaywrightTesting.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockablePlaywrightTestingSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _playwrightTestingAccountAccountsClientDiagnostics;
        private AccountsRestOperations _playwrightTestingAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockablePlaywrightTestingSubscriptionResource"/> class for mocking. </summary>
        protected MockablePlaywrightTestingSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePlaywrightTestingSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePlaywrightTestingSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PlaywrightTestingAccountAccountsClientDiagnostics => _playwrightTestingAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PlaywrightTesting", PlaywrightTestingAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations PlaywrightTestingAccountAccountsRestClient => _playwrightTestingAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(PlaywrightTestingAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PlaywrightTestingQuotaResources in the SubscriptionResource. </summary>
        /// <param name="location"> The location of quota in ARM Normalized format like eastus, southeastasia etc. </param>
        /// <returns> An object representing collection of PlaywrightTestingQuotaResources and their operations over a PlaywrightTestingQuotaResource. </returns>
        public virtual PlaywrightTestingQuotaCollection GetAllPlaywrightTestingQuota(AzureLocation location)
        {
            return new PlaywrightTestingQuotaCollection(Client, Id, location);
        }

        /// <summary>
        /// Get quota by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/locations/{location}/quotas/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of quota in ARM Normalized format like eastus, southeastasia etc. </param>
        /// <param name="name"> The quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<PlaywrightTestingQuotaResource>> GetPlaywrightTestingQuotaAsync(AzureLocation location, PlaywrightTestingQuotaName name, CancellationToken cancellationToken = default)
        {
            return await GetAllPlaywrightTestingQuota(location).GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get quota by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/locations/{location}/quotas/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of quota in ARM Normalized format like eastus, southeastasia etc. </param>
        /// <param name="name"> The quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<PlaywrightTestingQuotaResource> GetPlaywrightTestingQuota(AzureLocation location, PlaywrightTestingQuotaName name, CancellationToken cancellationToken = default)
        {
            return GetAllPlaywrightTestingQuota(location).Get(name, cancellationToken);
        }

        /// <summary>
        /// List Account resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PlaywrightTestingAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PlaywrightTestingAccountResource> GetPlaywrightTestingAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PlaywrightTestingAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PlaywrightTestingAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PlaywrightTestingAccountResource(Client, PlaywrightTestingAccountData.DeserializePlaywrightTestingAccountData(e)), PlaywrightTestingAccountAccountsClientDiagnostics, Pipeline, "MockablePlaywrightTestingSubscriptionResource.GetPlaywrightTestingAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Account resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PlaywrightTestingAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PlaywrightTestingAccountResource> GetPlaywrightTestingAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PlaywrightTestingAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PlaywrightTestingAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PlaywrightTestingAccountResource(Client, PlaywrightTestingAccountData.DeserializePlaywrightTestingAccountData(e)), PlaywrightTestingAccountAccountsClientDiagnostics, Pipeline, "MockablePlaywrightTestingSubscriptionResource.GetPlaywrightTestingAccounts", "value", "nextLink", cancellationToken);
        }
    }
}
