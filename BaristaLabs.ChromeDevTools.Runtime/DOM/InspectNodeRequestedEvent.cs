namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when the node should be inspected. This happens after call to <code>setInspectMode</code>.
    /// </summary>
    [Event("DOM.inspectNodeRequested")]
    public sealed class InspectNodeRequestedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the node to inspect.
        /// </summary>
        
        public long BackendNodeId
        {
            get;
            set;
        }
    
    }
}