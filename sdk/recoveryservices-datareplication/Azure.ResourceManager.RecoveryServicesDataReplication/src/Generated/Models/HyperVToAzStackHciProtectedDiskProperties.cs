// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> HyperVToAzStackHCI protected disk properties. </summary>
    public partial class HyperVToAzStackHciProtectedDiskProperties
    {
        /// <summary> Initializes a new instance of HyperVToAzStackHciProtectedDiskProperties. </summary>
        internal HyperVToAzStackHciProtectedDiskProperties()
        {
        }

        /// <summary> Initializes a new instance of HyperVToAzStackHciProtectedDiskProperties. </summary>
        /// <param name="storageContainerId"> Gets or sets the ARM Id of the storage container. </param>
        /// <param name="storageContainerLocalPath"> Gets or sets the local path of the storage container. </param>
        /// <param name="sourceDiskId"> Gets or sets the source disk Id. </param>
        /// <param name="sourceDiskName"> Gets or sets the source disk Name. </param>
        /// <param name="seedDiskName"> Gets or sets the seed disk name. </param>
        /// <param name="testMigrateDiskName"> Gets or sets the test failover clone disk. </param>
        /// <param name="migrateDiskName"> Gets or sets the failover clone disk. </param>
        /// <param name="isOSDisk"> Gets or sets a value indicating whether the disk is the OS disk. </param>
        /// <param name="capacityInBytes"> Gets or sets the disk capacity in bytes. </param>
        /// <param name="isDynamic">
        /// Gets or sets a value indicating whether dynamic sizing is enabled on the virtual hard
        /// disk.
        /// </param>
        /// <param name="diskType"> Gets or sets the disk type. </param>
        internal HyperVToAzStackHciProtectedDiskProperties(ResourceIdentifier storageContainerId, string storageContainerLocalPath, string sourceDiskId, string sourceDiskName, string seedDiskName, string testMigrateDiskName, string migrateDiskName, bool? isOSDisk, long? capacityInBytes, bool? isDynamic, string diskType)
        {
            StorageContainerId = storageContainerId;
            StorageContainerLocalPath = storageContainerLocalPath;
            SourceDiskId = sourceDiskId;
            SourceDiskName = sourceDiskName;
            SeedDiskName = seedDiskName;
            TestMigrateDiskName = testMigrateDiskName;
            MigrateDiskName = migrateDiskName;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            IsDynamic = isDynamic;
            DiskType = diskType;
        }

        /// <summary> Gets or sets the ARM Id of the storage container. </summary>
        public ResourceIdentifier StorageContainerId { get; }
        /// <summary> Gets or sets the local path of the storage container. </summary>
        public string StorageContainerLocalPath { get; }
        /// <summary> Gets or sets the source disk Id. </summary>
        public string SourceDiskId { get; }
        /// <summary> Gets or sets the source disk Name. </summary>
        public string SourceDiskName { get; }
        /// <summary> Gets or sets the seed disk name. </summary>
        public string SeedDiskName { get; }
        /// <summary> Gets or sets the test failover clone disk. </summary>
        public string TestMigrateDiskName { get; }
        /// <summary> Gets or sets the failover clone disk. </summary>
        public string MigrateDiskName { get; }
        /// <summary> Gets or sets a value indicating whether the disk is the OS disk. </summary>
        public bool? IsOSDisk { get; }
        /// <summary> Gets or sets the disk capacity in bytes. </summary>
        public long? CapacityInBytes { get; }
        /// <summary>
        /// Gets or sets a value indicating whether dynamic sizing is enabled on the virtual hard
        /// disk.
        /// </summary>
        public bool? IsDynamic { get; }
        /// <summary> Gets or sets the disk type. </summary>
        public string DiskType { get; }
    }
}
