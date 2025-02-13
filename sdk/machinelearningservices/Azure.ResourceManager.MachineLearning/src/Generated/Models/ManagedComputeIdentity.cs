// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Managed compute identity definition. </summary>
    public partial class ManagedComputeIdentity : MonitorComputeIdentityBase
    {
        /// <summary> Initializes a new instance of ManagedComputeIdentity. </summary>
        public ManagedComputeIdentity()
        {
            ComputeIdentityType = MonitorComputeIdentityType.ManagedIdentity;
        }

        /// <summary> Initializes a new instance of ManagedComputeIdentity. </summary>
        /// <param name="computeIdentityType"> [Required] Monitor compute identity type enum. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        internal ManagedComputeIdentity(MonitorComputeIdentityType computeIdentityType, ManagedServiceIdentity identity) : base(computeIdentityType)
        {
            Identity = identity;
            ComputeIdentityType = computeIdentityType;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
