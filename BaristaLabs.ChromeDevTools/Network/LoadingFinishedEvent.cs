namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired when HTTP request has finished loading.
    /// </summary>
    public sealed class LoadingFinishedEvent
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
        /// Total number of bytes received for this request.
        /// </summary>
        
        public double EncodedDataLength
        {
            get;
            set;
        }
    
    }
}