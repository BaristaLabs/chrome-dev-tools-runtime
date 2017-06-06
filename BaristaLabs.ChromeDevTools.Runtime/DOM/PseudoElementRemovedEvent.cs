namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called when a pseudo element is removed from an element.
    /// </summary>
    public sealed class PseudoElementRemovedEvent : IEvent
    {
    
        
        /// <summary>
        /// Pseudo element's parent element id.
        /// </summary>
        
        [JsonProperty("parentId")]
        public long ParentId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The removed pseudo element id.
        /// </summary>
        
        [JsonProperty("pseudoElementId")]
        public long PseudoElementId
        {
            get;
            set;
        }
    
    }
}