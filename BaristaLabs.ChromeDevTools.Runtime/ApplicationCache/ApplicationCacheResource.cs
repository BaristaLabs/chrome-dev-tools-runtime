namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Detailed application cache resource information.
    /// </summary>
    public sealed class ApplicationCacheResource
    {
        /// <summary>
        /// Resource url.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Resource size.
        ///</summary>
        [JsonProperty("size")]
        public long Size
        {
            get;
            set;
        }
        /// <summary>
        /// Resource type.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
}