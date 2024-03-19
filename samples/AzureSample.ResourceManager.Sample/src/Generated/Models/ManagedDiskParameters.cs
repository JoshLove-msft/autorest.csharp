// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// The parameters of a managed disk.
    /// Serialized Name: ManagedDiskParameters
    /// </summary>
    public partial class ManagedDiskParameters : SubResource
    {
        /// <summary> Initializes a new instance of <see cref="ManagedDiskParameters"/>. </summary>
        public ManagedDiskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedDiskParameters"/>. </summary>
        /// <param name="id">
        /// Resource Id
        /// Serialized Name: SubResource.id
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="storageAccountType">
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// Serialized Name: ManagedDiskParameters.storageAccountType
        /// </param>
        /// <param name="diskEncryptionSet">
        /// Specifies the customer managed disk encryption set resource id for the managed disk.
        /// Serialized Name: ManagedDiskParameters.diskEncryptionSet
        /// </param>
        internal ManagedDiskParameters(string id, IDictionary<string, BinaryData> serializedAdditionalRawData, StorageAccountType? storageAccountType, WritableSubResource diskEncryptionSet) : base(id, serializedAdditionalRawData)
        {
            StorageAccountType = storageAccountType;
            DiskEncryptionSet = diskEncryptionSet;
        }

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// Serialized Name: ManagedDiskParameters.storageAccountType
        /// </summary>
        [WirePath("storageAccountType")]
        public StorageAccountType? StorageAccountType { get; set; }
        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed disk.
        /// Serialized Name: ManagedDiskParameters.diskEncryptionSet
        /// </summary>
        internal WritableSubResource DiskEncryptionSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("diskEncryptionSet.id")]
        public ResourceIdentifier DiskEncryptionSetId
        {
            get => DiskEncryptionSet is null ? default : DiskEncryptionSet.Id;
            set
            {
                if (DiskEncryptionSet is null)
                    DiskEncryptionSet = new WritableSubResource();
                DiskEncryptionSet.Id = value;
            }
        }
    }
}