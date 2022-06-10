namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using Newtonsoft.Json;

    /// <summary>
    /// LayoutShiftAttribution
    /// </summary>
    public sealed class LayoutShiftAttribution
    {
        /// <summary>
        /// previousRect
        ///</summary>
        [JsonProperty("previousRect")]
        public DOM.Rect PreviousRect
        {
            get;
            set;
        }
        /// <summary>
        /// currentRect
        ///</summary>
        [JsonProperty("currentRect")]
        public DOM.Rect CurrentRect
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