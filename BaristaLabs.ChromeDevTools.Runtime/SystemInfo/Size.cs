namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Describes the width and height dimensions of an entity.
    /// </summary>
    public sealed class Size
    {
        /// <summary>
        /// Width in pixels.
        ///</summary>
        [JsonProperty("width")]
        public long Width
        {
            get;
            set;
        }
        /// <summary>
        /// Height in pixels.
        ///</summary>
        [JsonProperty("height")]
        public long Height
        {
            get;
            set;
        }
    }
}