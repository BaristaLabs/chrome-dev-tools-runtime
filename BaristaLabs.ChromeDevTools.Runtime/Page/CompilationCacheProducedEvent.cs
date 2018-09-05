namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued for every compilation cache generated. Is only available
    /// if Page.setGenerateCompilationCache is enabled.
    /// </summary>
    public sealed class CompilationCacheProducedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the url
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Base64-encoded data
        /// </summary>
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    }
}