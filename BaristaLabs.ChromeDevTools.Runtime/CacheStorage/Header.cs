namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Header
    /// </summary>
    public sealed class Header
    {
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name")]
        public string Name
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