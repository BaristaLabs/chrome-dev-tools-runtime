namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Describes a supported image decoding profile with its associated minimum and
    /// maximum resolutions and subsampling.
    /// </summary>
    public sealed class ImageDecodeAcceleratorCapability
    {
        /// <summary>
        /// Image coded, e.g. Jpeg.
        ///</summary>
        [JsonProperty("imageType")]
        public ImageType ImageType
        {
            get;
            set;
        }
        /// <summary>
        /// Maximum supported dimensions of the image in pixels.
        ///</summary>
        [JsonProperty("maxDimensions")]
        public Size MaxDimensions
        {
            get;
            set;
        }
        /// <summary>
        /// Minimum supported dimensions of the image in pixels.
        ///</summary>
        [JsonProperty("minDimensions")]
        public Size MinDimensions
        {
            get;
            set;
        }
        /// <summary>
        /// Optional array of supported subsampling formats, e.g. 4:2:0, if known.
        ///</summary>
        [JsonProperty("subsamplings")]
        public SubsamplingFormat[] Subsamplings
        {
            get;
            set;
        }
    }
}