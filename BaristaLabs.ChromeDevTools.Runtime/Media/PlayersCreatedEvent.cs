namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called whenever a player is created, or when a new agent joins and receives
    /// a list of active players. If an agent is restored, it will receive the full
    /// list of player ids and all events again.
    /// </summary>
    public sealed class PlayersCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the players
        /// </summary>
        [JsonProperty("players")]
        public string[] Players
        {
            get;
            set;
        }
    }
}