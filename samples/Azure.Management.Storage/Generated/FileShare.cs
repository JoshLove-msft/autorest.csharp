// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a FileShare along with the instance operations that can be performed on it. </summary>
    public class FileShare : FileShareOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "FileShare"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal FileShare(ResourceOperationsBase options, FileShareData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the FileShareData. </summary>
        public FileShareData Data { get; private set; }

        /// <inheritdoc />
        protected override FileShare GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<FileShare> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}