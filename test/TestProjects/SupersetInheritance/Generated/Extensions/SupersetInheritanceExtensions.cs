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
using Azure.ResourceManager.Resources;
using SupersetInheritance.Models;

namespace SupersetInheritance
{
    /// <summary> A class to add extension methods to SupersetInheritance. </summary>
    public static partial class SupersetInheritanceExtensions
    {
        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of SupersetModel1Resources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SupersetModel1Resources and their operations over a SupersetModel1Resource. </returns>
        public static SupersetModel1Collection GetSupersetModel1s(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSupersetModel1s();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SupersetModel1Resource>> GetSupersetModel1Async(this ResourceGroupResource resourceGroupResource, string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSupersetModel1s().GetAsync(supersetModel1SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SupersetModel1Resource> GetSupersetModel1(this ResourceGroupResource resourceGroupResource, string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSupersetModel1s().Get(supersetModel1SName, cancellationToken);
        }

        /// <summary> Gets a collection of SupersetModel4Resources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SupersetModel4Resources and their operations over a SupersetModel4Resource. </returns>
        public static SupersetModel4Collection GetSupersetModel4s(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSupersetModel4s();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel4s/{supersetModel4sName}
        /// Operation Id: SupersetModel4s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel4SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel4SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SupersetModel4Resource>> GetSupersetModel4Async(this ResourceGroupResource resourceGroupResource, string supersetModel4SName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSupersetModel4s().GetAsync(supersetModel4SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel4s/{supersetModel4sName}
        /// Operation Id: SupersetModel4s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel4SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel4SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SupersetModel4Resource> GetSupersetModel4(this ResourceGroupResource resourceGroupResource, string supersetModel4SName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSupersetModel4s().Get(supersetModel4SName, cancellationToken);
        }

        /// <summary> Gets a collection of SupersetModel6Resources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SupersetModel6Resources and their operations over a SupersetModel6Resource. </returns>
        public static SupersetModel6Collection GetSupersetModel6s(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSupersetModel6s();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}
        /// Operation Id: SupersetModel6s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel6SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel6SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel6SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SupersetModel6Resource>> GetSupersetModel6Async(this ResourceGroupResource resourceGroupResource, string supersetModel6SName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSupersetModel6s().GetAsync(supersetModel6SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}
        /// Operation Id: SupersetModel6s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel6SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel6SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel6SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SupersetModel6Resource> GetSupersetModel6(this ResourceGroupResource resourceGroupResource, string supersetModel6SName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSupersetModel6s().Get(supersetModel6SName, cancellationToken);
        }

        /// <summary> Gets a collection of SupersetModel7Resources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SupersetModel7Resources and their operations over a SupersetModel7Resource. </returns>
        public static SupersetModel7Collection GetSupersetModel7s(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSupersetModel7s();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}
        /// Operation Id: SupersetModel7s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SupersetModel7Resource>> GetSupersetModel7Async(this ResourceGroupResource resourceGroupResource, string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSupersetModel7s().GetAsync(supersetModel7SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}
        /// Operation Id: SupersetModel7s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SupersetModel7Resource> GetSupersetModel7(this ResourceGroupResource resourceGroupResource, string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSupersetModel7s().Get(supersetModel7SName, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}
        /// Operation Id: SupersetModel2s_Put
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="supersetModel2"> The SupersetModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> or <paramref name="supersetModel2"/> is null. </exception>
        public static async Task<Response<SupersetModel2>> PutSupersetModel2Async(this ResourceGroupResource resourceGroupResource, string supersetModel2SName, SupersetModel2 supersetModel2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));
            Argument.AssertNotNull(supersetModel2, nameof(supersetModel2));

            return await GetExtensionClient(resourceGroupResource).PutSupersetModel2Async(supersetModel2SName, supersetModel2, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}
        /// Operation Id: SupersetModel2s_Put
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="supersetModel2"> The SupersetModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> or <paramref name="supersetModel2"/> is null. </exception>
        public static Response<SupersetModel2> PutSupersetModel2(this ResourceGroupResource resourceGroupResource, string supersetModel2SName, SupersetModel2 supersetModel2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));
            Argument.AssertNotNull(supersetModel2, nameof(supersetModel2));

