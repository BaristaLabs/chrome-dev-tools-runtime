namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Used to specify User Agent Cient Hints to emulate. See https://wicg.github.io/ua-client-hints
    /// Missing optional values will be filled in by the target with what it would normally use.
    /// </summary>
    public sealed class UserAgentMetadata
    {
        /// <summary>
        /// brands
        ///</summary>
        [JsonProperty("brands", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public UserAgentBrandVersion[] Brands
        {
            get;
            set;
        }
        /// <summary>
        /// fullVersionList
        ///</summary>
        [JsonProperty("fullVersionList", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public UserAgentBrandVersion[] FullVersionList
        {
            get;
            set;
        }
        /// <summary>
        /// fullVersion
        ///</summary>
        [JsonProperty("fullVersion", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullVersion
        {
            get;
            set;
        }
        /// <summary>
        /// platform
        ///</summary>
        [JsonProperty("platform")]
        public string Platform
        {
            get;
            set;
        }
        /// <summary>
        /// platformVersion
        ///</summary>
        [JsonProperty("platformVersion")]
        public string PlatformVersion
        {
            get;
            set;
        }
        /// <summary>
        /// architecture
        ///</summary>
        [JsonProperty("architecture")]
        public string Architecture
        {
            get;
            set;
        }
        /// <summary>
        /// model
        ///</summary>
        [JsonProperty("model")]
        public string Model
        {
            get;
            set;
        }
        /// <summary>
        /// mobile
        ///</summary>
        [JsonProperty("mobile")]
        public bool Mobile
        {
            get;
            set;
        }
    }
}