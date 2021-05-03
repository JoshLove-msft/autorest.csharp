// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace TenantOnly
{
    /// <summary> A class representing the Agreement data model. </summary>
    public partial class AgreementData : Resource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of AgreementData. </summary>
        internal AgreementData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of AgreementData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="foo"> . </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal AgreementData(TenantResourceIdentifier id, string name, ResourceType type, string foo, string location, IReadOnlyDictionary<string, string> tags) : base(id, name, type)
        {
            Foo = foo;
            Location = location;
            Tags = tags;
        }

        public string Foo { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}