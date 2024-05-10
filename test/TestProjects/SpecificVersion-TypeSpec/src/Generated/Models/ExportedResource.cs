// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace TypeSpec.Versioning.Specific.Models
{
    /// <summary> The ExportedResource. </summary>
    public partial class ExportedResource
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExportedResource"/>. </summary>
        /// <param name="id"></param>
        /// <param name="resourceUri"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="resourceUri"/> is null. </exception>
        internal ExportedResource(string id, string resourceUri)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            Id = id;
            ResourceUri = resourceUri;
        }

        /// <summary> Initializes a new instance of <see cref="ExportedResource"/>. </summary>
        /// <param name="id"></param>
        /// <param name="resourceUri"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportedResource(string id, string resourceUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ResourceUri = resourceUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExportedResource"/> for deserialization. </summary>
        internal ExportedResource()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the resource uri. </summary>
        public string ResourceUri { get; }
    }
}