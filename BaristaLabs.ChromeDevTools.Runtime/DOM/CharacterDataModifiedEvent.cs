namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Mirrors &lt;code&gt;DOMCharacterDataModified&lt;/code&gt; event.
    /// </summary>
    public sealed class CharacterDataModifiedEvent : IEvent
    {
        /// <summary>
        /// Id of the node that has changed.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// New text value.
        /// </summary>
        [JsonProperty("characterData")]
        public string CharacterData
        {
            get;
            set;
        }
    }
}