namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when the node should be inspected. This happens after call to &lt;code&gt;setInspectMode&lt;/code&gt;.
    /// </summary>
    public sealed class InspectNodeRequestedEvent : IEvent
    {
        /// <summary>
        /// Id of the node to inspect.
        /// </summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
    }
}