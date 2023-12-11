// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace _Type.Property.Optionality.Models
{
    /// <summary> Model with collection bytes properties. </summary>
    public partial class CollectionsByteProperty
    {
        /// <summary> Initializes a new instance of <see cref="CollectionsByteProperty"/>. </summary>
        public CollectionsByteProperty()
        {
            Property = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsByteProperty"/>. </summary>
        /// <param name="property"> Property. </param>
        internal CollectionsByteProperty(IList<BinaryData> property)
        {
            Property = property;
        }

        /// <summary>
        /// Property
        /// <para>
        /// To assign a byte[] to the element of this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IList<BinaryData> Property { get; }
    }
}
