namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// 
    /// </summary>
    [Event("DOM.nodeHighlightRequested")]
    public sealed class NodeHighlightRequestedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        
        public long NodeId
        {
            get;
            set;
        }
    
    }
}