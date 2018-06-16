namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// DomContentEventFired
    /// </summary>
    public sealed class DomContentEventFiredEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    }
}