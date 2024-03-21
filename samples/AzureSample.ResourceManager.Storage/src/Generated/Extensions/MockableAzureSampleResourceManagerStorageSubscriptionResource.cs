// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using AzureSample.ResourceManager.Storage.Models;

namespace AzureSample.ResourceManager.Storage.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAzureSampleResourceManagerStorageSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _storageAccountClientDiagnostics;
        private StorageAccountsRestOperations _storageAccountRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAzureSampleResourceManagerStorageSubscriptionResource"/> class for mocking. </summary>
        protected MockableAzureSampleResourceManagerStorageSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAzureSampleResourceManagerStorageSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAzureSampleResourceManagerStorageSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("AzureSample.ResourceManager.Storage", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics StorageAccountClientDiagnostics => _storageAccountClientDiagnostics ??= new ClientDiagnostics("AzureSample.ResourceManager.Storage", StorageAccountResource.ResourceType.Namespace, Diagnostics);
        private StorageAccountsRestOperations StorageAccountRestClient => _storageAccountRestClient ??= new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageAccountResource.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("AzureSample.ResourceManager.Storage", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedAccountResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedAccountResources and their operations over a DeletedAccountResource. </returns>
        public virtual DeletedAccountCollection GetDeletedAccounts()
        {
            return GetCachedClient(client => new DeletedAccountCollection(client, Id));
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DeletedAccountResource>> GetDeletedAccountAsync(AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return await GetDeletedAccounts().GetAsync(location, deletedAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DeletedAccountResource> GetDeletedAccount(AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return GetDeletedAccounts().Get(location, deletedAccountName, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureSampleResourceManagerStorageSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureSampleResourceManagerStorageSkuInformation> GetSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AzureSampleResourceManagerStorageSkuInformation.DeserializeAzureSampleResourceManagerStorageSkuInformation, SkusClientDiagnostics, Pipeline, "MockableAzureSampleResourceManagerStorageSubscriptionResource.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureSampleResourceManagerStorageSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureSampleResourceManagerStorageSkuInformation> GetSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AzureSampleResourceManagerStorageSkuInformation.DeserializeAzureSampleResourceManagerStorageSkuInformation, SkusClientDiagnostics, Pipeline, "MockableAzureSampleResourceManagerStorageSubscriptionResource.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccountResource> GetStorageAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageAccountResource(Client, StorageAccountData.DeserializeStorageAccountData(e)), StorageAccountClientDiagnostics, Pipeline, "MockableAzureSampleResourceManagerStorageSubscriptionResource.GetStorageAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccountResource> GetStorageAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageAccountResource(Client, StorageAccountData.DeserializeStorageAccountData(e)), StorageAccountClientDiagnostics, Pipeline, "MockableAzureSampleResourceManagerStorageSubscriptionResource.GetStorageAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureSampleResourceManagerStorageUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureSampleResourceManagerStorageUsage> GetUsagesByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AzureSampleResourceManagerStorageUsage.DeserializeAzureSampleResourceManagerStorageUsage, UsagesClientDiagnostics, Pipeline, "MockableAzureSampleResourceManagerStorageSubscriptionResource.GetUsagesByLocation", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureSampleResourceManagerStorageUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureSampleResourceManagerStorageUsage> GetUsagesByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AzureSampleResourceManagerStorageUsage.DeserializeAzureSampleResourceManagerStorageUsage, UsagesClientDiagnostics, Pipeline, "MockableAzureSampleResourceManagerStorageSubscriptionResource.GetUsagesByLocation", "value", null, cancellationToken);
        }
    }
}
