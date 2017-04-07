namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired when HTTP request has failed to load.
    /// </summary>
    public sealed class LoadingFailedEvent
    {
    
        
        /// <summary>
        /// Request identifier.
        /// </summary>
        
        public string RequestId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Timestamp.
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Resource type.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Page.ResourceType Type
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// User friendly error message.
        /// </summary>
        
        public string ErrorText
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True if loading was canceled.
        /// </summary>
        
        public bool Canceled
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The reason why loading was blocked, if any.
        /// </summary>
        
        public BlockedReason BlockedReason
        {
            get;
            set;
        }
    
    }
}