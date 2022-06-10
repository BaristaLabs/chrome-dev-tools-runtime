namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Corresponds to kMediaEventTriggered
    /// </summary>
    public sealed class PlayerEvent
    {
        /// <summary>
        /// timestamp
        ///</summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }
}