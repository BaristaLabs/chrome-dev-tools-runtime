namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when <code>Element</code>'s inline style is modified via a CSS property modification.
    /// </summary>
    public sealed class InlineStyleInvalidatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Ids of the nodes for which the inline styles have been invalidated.
        /// </summary>
        
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    
    }
}