namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when frame has been attached to its parent.
    /// </summary>
    [Event("Page.frameAttached")]
    public sealed class FrameAttachedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the frame that has been attached.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Parent frame identifier.
        /// </summary>
        
        public string ParentFrameId
        {
            get;
            set;
        }
    
    }
}