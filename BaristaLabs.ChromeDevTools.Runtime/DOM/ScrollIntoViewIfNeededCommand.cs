namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Scrolls the specified rect of the given node into view if not already visible.
    /// Note: exactly one between nodeId, backendNodeId and objectId should be passed
    /// to identify the node.
    /// </summary>
    public sealed class ScrollIntoViewIfNeededCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.scrollIntoViewIfNeeded";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the node.
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the backend node.
        /// </summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript object id of the node wrapper.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// The rect to be scrolled into view, relative to the node's border box, in CSS pixels.
        /// When omitted, center of the node will be used, similar to Element.scrollIntoView.
        /// </summary>
        [JsonProperty("rect", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Rect Rect
        {
            get;
            set;
        }
    }

    public sealed class ScrollIntoViewIfNeededCommandResponse : ICommandResponse<ScrollIntoViewIfNeededCommand>
    {
    }
}