namespace BaristaLabs.ChromeDevTools.DOM
{
    /// <summary>
    /// Called when shadow root is popped from the element.
    /// </summary>
    public sealed class ShadowRootPoppedEvent
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
        /// Shadow root id.
        /// </summary>
        
        public long RootId
        {
            get;
            set;
        }
    
    }
}