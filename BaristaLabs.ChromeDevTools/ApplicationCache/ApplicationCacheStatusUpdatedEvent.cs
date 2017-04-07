namespace BaristaLabs.ChromeDevTools.ApplicationCache
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ApplicationCacheStatusUpdatedEvent
    {
    
        
        /// <summary>
        /// Identifier of the frame containing document whose application cache updated status.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Manifest URL.
        /// </summary>
        
        public string ManifestURL
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Updated application cache status.
        /// </summary>
        
        public long Status
        {
            get;
            set;
        }
    
    }
}