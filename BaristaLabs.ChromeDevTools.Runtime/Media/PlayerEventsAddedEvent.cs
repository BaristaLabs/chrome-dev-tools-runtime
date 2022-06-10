namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Send events as a list, allowing them to be batched on the browser for less
    /// congestion. If batched, events must ALWAYS be in chronological order.
    /// </summary>
    public sealed class PlayerEventsAddedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the playerId
        /// </summary>
        [JsonProperty("playerId")]
        public string PlayerId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the events
        /// </summary>
        [JsonProperty("events")]
        public PlayerEvent[] Events
        {
            get;
            set;
        }
    }
}