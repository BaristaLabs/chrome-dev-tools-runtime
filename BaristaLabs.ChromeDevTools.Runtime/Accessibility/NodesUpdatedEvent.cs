namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
    /// </summary>
    public sealed class NodesUpdatedEvent : IEvent
    {
        /// <summary>
        /// Updated node data.
        /// </summary>
        [JsonProperty("nodes")]
        public AXNode[] Nodes
        {
            get;
            set;
        }
    }
}