            return GetExtensionClient(resourceGroupResource).PutSupersetModel2(supersetModel2SName, supersetModel2, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}
        /// Operation Id: SupersetModel2s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> is null. </exception>
        public static async Task<Response<SupersetModel2>> GetSupersetModel2Async(this ResourceGroupResource resourceGroupResource, string supersetModel2SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));

            return await GetExtensionClient(resourceGroupResource).GetSupersetModel2Async(supersetModel2SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}
        /// Operation Id: SupersetModel2s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> is null. </exception>
        public static Response<SupersetModel2> GetSupersetModel2(this ResourceGroupResource resourceGroupResource, string supersetModel2SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));

            return GetExtensionClient(resourceGroupResource).GetSupersetModel2(supersetModel2SName, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}
        /// Operation Id: SupersetModel3s_Put
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="supersetModel3"> The SupersetModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> or <paramref name="supersetModel3"/> is null. </exception>
        public static async Task<Response<SupersetModel3>> PutSupersetModel3Async(this ResourceGroupResource resourceGroupResource, string supersetModel3SName, SupersetModel3 supersetModel3, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));
            Argument.AssertNotNull(supersetModel3, nameof(supersetModel3));

            return await GetExtensionClient(resourceGroupResource).PutSupersetModel3Async(supersetModel3SName, supersetModel3, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}
        /// Operation Id: SupersetModel3s_Put
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="supersetModel3"> The SupersetModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> or <paramref name="supersetModel3"/> is null. </exception>
        public static Response<SupersetModel3> PutSupersetModel3(this ResourceGroupResource resourceGroupResource, string supersetModel3SName, SupersetModel3 supersetModel3, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));
            Argument.AssertNotNull(supersetModel3, nameof(supersetModel3));

            return GetExtensionClient(resourceGroupResource).PutSupersetModel3(supersetModel3SName, supersetModel3, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}
        /// Operation Id: SupersetModel3s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> is null. </exception>
        public static async Task<Response<SupersetModel3>> GetSupersetModel3Async(this ResourceGroupResource resourceGroupResource, string supersetModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));

            return await GetExtensionClient(resourceGroupResource).GetSupersetModel3Async(supersetModel3SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}
        /// Operation Id: SupersetModel3s_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> is null. </exception>
        public static Response<SupersetModel3> GetSupersetModel3(this ResourceGroupResource resourceGroupResource, string supersetModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));

            return GetExtensionClient(resourceGroupResource).GetSupersetModel3(supersetModel3SName, cancellationToken);
        }

        #region SupersetModel1Resource
        /// <summary>
        /// Gets an object representing a <see cref="SupersetModel1Resource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SupersetModel1Resource.CreateResourceIdentifier" /> to create a <see cref="SupersetModel1Resource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SupersetModel1Resource" /> object. </returns>
        public static SupersetModel1Resource GetSupersetModel1Resource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SupersetModel1Resource.ValidateResourceId(id);
                return new SupersetModel1Resource(client, id);
            }
            );
        }
        #endregion

        #region SupersetModel4Resource
        /// <summary>
        /// Gets an object representing a <see cref="SupersetModel4Resource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SupersetModel4Resource.CreateResourceIdentifier" /> to create a <see cref="SupersetModel4Resource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SupersetModel4Resource" /> object. </returns>
        public static SupersetModel4Resource GetSupersetModel4Resource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SupersetModel4Resource.ValidateResourceId(id);
                return new SupersetModel4Resource(client, id);
            }
            );
        }
        #endregion

        #region SupersetModel6Resource
        /// <summary>
        /// Gets an object representing a <see cref="SupersetModel6Resource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SupersetModel6Resource.CreateResourceIdentifier" /> to create a <see cref="SupersetModel6Resource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SupersetModel6Resource" /> object. </returns>
        public static SupersetModel6Resource GetSupersetModel6Resource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SupersetModel6Resource.ValidateResourceId(id);
                return new SupersetModel6Resource(client, id);
            }
            );
        }
        #endregion

        #region SupersetModel7Resource
        /// <summary>
        /// Gets an object representing a <see cref="SupersetModel7Resource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SupersetModel7Resource.CreateResourceIdentifier" /> to create a <see cref="SupersetModel7Resource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SupersetModel7Resource" /> object. </returns>
        public static SupersetModel7Resource GetSupersetModel7Resource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SupersetModel7Resource.ValidateResourceId(id);
                return new SupersetModel7Resource(client, id);
            }
            );
        }
        #endregion
    }
}