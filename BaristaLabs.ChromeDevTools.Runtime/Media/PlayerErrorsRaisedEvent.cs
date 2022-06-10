namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Send a list of any errors that need to be delivered.
    /// </summary>
    public sealed class PlayerErrorsRaisedEvent : IEvent
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
        /// Gets or sets the errors
        /// </summary>
        [JsonProperty("errors")]
        public PlayerError[] Errors
        {
            get;
            set;
        }
    }
}