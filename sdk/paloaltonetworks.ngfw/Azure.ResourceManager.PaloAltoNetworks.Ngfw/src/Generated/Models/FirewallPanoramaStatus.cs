// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Panorama connectivity information. </summary>
    public partial class FirewallPanoramaStatus
    {
        /// <summary> Initializes a new instance of FirewallPanoramaStatus. </summary>
        internal FirewallPanoramaStatus()
        {
        }

        /// <summary> Initializes a new instance of FirewallPanoramaStatus. </summary>
        /// <param name="panoramaServerStatus"> Primary Panorama connection status. </param>
        /// <param name="panoramaServer2Status"> Secondary Panorama connection status. </param>
        internal FirewallPanoramaStatus(FirewallPanoramaServerStatus? panoramaServerStatus, FirewallPanoramaServerStatus? panoramaServer2Status)
        {
            PanoramaServerStatus = panoramaServerStatus;
            PanoramaServer2Status = panoramaServer2Status;
        }

        /// <summary> Primary Panorama connection status. </summary>
        public FirewallPanoramaServerStatus? PanoramaServerStatus { get; }
        /// <summary> Secondary Panorama connection status. </summary>
        public FirewallPanoramaServerStatus? PanoramaServer2Status { get; }
    }
}
