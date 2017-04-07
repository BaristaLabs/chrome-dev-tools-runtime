namespace BaristaLabs.ChromeDevTools.Page
{
    /// <summary>
    /// Fired when frame has stopped loading.
    /// </summary>
    public sealed class FrameStoppedLoadingEvent
    {
    
        
        /// <summary>
        /// Id of the frame that has stopped loading.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
    }
}