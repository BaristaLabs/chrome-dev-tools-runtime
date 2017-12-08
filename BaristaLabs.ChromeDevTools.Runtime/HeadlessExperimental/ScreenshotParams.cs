namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Encoding options for a screenshot.
    /// </summary>
    public sealed class ScreenshotParams
    {
        /// <summary>
        /// Image compression format (defaults to png).
        ///</summary>
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Format
        {
            get;
            set;
        }
        /// <summary>
        /// Compression quality from range [0..100] (jpeg only).
        ///</summary>
        [JsonProperty("quality", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Quality
        {
            get;
            set;
        }
    }
}