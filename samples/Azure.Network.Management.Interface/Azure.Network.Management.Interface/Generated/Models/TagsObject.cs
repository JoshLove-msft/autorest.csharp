// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Tags object for patch operations. </summary>
    public partial class TagsObject
    {
        /// <summary> Initializes a new instance of TagsObject. </summary>
        public TagsObject()
        {
        }

        /// <summary> Initializes a new instance of TagsObject. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal TagsObject(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}