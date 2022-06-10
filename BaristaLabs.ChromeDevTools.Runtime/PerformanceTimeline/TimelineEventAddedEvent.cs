namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
    /// </summary>
    public sealed class TimelineEventAddedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the event
        /// </summary>
        [JsonProperty("event")]
        public TimelineEvent Event
        {
            get;
            set;
        }
    }
}