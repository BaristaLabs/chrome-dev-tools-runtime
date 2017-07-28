namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when backend wants to provide client with the missing DOM structure. This happens upon most of the calls requesting node ids.
    /// </summary>
    public sealed class SetChildNodesEvent : IEvent
    {
        /// <summary>
        /// Parent node id to populate with children.
        /// </summary>
        [JsonProperty("parentId")]
        public long ParentId
        {
            get;
            set;
        }
        /// <summary>
        /// Child nodes array.
        /// </summary>
        [JsonProperty("nodes")]
        public Node[] Nodes
        {
            get;
            set;
        }
    }
}