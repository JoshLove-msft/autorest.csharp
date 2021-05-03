// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A Class representing a SshPublicKey along with the instance operations that can be performed on it. </summary>
    public class SshPublicKey : SshPublicKeyOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "SshPublicKey"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SshPublicKey(ResourceOperationsBase options, SshPublicKeyData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SshPublicKeyData. </summary>
        public SshPublicKeyData Data { get; private set; }

        /// <inheritdoc />
        protected override SshPublicKey GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<SshPublicKey> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}