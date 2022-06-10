namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// BackForwardCacheNotRestoredExplanation
    /// </summary>
    public sealed class BackForwardCacheNotRestoredExplanation
    {
        /// <summary>
        /// Type of the reason
        ///</summary>
        [JsonProperty("type")]
        public BackForwardCacheNotRestoredReasonType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Not restored reason
        ///</summary>
        [JsonProperty("reason")]
        public BackForwardCacheNotRestoredReason Reason
        {
            get;
            set;
        }
        /// <summary>
        /// Context associated with the reason. The meaning of this context is
        /// dependent on the reason:
        /// - EmbedderExtensionSentMessageToCachedFrame: the extension ID.
        ///</summary>
        [JsonProperty("context", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Context
        {
            get;
            set;
        }
    }
}