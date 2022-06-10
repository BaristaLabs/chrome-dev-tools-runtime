namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// This can be called multiple times, and can be used to set / override /
    /// remove player properties. A null propValue indicates removal.
    /// </summary>
    public sealed class PlayerPropertiesChangedEvent : IEvent
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
        /// Gets or sets the properties
        /// </summary>
        [JsonProperty("properties")]
        public PlayerProperty[] Properties
        {
            get;
            set;
        }
    }
}