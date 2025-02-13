// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Package input path specified with a resource id. </summary>
    public partial class PackageInputPathId : PackageInputPathBase
    {
        /// <summary> Initializes a new instance of PackageInputPathId. </summary>
        public PackageInputPathId()
        {
            InputPathType = InputPathType.PathId;
        }

        /// <summary> Initializes a new instance of PackageInputPathId. </summary>
        /// <param name="inputPathType"> [Required] Input path type for package inputs. </param>
        /// <param name="resourceId"> Input resource id. </param>
        internal PackageInputPathId(InputPathType inputPathType, ResourceIdentifier resourceId) : base(inputPathType)
        {
            ResourceId = resourceId;
            InputPathType = inputPathType;
        }

        /// <summary> Input resource id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
