// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using _Type.Property.AdditionalProperties;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The model extends from Record&lt;ModelForRecord[]&gt; type. </summary>
    public partial class ExtendsModelArrayAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="ExtendsModelArrayAdditionalProperties"/>. </summary>
        public ExtendsModelArrayAdditionalProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, IList<ModelForRecord>>();
        }

        /// <summary> Initializes a new instance of <see cref="ExtendsModelArrayAdditionalProperties"/>. </summary>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ExtendsModelArrayAdditionalProperties(IDictionary<string, IList<ModelForRecord>> additionalProperties)
        {
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Additional Properties. </summary>
        public IDictionary<string, IList<ModelForRecord>> AdditionalProperties { get; }
    }
}
