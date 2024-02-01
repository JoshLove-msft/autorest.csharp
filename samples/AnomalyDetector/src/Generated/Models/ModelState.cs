// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> Model status. </summary>
    public partial class ModelState
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

        /// <summary> Initializes a new instance of <see cref="ModelState"/>. </summary>
        public ModelState()
        {
            EpochIds = new ChangeTrackingList<int>();
            TrainLosses = new ChangeTrackingList<float>();
            ValidationLosses = new ChangeTrackingList<float>();
            LatenciesInSeconds = new ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of <see cref="ModelState"/>. </summary>
        /// <param name="epochIds">
        /// This indicates the number of passes of the entire training dataset the
        /// algorithm has completed.
        /// </param>
        /// <param name="trainLosses">
        /// List of metrics used to assess how the model fits the training data for each
        /// epoch.
        /// </param>
        /// <param name="validationLosses">
        /// List of metrics used to assess how the model fits the validation set for each
        /// epoch.
        /// </param>
        /// <param name="latenciesInSeconds"> Latency for each epoch. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelState(IList<int> epochIds, IList<float> trainLosses, IList<float> validationLosses, IList<float> latenciesInSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EpochIds = epochIds;
            TrainLosses = trainLosses;
            ValidationLosses = validationLosses;
            LatenciesInSeconds = latenciesInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// This indicates the number of passes of the entire training dataset the
        /// algorithm has completed.
        /// </summary>
        public IList<int> EpochIds { get; }
        /// <summary>
        /// List of metrics used to assess how the model fits the training data for each
        /// epoch.
        /// </summary>
        public IList<float> TrainLosses { get; }
        /// <summary>
        /// List of metrics used to assess how the model fits the validation set for each
        /// epoch.
        /// </summary>
        public IList<float> ValidationLosses { get; }
        /// <summary> Latency for each epoch. </summary>
        public IList<float> LatenciesInSeconds { get; }
    }
}
