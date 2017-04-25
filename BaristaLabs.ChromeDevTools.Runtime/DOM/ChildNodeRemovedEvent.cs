namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Mirrors &lt;code&gt;DOMNodeRemoved&lt;/code&gt; event.
    /// </summary>
    public sealed class ChildNodeRemovedEvent : IEvent
    {
        /// <summary>
        /// Parent id.
        /// </summary>
        [JsonProperty("parentNodeId")]
        public long ParentNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Id of the node that has been removed.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}