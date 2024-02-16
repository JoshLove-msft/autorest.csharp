// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    /// <summary>
    /// A class representing the DedicatedHostGroup data model.
    /// Specifies information about the dedicated host group that the dedicated hosts should be assigned to. &lt;br&gt;&lt;br&gt; Currently, a dedicated host can only be added to a dedicated host group at creation time. An existing dedicated host cannot be added to another dedicated host group.
    /// Serialized Name: DedicatedHostGroup
    /// </summary>
    public partial class DedicatedHostGroupData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DedicatedHostGroupData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
            HostUris = new ChangeTrackingList<Uri>();
            Hosts = new ChangeTrackingList<Resources.Models.SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones">
        /// Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone.
        /// Serialized Name: DedicatedHostGroup.zones
        /// </param>
        /// <param name="hostUris">
        /// Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone.
        /// Serialized Name: DedicatedHostGroup.hostUris
        /// </param>
        /// <param name="tenantId">
        /// The tenant id of the dedicated host.
        /// Serialized Name: DedicatedHostGroup.tenantId
        /// </param>
        /// <param name="platformFaultDomainCount">
        /// Number of fault domains that the host group can span.
        /// Serialized Name: DedicatedHostGroup.properties.platformFaultDomainCount
        /// </param>
        /// <param name="hosts">
        /// A list of references to all dedicated hosts in the dedicated host group.
        /// Serialized Name: DedicatedHostGroup.properties.hosts
        /// </param>
        /// <param name="instanceView">
        /// The dedicated host group instance view, which has the list of instance view of the dedicated hosts under the dedicated host group.
        /// Serialized Name: DedicatedHostGroup.properties.instanceView
        /// </param>
        /// <param name="supportAutomaticPlacement">
        /// Specifies whether virtual machines or virtual machine scale sets can be placed automatically on the dedicated host group. Automatic placement means resources are allocated on dedicated hosts, that are chosen by Azure, under the dedicated host group. The value is defaulted to 'true' when not provided. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.
        /// Serialized Name: DedicatedHostGroup.properties.supportAutomaticPlacement
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedHostGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, IList<Uri> hostUris, Guid? tenantId, int? platformFaultDomainCount, IReadOnlyList<Resources.Models.SubResource> hosts, DedicatedHostGroupInstanceView instanceView, bool? supportAutomaticPlacement, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Zones = zones;
            HostUris = hostUris;
            TenantId = tenantId;
            PlatformFaultDomainCount = platformFaultDomainCount;
            Hosts = hosts;
            InstanceView = instanceView;
            SupportAutomaticPlacement = supportAutomaticPlacement;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupData"/> for deserialization. </summary>
        internal DedicatedHostGroupData()
        {
        }

        /// <summary>
        /// Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone.
        /// Serialized Name: DedicatedHostGroup.zones
        /// </summary>
        [WirePath("zones")]
        public IList<string> Zones { get; }
        /// <summary>
        /// Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone.
        /// Serialized Name: DedicatedHostGroup.hostUris
        /// </summary>
        [WirePath("hostUris")]
        public IList<Uri> HostUris { get; }
        /// <summary>
        /// The tenant id of the dedicated host.
        /// Serialized Name: DedicatedHostGroup.tenantId
        /// </summary>
        [WirePath("tenantId")]
        public Guid? TenantId { get; }
        /// <summary>
        /// Number of fault domains that the host group can span.
        /// Serialized Name: DedicatedHostGroup.properties.platformFaultDomainCount
        /// </summary>
        [WirePath("properties.platformFaultDomainCount")]
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary>
        /// A list of references to all dedicated hosts in the dedicated host group.
        /// Serialized Name: DedicatedHostGroup.properties.hosts
        /// </summary>
        [WirePath("properties.hosts")]
        public IReadOnlyList<Resources.Models.SubResource> Hosts { get; }
        /// <summary>
        /// The dedicated host group instance view, which has the list of instance view of the dedicated hosts under the dedicated host group.
        /// Serialized Name: DedicatedHostGroup.properties.instanceView
        /// </summary>
        internal DedicatedHostGroupInstanceView InstanceView { get; }
        /// <summary>
        /// List of instance view of the dedicated hosts under the dedicated host group.
        /// Serialized Name: DedicatedHostGroupInstanceView.hosts
        /// </summary>
        [WirePath("properties.instanceView.hosts")]
        public IReadOnlyList<DedicatedHostInstanceViewWithName> InstanceViewHosts
        {
            get => InstanceView?.Hosts;
        }

        /// <summary>
        /// Specifies whether virtual machines or virtual machine scale sets can be placed automatically on the dedicated host group. Automatic placement means resources are allocated on dedicated hosts, that are chosen by Azure, under the dedicated host group. The value is defaulted to 'true' when not provided. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.
        /// Serialized Name: DedicatedHostGroup.properties.supportAutomaticPlacement
        /// </summary>
        [WirePath("properties.supportAutomaticPlacement")]
        public bool? SupportAutomaticPlacement { get; set; }
    }
}
