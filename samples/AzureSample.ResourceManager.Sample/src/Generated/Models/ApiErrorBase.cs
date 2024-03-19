// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Api error base.
    /// Serialized Name: ApiErrorBase
    /// </summary>
    public partial class ApiErrorBase
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

        /// <summary> Initializes a new instance of <see cref="ApiErrorBase"/>. </summary>
        internal ApiErrorBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiErrorBase"/>. </summary>
        /// <param name="code">
        /// The error code.
        /// Serialized Name: ApiErrorBase.code
        /// </param>
        /// <param name="target">
        /// The target of the particular error.
        /// Serialized Name: ApiErrorBase.target
        /// </param>
        /// <param name="message">
        /// The error message.
        /// Serialized Name: ApiErrorBase.message
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiErrorBase(string code, string target, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Target = target;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The error code.
        /// Serialized Name: ApiErrorBase.code
        /// </summary>
        [WirePath("code")]
        public string Code { get; }
        /// <summary>
        /// The target of the particular error.
        /// Serialized Name: ApiErrorBase.target
        /// </summary>
        [WirePath("target")]
        public string Target { get; }
        /// <summary>
        /// The error message.
        /// Serialized Name: ApiErrorBase.message
        /// </summary>
        [WirePath("message")]
        public string Message { get; }
    }
}