// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes scaling information of a sku.
    /// Serialized Name: VirtualMachineScaleSetSkuCapacity
    /// </summary>
    public partial class VirtualMachineScaleSetSkuCapacity
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetSkuCapacity"/>. </summary>
        internal VirtualMachineScaleSetSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetSkuCapacity"/>. </summary>
        /// <param name="minimum">
        /// The minimum capacity.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.minimum
        /// </param>
        /// <param name="maximum">
        /// The maximum capacity that can be set.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.maximum
        /// </param>
        /// <param name="defaultCapacity">
        /// The default capacity.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.defaultCapacity
        /// </param>
        /// <param name="scaleType">
        /// The scale type applicable to the sku.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.scaleType
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetSkuCapacity(long? minimum, long? maximum, long? defaultCapacity, VirtualMachineScaleSetSkuScaleType? scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            DefaultCapacity = defaultCapacity;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The minimum capacity.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.minimum
        /// </summary>
        [WirePath("minimum")]
        public long? Minimum { get; }
        /// <summary>
        /// The maximum capacity that can be set.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.maximum
        /// </summary>
        [WirePath("maximum")]
        public long? Maximum { get; }
        /// <summary>
        /// The default capacity.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.defaultCapacity
        /// </summary>
        [WirePath("defaultCapacity")]
        public long? DefaultCapacity { get; }
        /// <summary>
        /// The scale type applicable to the sku.
        /// Serialized Name: VirtualMachineScaleSetSkuCapacity.scaleType
        /// </summary>
        [WirePath("scaleType")]
        public VirtualMachineScaleSetSkuScaleType? ScaleType { get; }
    }
}
