namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Describes a supported video encoding profile with its associated maximum
    /// resolution and maximum framerate.
    /// </summary>
    public sealed class VideoEncodeAcceleratorCapability
    {
        /// <summary>
        /// Video codec profile that is supported, e.g H264 Main.
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
        /// Maximum encoding framerate in frames per second supported for this
        /// |profile|, as fraction's numerator and denominator, e.g. 24/1 fps,
        /// 24000/1001 fps, etc.
        ///</summary>
        [JsonProperty("maxFramerateNumerator")]
        public long MaxFramerateNumerator
        {
            get;
            set;
        }
        /// <summary>
        /// maxFramerateDenominator
        ///</summary>
        [JsonProperty("maxFramerateDenominator")]
        public long MaxFramerateDenominator
        {
            get;
            set;
        }
    }
}