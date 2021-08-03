// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtListMethods
{
    /// <summary> A Class representing a SubParentWithNonResCh along with the instance operations that can be performed on it. </summary>
    public class SubParentWithNonResCh : SubParentWithNonResChOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "SubParentWithNonResCh"/> class for mocking. </summary>
        protected SubParentWithNonResCh() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubParentWithNonResCh"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SubParentWithNonResCh(ResourceOperations options, SubParentWithNonResChData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SubParentWithNonResChData. </summary>
        public virtual SubParentWithNonResChData Data { get; private set; }
    }
}
