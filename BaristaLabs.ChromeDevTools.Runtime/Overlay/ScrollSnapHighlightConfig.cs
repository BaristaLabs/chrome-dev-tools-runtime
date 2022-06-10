namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// ScrollSnapHighlightConfig
    /// </summary>
    public sealed class ScrollSnapHighlightConfig
    {
        /// <summary>
        /// A descriptor for the highlight appearance of scroll snap containers.
        ///</summary>
        [JsonProperty("scrollSnapContainerHighlightConfig")]
        public ScrollSnapContainerHighlightConfig ScrollSnapContainerHighlightConfig
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the node to highlight.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}