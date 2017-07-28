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
        /// Response stataus text.
        ///</summary>
        [JsonProperty("response")]
        public string Response
        {
            get;
            set;
        }
    }
}