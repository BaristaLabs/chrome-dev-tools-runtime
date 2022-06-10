namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called when distribution is changed.
    /// </summary>
    public sealed class DistributedNodesUpdatedEvent : IEvent
    {
        /// <summary>
        /// Insertion point where distributed nodes were updated.
        /// </summary>
        [JsonProperty("insertionPointId")]
        public long InsertionPointId
        {
            get;
            set;
        }
        /// <summary>
        /// Distributed nodes for given insertion point.
        /// </summary>
        [JsonProperty("distributedNodes")]
        public BackendNode[] DistributedNodes
        {
            get;
            set;
        }
    }
}