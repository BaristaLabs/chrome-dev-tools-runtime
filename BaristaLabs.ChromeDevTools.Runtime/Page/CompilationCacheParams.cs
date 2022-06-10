namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Per-script compilation cache parameters for `Page.produceCompilationCache`
    /// </summary>
    public sealed class CompilationCacheParams
    {
        /// <summary>
        /// The URL of the script to produce a compilation cache entry for.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// A hint to the backend whether eager compilation is recommended.
        /// (the actual compilation mode used is upon backend discretion).
        ///</summary>
        [JsonProperty("eager", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Eager
        {
            get;
            set;
        }
    }
}