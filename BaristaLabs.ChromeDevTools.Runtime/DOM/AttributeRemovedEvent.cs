namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when <code>Element</code>'s attribute is removed.
    /// </summary>
    public sealed class AttributeRemovedEvent : IEvent
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
        /// A ttribute name.
        /// </summary>
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
    }
}