namespace BaristaLabs.ChromeDevTools.DOM
{
    /// <summary>
    /// Fired when the node should be inspected. This happens after call to <code>setInspectMode</code>.
    /// </summary>
    public sealed class InspectNodeRequestedEvent
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