namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Provides information about the GPU(s) on the system.
    /// </summary>
    public sealed class GPUInfo
    {
    
        /// <summary>
        /// The graphics devices on the system. Element 0 is the primary GPU.
        ///</summary>
        [JsonProperty("devices")]
        public GPUDevice[] Devices
        {
            get;
            set;
        }
    
        /// <summary>
        /// An optional dictionary of additional GPU related attributes.
        ///</summary>
        [JsonProperty("auxAttributes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object AuxAttributes
        {
            get;
            set;
        }
    
        /// <summary>
        /// An optional dictionary of graphics features and their status.
        ///</summary>
        [JsonProperty("featureStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object FeatureStatus
        {
            get;
            set;
        }
    
        /// <summary>
        /// An optional array of GPU driver bug workarounds.
        ///</summary>
        [JsonProperty("driverBugWorkarounds")]
        public string[] DriverBugWorkarounds
        {
            get;
            set;
        }
    
    }
}