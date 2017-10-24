namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Header
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }
}