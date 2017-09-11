namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data entry.
    /// </summary>
    public sealed class DataEntry
    {
        /// <summary>
        /// Request url spec.
        ///</summary>
        [JsonProperty("request")]
        public string Request
        {
            get;
            set;
        }
        /// <summary>
        /// Response status text.
        ///</summary>
        [JsonProperty("response")]
        public string Response
        {
            get;
            set;
        }
        /// <summary>
        /// Number of seconds since epoch.
        ///</summary>
        [JsonProperty("responseTime")]
        public double ResponseTime
        {
            get;
            set;
        }
    }
}