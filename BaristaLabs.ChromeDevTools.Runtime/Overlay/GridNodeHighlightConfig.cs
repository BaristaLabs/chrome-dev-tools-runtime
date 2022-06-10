namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configurations for Persistent Grid Highlight
    /// </summary>
    public sealed class GridNodeHighlightConfig
    {
        /// <summary>
        /// A descriptor for the highlight appearance.
        ///</summary>
        [JsonProperty("gridHighlightConfig")]
        public GridHighlightConfig GridHighlightConfig
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