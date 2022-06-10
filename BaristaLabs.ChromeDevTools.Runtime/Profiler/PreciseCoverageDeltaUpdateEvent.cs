namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Reports coverage delta since the last poll (either from an event like this, or from
    /// `takePreciseCoverage` for the current isolate. May only be sent if precise code
    /// coverage has been started. This event can be trigged by the embedder to, for example,
    /// trigger collection of coverage data immediately at a certain point in time.
    /// </summary>
    public sealed class PreciseCoverageDeltaUpdateEvent : IEvent
    {
        /// <summary>
        /// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier for distinguishing coverage events.
        /// </summary>
        [JsonProperty("occasion")]
        public string Occasion
        {
            get;
            set;
        }
        /// <summary>
        /// Coverage data for the current isolate.
        /// </summary>
        [JsonProperty("result")]
        public ScriptCoverage[] Result
        {
            get;
            set;
        }
    }
}