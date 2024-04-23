// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtSupersetInheritance
{
    /// <summary>
    /// A Class representing a SupersetModel6 along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SupersetModel6Resource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSupersetModel6Resource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetSupersetModel6 method.
    /// </summary>
    public partial class SupersetModel6Resource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupersetModel6Resource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="supersetModel6SName"> The supersetModel6SName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string supersetModel6SName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6SName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supersetModel6ClientDiagnostics;
        private readonly SupersetModel6SRestOperations _supersetModel6RestClient;
        private readonly SupersetModel6Data _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/supersetModel6s";

        /// <summary> Initializes a new instance of the <see cref="SupersetModel6Resource"/> class for mocking. </summary>
        protected SupersetModel6Resource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupersetModel6Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupersetModel6Resource(ArmClient client, SupersetModel6Data data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupersetModel6Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupersetModel6Resource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supersetModel6ClientDiagnostics = new ClientDiagnostics("MgmtSupersetInheritance", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supersetModel6ApiVersion);
            _supersetModel6RestClient = new SupersetModel6SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supersetModel6ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupersetModel6Data Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel6s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupersetModel6Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupersetModel6Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supersetModel6ClientDiagnostics.CreateScope("SupersetModel6Resource.Get");
            scope.Start();
            try
            {
                var response = await _supersetModel6RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupersetModel6Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel6s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupersetModel6Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupersetModel6Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supersetModel6ClientDiagnostics.CreateScope("SupersetModel6Resource.Get");
            scope.Start();
            try
            {
                var response = _supersetModel6RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupersetModel6Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel6s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupersetModel6Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="SupersetModel6Data"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupersetModel6Resource>> UpdateAsync(WaitUntil waitUntil, SupersetModel6Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supersetModel6ClientDiagnostics.CreateScope("SupersetModel6Resource.Update");
            scope.Start();
            try
            {
                var response = await _supersetModel6RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _supersetModel6RestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtSupersetInheritanceArmOperation<SupersetModel6Resource>(Response.FromValue(new SupersetModel6Resource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel6s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupersetModel6Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="SupersetModel6Data"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupersetModel6Resource> Update(WaitUntil waitUntil, SupersetModel6Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supersetModel6ClientDiagnostics.CreateScope("SupersetModel6Resource.Update");
            scope.Start();
            try
            {
                var response = _supersetModel6RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken);
                var uri = _supersetModel6RestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtSupersetInheritanceArmOperation<SupersetModel6Resource>(Response.FromValue(new SupersetModel6Resource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
