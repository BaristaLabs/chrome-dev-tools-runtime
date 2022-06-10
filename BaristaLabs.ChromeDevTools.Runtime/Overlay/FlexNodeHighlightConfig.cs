namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// FlexNodeHighlightConfig
    /// </summary>
    public sealed class FlexNodeHighlightConfig
    {
        /// <summary>
        /// A descriptor for the highlight appearance of flex containers.
        ///</summary>
        [JsonProperty("flexContainerHighlightConfig")]
        public FlexContainerHighlightConfig FlexContainerHighlightConfig
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