// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Management;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to ManagementGroup. </summary>
    public static partial class ManagementGroupExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentContainer" /> object. </returns>
        public static PolicyAssignmentContainer GetPolicyAssignmentContainer(this ManagementGroupOperations managementGroup)
        {
            return new PolicyAssignmentContainer(managementGroup);
        }
        #endregion
    }
}