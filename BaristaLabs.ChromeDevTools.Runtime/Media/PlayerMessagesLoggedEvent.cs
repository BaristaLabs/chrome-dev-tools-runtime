namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Send a list of any messages that need to be delivered.
    /// </summary>
    public sealed class PlayerMessagesLoggedEvent : IEvent
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
        /// Gets or sets the messages
        /// </summary>
        [JsonProperty("messages")]
        public PlayerMessage[] Messages
        {
            get;
            set;
        }
    }
}