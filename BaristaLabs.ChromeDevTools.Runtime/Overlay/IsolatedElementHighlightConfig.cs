namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// IsolatedElementHighlightConfig
    /// </summary>
    public sealed class IsolatedElementHighlightConfig
    {
        /// <summary>
        /// A descriptor for the highlight appearance of an element in isolation mode.
        ///</summary>
        [JsonProperty("isolationModeHighlightConfig")]
        public IsolationModeHighlightConfig IsolationModeHighlightConfig
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the isolated element to highlight.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}