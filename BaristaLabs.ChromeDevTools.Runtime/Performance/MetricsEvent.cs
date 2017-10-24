namespace BaristaLabs.ChromeDevTools.Runtime.Performance
{
    using Newtonsoft.Json;

    /// <summary>
    /// Current values of the metrics.
    /// </summary>
    public sealed class MetricsEvent : IEvent
    {
        /// <summary>
        /// Current values of the metrics.
        /// </summary>
        [JsonProperty("metrics")]
        public Metric[] Metrics
        {
            get;
            set;
        }
        /// <summary>
        /// Timestamp title.
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }
    }
}