// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// Request of the action to create a signed device capability image
    /// Serialized Name: GenerateCapabilityImageRequest
    /// </summary>
    public partial class GenerateCapabilityImageContent
    {
        /// <summary> Initializes a new instance of GenerateCapabilityImageContent. </summary>
        /// <param name="capabilities">
        /// List of capabilities to create
        /// Serialized Name: GenerateCapabilityImageRequest.capabilities
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilities"/> is null. </exception>
        public GenerateCapabilityImageContent(IEnumerable<SphereCapabilityType> capabilities)
        {
            Argument.AssertNotNull(capabilities, nameof(capabilities));

            Capabilities = capabilities.ToList();
        }

        /// <summary>
        /// List of capabilities to create
        /// Serialized Name: GenerateCapabilityImageRequest.capabilities
        /// </summary>
        public IList<SphereCapabilityType> Capabilities { get; }
    }
}
