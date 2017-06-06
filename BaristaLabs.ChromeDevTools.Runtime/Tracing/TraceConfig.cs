namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TraceConfig
    {
    
        /// <summary>
        /// Controls how the trace buffer stores data.
        ///</summary>
        [JsonProperty("recordMode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RecordMode
        {
            get;
            set;
        }
    
        /// <summary>
        /// Turns on JavaScript stack sampling.
        ///</summary>
        [JsonProperty("enableSampling", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EnableSampling
        {
            get;
            set;
        }
    
        /// <summary>
        /// Turns on system tracing.
        ///</summary>
        [JsonProperty("enableSystrace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EnableSystrace
        {
            get;
            set;
        }
    
        /// <summary>
        /// Turns on argument filter.
        ///</summary>
        [JsonProperty("enableArgumentFilter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EnableArgumentFilter
        {
            get;
            set;
        }
    
        /// <summary>
        /// Included category filters.
        ///</summary>
        [JsonProperty("includedCategories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] IncludedCategories
        {
            get;
            set;
        }
    
        /// <summary>
        /// Excluded category filters.
        ///</summary>
        [JsonProperty("excludedCategories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] ExcludedCategories
        {
            get;
            set;
        }
    
        /// <summary>
        /// Configuration to synthesize the delays in tracing.
        ///</summary>
        [JsonProperty("syntheticDelays", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] SyntheticDelays
        {
            get;
            set;
        }
    
        /// <summary>
        /// Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
        ///</summary>
        [JsonProperty("memoryDumpConfig", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MemoryDumpConfig MemoryDumpConfig
        {
            get;
            set;
        }
    
    }
}