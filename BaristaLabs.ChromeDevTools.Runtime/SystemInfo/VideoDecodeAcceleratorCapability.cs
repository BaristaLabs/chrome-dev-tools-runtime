namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Describes a supported video decoding profile with its associated minimum and
    /// maximum resolutions.
    /// </summary>
    public sealed class VideoDecodeAcceleratorCapability
    {
        /// <summary>
        /// Video codec profile that is supported, e.g. VP9 Profile 2.
        ///</summary>
        [JsonProperty("profile")]
        public string Profile
        {
            get;
            set;
        }
        /// <summary>
        /// Maximum video dimensions in pixels supported for this |profile|.
        ///</summary>
        [JsonProperty("maxResolution")]
        public Size MaxResolution
        {
            get;
            set;
        }
        /// <summary>
        /// Minimum video dimensions in pixels supported for this |profile|.
        ///</summary>
        [JsonProperty("minResolution")]
        public Size MinResolution
        {
            get;
            set;
        }
    }
}