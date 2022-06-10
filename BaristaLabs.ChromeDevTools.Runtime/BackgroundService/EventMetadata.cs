namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// A key-value pair for additional event information to pass along.
    /// </summary>
    public sealed class EventMetadata
    {
        /// <summary>
        /// key
        ///</summary>
        [JsonProperty("key")]
        public string Key
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