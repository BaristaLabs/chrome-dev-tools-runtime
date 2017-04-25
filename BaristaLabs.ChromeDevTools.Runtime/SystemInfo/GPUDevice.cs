namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Describes a single graphics processor (GPU).
    /// </summary>
    public sealed class GPUDevice
    {
        /// <summary>
        /// PCI ID of the GPU vendor, if available; 0 otherwise.
        ///</summary>
        [JsonProperty("vendorId")]
        public double VendorId
        {
            get;
            set;
        }
        /// <summary>
        /// PCI ID of the GPU device, if available; 0 otherwise.
        ///</summary>
        [JsonProperty("deviceId")]
        public double DeviceId
        {
            get;
            set;
        }
        /// <summary>
        /// String description of the GPU vendor, if the PCI ID is not available.
        ///</summary>
        [JsonProperty("vendorString")]
        public string VendorString
        {
            get;
            set;
        }
        /// <summary>
        /// String description of the GPU device, if the PCI ID is not available.
        ///</summary>
        [JsonProperty("deviceString")]
        public string DeviceString
        {
            get;
            set;
        }
    }
}