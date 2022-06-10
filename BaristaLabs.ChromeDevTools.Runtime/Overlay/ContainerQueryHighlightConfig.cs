namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// ContainerQueryHighlightConfig
    /// </summary>
    public sealed class ContainerQueryHighlightConfig
    {
        /// <summary>
        /// A descriptor for the highlight appearance of container query containers.
        ///</summary>
        [JsonProperty("containerQueryContainerHighlightConfig")]
        public ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the container node to highlight.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}