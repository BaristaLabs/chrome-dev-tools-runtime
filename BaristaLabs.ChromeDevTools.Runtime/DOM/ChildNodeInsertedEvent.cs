namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Mirrors &lt;code&gt;DOMNodeInserted&lt;/code&gt; event.
    /// </summary>
    public sealed class ChildNodeInsertedEvent : IEvent
    {
        /// <summary>
        /// Id of the node that has changed.
        /// </summary>
        [JsonProperty("parentNodeId")]
        public long ParentNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// If of the previous siblint.
        /// </summary>
        [JsonProperty("previousNodeId")]
        public long PreviousNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Inserted node data.
        /// </summary>
        [JsonProperty("node")]
        public Node Node
        {
            get;
            set;
        }
    }
}