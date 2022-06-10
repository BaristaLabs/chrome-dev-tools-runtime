namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using Newtonsoft.Json;

    /// <summary>
    /// TimelineEvent
    /// </summary>
    public sealed class TimelineEvent
    {
        /// <summary>
        /// Identifies the frame that this event is related to. Empty for non-frame targets.
        ///</summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// The event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
        /// This determines which of the optional "details" fiedls is present.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// Name may be empty depending on the type.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Time in seconds since Epoch, monotonically increasing within document lifetime.
        ///</summary>
        [JsonProperty("time")]
        public double Time
        {
            get;
            set;
        }
        /// <summary>
        /// Event duration, if applicable.
        ///</summary>
        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Duration
        {
            get;
            set;
        }
        /// <summary>
        /// lcpDetails
        ///</summary>
        [JsonProperty("lcpDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LargestContentfulPaint LcpDetails
        {
            get;
            set;
        }
        /// <summary>
        /// layoutShiftDetails
        ///</summary>
        [JsonProperty("layoutShiftDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LayoutShift LayoutShiftDetails
        {
            get;
            set;
        }
    }
}