namespace BaristaLabs.ChromeDevTools.DOM
{
    /// <summary>
    /// Mirrors <code>DOMNodeRemoved</code> event.
    /// </summary>
    public sealed class ChildNodeRemovedEvent
    {
    
        
        /// <summary>
        /// Parent id.
        /// </summary>
        
        public long ParentNodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Id of the node that has been removed.
        /// </summary>
        
        public long NodeId
        {
            get;
            set;
        }
    
    }
}