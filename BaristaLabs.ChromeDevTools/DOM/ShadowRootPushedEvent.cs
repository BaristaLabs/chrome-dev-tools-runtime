namespace BaristaLabs.ChromeDevTools.DOM
{
    /// <summary>
    /// Called when shadow root is pushed into the element.
    /// </summary>
    public sealed class ShadowRootPushedEvent
    {
    
        
        /// <summary>
        /// Host element id.
        /// </summary>
        
        public long HostId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Shadow root.
        /// </summary>
        
        public Node Root
        {
            get;
            set;
        }
    
    }
}