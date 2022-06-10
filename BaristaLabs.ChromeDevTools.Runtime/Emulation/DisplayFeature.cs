namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// DisplayFeature
    /// </summary>
    public sealed class DisplayFeature
    {
        /// <summary>
        /// Orientation of a display feature in relation to screen
        ///</summary>
        [JsonProperty("orientation")]
        public string Orientation
        {
            get;
            set;
        }
        /// <summary>
        /// The offset from the screen origin in either the x (for vertical
        /// orientation) or y (for horizontal orientation) direction.
        ///</summary>
        [JsonProperty("offset")]
        public long Offset
        {
            get;
            set;
        }
        /// <summary>
        /// A display feature may mask content such that it is not physically
        /// displayed - this length along with the offset describes this area.
        /// A display feature that only splits content will have a 0 mask_length.
        ///</summary>
        [JsonProperty("maskLength")]
        public long MaskLength
        {
            get;
            set;
        }
    }
}