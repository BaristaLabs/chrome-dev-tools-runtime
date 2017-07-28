namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when the node should be inspected. This happens after call to &lt;code&gt;setInspectMode&lt;/code&gt; or when user manually inspects an element.
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