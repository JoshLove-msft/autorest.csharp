// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtSupersetInheritance;

namespace MgmtSupersetInheritance.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtSupersetInheritanceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="MgmtSupersetInheritance.SupersetModel1Data"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        /// <returns> A new <see cref="MgmtSupersetInheritance.SupersetModel1Data"/> instance for mocking. </returns>
        public static SupersetModel1Data SupersetModel1Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string @new = null)
        {
            return new SupersetModel1Data(id, name, resourceType, systemData, @new);
        }

        /// <summary> Initializes a new instance of <see cref="MgmtSupersetInheritance.SupersetModel4Data"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="new"></param>
        /// <returns> A new <see cref="MgmtSupersetInheritance.SupersetModel4Data"/> instance for mocking. </returns>
        public static SupersetModel4Data SupersetModel4Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string @new = null)
        {
            tags ??= new Dictionary<string, string>();

            return new SupersetModel4Data(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                @new);
        }

        /// <summary> Initializes a new instance of <see cref="MgmtSupersetInheritance.SupersetModel6Data"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        /// <returns> A new <see cref="MgmtSupersetInheritance.SupersetModel6Data"/> instance for mocking. </returns>
        public static SupersetModel6Data SupersetModel6Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string @new = null)
        {
            return new SupersetModel6Data(id, name, resourceType, systemData, @new);
        }

        /// <summary> Initializes a new instance of <see cref="MgmtSupersetInheritance.SupersetModel7Data"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="resourceType"></param>
        /// <param name="new"></param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <returns> A new <see cref="MgmtSupersetInheritance.SupersetModel7Data"/> instance for mocking. </returns>
        public static SupersetModel7Data SupersetModel7Data(string id = null, string name = null, string resourceType = null, string @new = null, SupersetModel7SystemData systemData = null)
        {
            return new SupersetModel7Data(id, name, resourceType, @new, systemData);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SupersetModel7SystemData"/>. </summary>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdOn"> The timestamp of resource creation (UTC). </param>
        /// <param name="lastModifiedBy"> The identity that last modified the resource. </param>
        /// <returns> A new <see cref="Models.SupersetModel7SystemData"/> instance for mocking. </returns>
        public static SupersetModel7SystemData SupersetModel7SystemData(string createdBy = null, DateTimeOffset? createdOn = null, string lastModifiedBy = null)
        {
            return new SupersetModel7SystemData(createdBy, createdOn, lastModifiedBy);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SupersetModel5"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"></param>
        /// <param name="new"></param>
        /// <returns> A new <see cref="Models.SupersetModel5"/> instance for mocking. </returns>
        public static SupersetModel5 SupersetModel5(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string foo = null, string @new = null)
        {
            tags ??= new Dictionary<string, string>();

            return new SupersetModel5(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                foo,
                @new);
        }
    }
}