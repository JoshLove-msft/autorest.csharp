// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtExpandResourceTypes.Models;

namespace MgmtExpandResourceTypes
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _zoneClientDiagnostics;
        private ZonesRestOperations _zoneRestClient;
        private ClientDiagnostics _dnsResourceReferenceClientDiagnostics;
        private DnsResourceReferenceRestOperations _dnsResourceReferenceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ZoneClientDiagnostics => _zoneClientDiagnostics ??= new ClientDiagnostics("MgmtExpandResourceTypes", ZoneResource.ResourceType.Namespace, Diagnostics);
        private ZonesRestOperations ZoneRestClient => _zoneRestClient ??= new ZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ZoneResource.ResourceType));
        private ClientDiagnostics DnsResourceReferenceClientDiagnostics => _dnsResourceReferenceClientDiagnostics ??= new ClientDiagnostics("MgmtExpandResourceTypes", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DnsResourceReferenceRestOperations DnsResourceReferenceRestClient => _dnsResourceReferenceRestClient ??= new DnsResourceReferenceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the DNS zones in all resource groups in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones
        /// Operation Id: Zones_List
        /// </summary>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ZoneResource> GetZonesByDnszoneAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ZoneResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ZoneClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetZonesByDnszone");
                scope.Start();
                try
                {
                    var response = await ZoneRestClient.ListAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ZoneResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ZoneResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ZoneClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetZonesByDnszone");
                scope.Start();
                try
                {
                    var response = await ZoneRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ZoneResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the DNS zones in all resource groups in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones
        /// Operation Id: Zones_List
        /// </summary>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ZoneResource> GetZonesByDnszone(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ZoneResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ZoneClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetZonesByDnszone");
                scope.Start();
                try
                {
                    var response = ZoneRestClient.List(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ZoneResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ZoneResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ZoneClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetZonesByDnszone");
                scope.Start();
                try
                {
                    var response = ZoneRestClient.ListNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ZoneResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns the DNS records specified by the referencing targetResourceIds.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference
        /// Operation Id: DnsResourceReference_GetByTargetResources
        /// </summary>
        /// <param name="content"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DnsResourceReferenceResult>> GetByTargetResourcesDnsResourceReferenceAsync(DnsResourceReferenceContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DnsResourceReferenceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetByTargetResourcesDnsResourceReference");
            scope.Start();
            try
            {
                var response = await DnsResourceReferenceRestClient.GetByTargetResourcesAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the DNS records specified by the referencing targetResourceIds.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference
        /// Operation Id: DnsResourceReference_GetByTargetResources
        /// </summary>
        /// <param name="content"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DnsResourceReferenceResult> GetByTargetResourcesDnsResourceReference(DnsResourceReferenceContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DnsResourceReferenceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetByTargetResourcesDnsResourceReference");
            scope.Start();
            try
            {
                var response = DnsResourceReferenceRestClient.GetByTargetResources(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}