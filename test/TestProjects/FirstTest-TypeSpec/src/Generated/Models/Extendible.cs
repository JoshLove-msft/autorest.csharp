// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace FirstTestTypeSpec.Models
{
    /// <summary> FHIR extendible element. </summary>
    public partial class Extendible
    {
        /// <summary> Initializes a new instance of <see cref="Extendible"/>. </summary>
        public Extendible()
        {
            Extension = new ChangeTrackingList<ThereLevelExtension>();
        }

        /// <summary> Initializes a new instance of <see cref="Extendible"/>. </summary>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        internal Extendible(IList<ThereLevelExtension> extension)
        {
            Extension = extension;
        }

        /// <summary> Additional Content defined by implementations. </summary>
        public IList<ThereLevelExtension> Extension { get; }
    }
}