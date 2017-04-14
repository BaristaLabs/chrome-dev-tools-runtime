namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Detailed application cache information.
    /// </summary>
    public sealed class ApplicationCache
    {
    
        /// <summary>
        /// Manifest URL.
        ///</summary>
        [JsonProperty("manifestURL")]
        public string ManifestURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// Application cache size.
        ///</summary>
        [JsonProperty("size")]
        public double Size
        {
            get;
            set;
        }
    
        /// <summary>
        /// Application cache creation time.
        ///</summary>
        [JsonProperty("creationTime")]
        public double CreationTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// Application cache update time.
        ///</summary>
        [JsonProperty("updateTime")]
        public double UpdateTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// Application cache resources.
        ///</summary>
        [JsonProperty("resources")]
        public ApplicationCacheResource[] Resources
        {
            get;
            set;
        }
    
    }
}