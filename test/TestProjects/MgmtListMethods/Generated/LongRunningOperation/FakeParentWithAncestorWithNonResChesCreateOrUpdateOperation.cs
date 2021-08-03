// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    /// <summary> Create or update. </summary>
    public partial class FakeParentWithAncestorWithNonResChesCreateOrUpdateOperation : Operation<FakeParentWithAncestorWithNonResCh>
    {
        private readonly OperationOrResponseInternals<FakeParentWithAncestorWithNonResCh> _operation;

        /// <summary> Initializes a new instance of FakeParentWithAncestorWithNonResChesCreateOrUpdateOperation for mocking. </summary>
        protected FakeParentWithAncestorWithNonResChesCreateOrUpdateOperation()
        {
        }

        internal FakeParentWithAncestorWithNonResChesCreateOrUpdateOperation(ResourceOperations operationsBase, Response<FakeParentWithAncestorWithNonResChData> response)
        {
            _operation = new OperationOrResponseInternals<FakeParentWithAncestorWithNonResCh>(Response.FromValue(new FakeParentWithAncestorWithNonResCh(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override FakeParentWithAncestorWithNonResCh Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FakeParentWithAncestorWithNonResCh>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FakeParentWithAncestorWithNonResCh>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
