// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Input of CheckHostNameAvailability API. </summary>
    public partial class HostNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of HostNameAvailabilityContent. </summary>
        /// <param name="hostName"> The host name to validate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public HostNameAvailabilityContent(string hostName)
        {
            Argument.AssertNotNull(hostName, nameof(hostName));

            HostName = hostName;
        }

        /// <summary> The host name to validate. </summary>
        public string HostName { get; }
    }
}
