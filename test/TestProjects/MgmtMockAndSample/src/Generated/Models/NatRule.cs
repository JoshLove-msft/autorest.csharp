// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using MgmtMockAndSample;

namespace MgmtMockAndSample.Models
{
    /// <summary> Rule of type nat. </summary>
    public partial class NatRule : FirewallPolicyRule
    {
        /// <summary> Initializes a new instance of <see cref="NatRule"/>. </summary>
        public NatRule()
        {
            IpProtocols = new ChangeTrackingList<FirewallPolicyRuleNetworkProtocol>();
            SourceAddresses = new ChangeTrackingList<string>();
            DestinationAddresses = new ChangeTrackingList<string>();
            DestinationPorts = new ChangeTrackingList<string>();
            SourceIpGroups = new ChangeTrackingList<string>();
            RuleType = FirewallPolicyRuleType.NatRule;
        }

        /// <summary> Initializes a new instance of <see cref="NatRule"/>. </summary>
        /// <param name="name"> Name of the rule. </param>
        /// <param name="description"> Description of the rule. </param>
        /// <param name="ruleType"> Rule Type. </param>
        /// <param name="ipProtocols"> Array of FirewallPolicyRuleNetworkProtocols. </param>
        /// <param name="sourceAddresses"> List of source IP addresses for this rule. </param>
        /// <param name="destinationAddresses"> List of destination IP addresses or Service Tags. </param>
        /// <param name="destinationPorts"> List of destination ports. </param>
        /// <param name="translatedAddress"> The translated address for this NAT rule. </param>
        /// <param name="translatedPort"> The translated port for this NAT rule. </param>
        /// <param name="sourceIpGroups"> List of source IpGroups for this rule. </param>
        /// <param name="translatedFqdn"> The translated FQDN for this NAT rule. </param>
        internal NatRule(string name, string description, FirewallPolicyRuleType ruleType, IList<FirewallPolicyRuleNetworkProtocol> ipProtocols, IList<string> sourceAddresses, IList<string> destinationAddresses, IList<string> destinationPorts, string translatedAddress, string translatedPort, IList<string> sourceIpGroups, string translatedFqdn) : base(name, description, ruleType)
        {
            IpProtocols = ipProtocols;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            TranslatedAddress = translatedAddress;
            TranslatedPort = translatedPort;
            SourceIpGroups = sourceIpGroups;
            TranslatedFqdn = translatedFqdn;
            RuleType = ruleType;
        }

        /// <summary> Array of FirewallPolicyRuleNetworkProtocols. </summary>
        public IList<FirewallPolicyRuleNetworkProtocol> IpProtocols { get; }
        /// <summary> List of source IP addresses for this rule. </summary>
        public IList<string> SourceAddresses { get; }
        /// <summary> List of destination IP addresses or Service Tags. </summary>
        public IList<string> DestinationAddresses { get; }
        /// <summary> List of destination ports. </summary>
        public IList<string> DestinationPorts { get; }
        /// <summary> The translated address for this NAT rule. </summary>
        public string TranslatedAddress { get; set; }
        /// <summary> The translated port for this NAT rule. </summary>
        public string TranslatedPort { get; set; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIpGroups { get; }
        /// <summary> The translated FQDN for this NAT rule. </summary>
        public string TranslatedFqdn { get; set; }
    }
}
