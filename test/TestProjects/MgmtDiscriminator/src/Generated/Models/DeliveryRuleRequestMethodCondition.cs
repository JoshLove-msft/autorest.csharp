// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using MgmtDiscriminator;

namespace MgmtDiscriminator.Models
{
    /// <summary> Defines the RequestMethod condition for the delivery rule. </summary>
    public partial class DeliveryRuleRequestMethodCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestMethodCondition"/>. </summary>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleRequestMethodCondition(RequestMethodMatchConditionParameters parameters)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            Parameters = parameters;
            Name = MatchVariable.RequestMethod;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestMethodCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="foo"> For test. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        internal DeliveryRuleRequestMethodCondition(MatchVariable name, string foo, IDictionary<string, BinaryData> serializedAdditionalRawData, RequestMethodMatchConditionParameters parameters) : base(name, foo, serializedAdditionalRawData)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestMethodCondition"/> for deserialization. </summary>
        internal DeliveryRuleRequestMethodCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        [WirePath("parameters")]
        public RequestMethodMatchConditionParameters Parameters { get; set; }
    }
}