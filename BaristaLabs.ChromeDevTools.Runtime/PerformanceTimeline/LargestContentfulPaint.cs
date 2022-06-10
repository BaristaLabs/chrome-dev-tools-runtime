namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using Newtonsoft.Json;

    /// <summary>
    /// See https://github.com/WICG/LargestContentfulPaint and largest_contentful_paint.idl
    /// </summary>
    public sealed class LargestContentfulPaint
    {
        /// <summary>
        /// renderTime
        ///</summary>
        [JsonProperty("renderTime")]
        public double RenderTime
        {
            get;
            set;
        }
        /// <summary>
        /// loadTime
        ///</summary>
        [JsonProperty("loadTime")]
        public double LoadTime
        {
            get;
            set;
        }
        /// <summary>
        /// The number of pixels being painted.
        ///</summary>
        [JsonProperty("size")]
        public double Size
        {
            get;
            set;
        }
        /// <summary>
        /// The id attribute of the element, if available.
        ///</summary>
        [JsonProperty("elementId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ElementId
        {
            get;
            set;
        }
        /// <summary>
        /// The URL of the image (may be trimmed).
        ///</summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// nodeId
        ///</summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
    }
}