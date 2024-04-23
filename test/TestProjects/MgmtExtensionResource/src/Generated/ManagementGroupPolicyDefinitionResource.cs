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
using Azure.ResourceManager.ManagementGroups;

namespace MgmtExtensionResource
{
    /// <summary>
    /// A Class representing a ManagementGroupPolicyDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagementGroupPolicyDefinitionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagementGroupPolicyDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagementGroupResource"/> using the GetManagementGroupPolicyDefinition method.
    /// </summary>
    public partial class ManagementGroupPolicyDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementGroupPolicyDefinitionResource"/> instance. </summary>
        /// <param name="managementGroupId"> The managementGroupId. </param>
        /// <param name="policyDefinitionName"> The policyDefinitionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string policyDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _managementGroupPolicyDefinitionPolicyDefinitionsRestClient;
        private readonly PolicyDefinitionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyDefinitions";

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionResource"/> class for mocking. </summary>
        protected ManagementGroupPolicyDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagementGroupPolicyDefinitionResource(ArmClient client, PolicyDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroupPolicyDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("MgmtExtensionResource", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
            _managementGroupPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyDefinitionData Data
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
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagementGroupPolicyDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementGroupPolicyDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation deletes the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_DeleteAtManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.DeleteAtManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateDeleteAtManagementGroupRequestUri(Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExtensionResourceArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation deletes the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_DeleteAtManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.DeleteAtManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateDeleteAtManagementGroupRequestUri(Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExtensionResourceArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation creates or updates a policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_CreateOrUpdateAtManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagementGroupPolicyDefinitionResource>> UpdateAsync(WaitUntil waitUntil, PolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAtManagementGroupAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateCreateOrUpdateAtManagementGroupRequestUri(Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExtensionResourceArmOperation<ManagementGroupPolicyDefinitionResource>(Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// This operation creates or updates a policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_CreateOrUpdateAtManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupPolicyDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagementGroupPolicyDefinitionResource> Update(WaitUntil waitUntil, PolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAtManagementGroup(Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateCreateOrUpdateAtManagementGroupRequestUri(Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExtensionResourceArmOperation<ManagementGroupPolicyDefinitionResource>(Response.FromValue(new ManagementGroupPolicyDefinitionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
