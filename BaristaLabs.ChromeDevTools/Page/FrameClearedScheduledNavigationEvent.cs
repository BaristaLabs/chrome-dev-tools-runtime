namespace BaristaLabs.ChromeDevTools.Page
{
    /// <summary>
    /// Fired when frame no longer has a scheduled navigation.
    /// </summary>
    public sealed class FrameClearedScheduledNavigationEvent
    {
    
        
        /// <summary>
        /// Id of the frame that has cleared its scheduled navigation.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
    }
}