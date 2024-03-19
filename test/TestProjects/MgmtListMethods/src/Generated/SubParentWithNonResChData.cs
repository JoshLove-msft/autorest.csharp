// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtListMethods
{
    /// <summary>
    /// A class representing the SubParentWithNonResCh data model.
    /// Specifies information.
    /// </summary>
    public partial class SubParentWithNonResChData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SubParentWithNonResChData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SubParentWithNonResChData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubParentWithNonResChData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="bar"> specifies the bar. </param>
        internal SubParentWithNonResChData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string bar) : base(id, name, resourceType, systemData, tags, location)
        {
            Bar = bar;
        }

        /// <summary> specifies the bar. </summary>
        public string Bar { get; set; }
    }
}