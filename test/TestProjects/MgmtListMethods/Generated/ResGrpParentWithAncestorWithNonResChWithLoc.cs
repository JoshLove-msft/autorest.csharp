// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtListMethods
{
    /// <summary> A Class representing a ResGrpParentWithAncestorWithNonResChWithLoc along with the instance operations that can be performed on it. </summary>
    public class ResGrpParentWithAncestorWithNonResChWithLoc : ResGrpParentWithAncestorWithNonResChWithLocOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ResGrpParentWithAncestorWithNonResChWithLoc"/> class for mocking. </summary>
        protected ResGrpParentWithAncestorWithNonResChWithLoc() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResGrpParentWithAncestorWithNonResChWithLoc"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ResGrpParentWithAncestorWithNonResChWithLoc(ResourceOperations options, ResGrpParentWithAncestorWithNonResChWithLocData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ResGrpParentWithAncestorWithNonResChWithLocData. </summary>
        public virtual ResGrpParentWithAncestorWithNonResChWithLocData Data { get; private set; }
    }
}
