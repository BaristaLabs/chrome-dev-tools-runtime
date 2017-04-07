namespace BaristaLabs.ChromeDevTools.Page
{
    /// <summary>
    /// Fired when frame has started loading.
    /// </summary>
    public sealed class FrameStartedLoadingEvent
    {
    
        
        /// <summary>
        /// Id of the frame that has started loading.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
    }
}