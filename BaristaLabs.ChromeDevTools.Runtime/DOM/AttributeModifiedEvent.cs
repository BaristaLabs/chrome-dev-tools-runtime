namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when <code>Element</code>'s attribute is modified.
    /// </summary>
    public sealed class AttributeModifiedEvent : IEvent
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
        /// Attribute name.
        /// </summary>
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute value.
        /// </summary>
        
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
    }
}