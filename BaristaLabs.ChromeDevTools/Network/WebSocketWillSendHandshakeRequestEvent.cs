namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired when WebSocket is about to initiate handshake.
    /// </summary>
    public sealed class WebSocketWillSendHandshakeRequestEvent
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
        /// UTC Timestamp.
        /// </summary>
        
        public double WallTime
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// WebSocket request data.
        /// </summary>
        
        public WebSocketRequest Request
        {
            get;
            set;
        }
    
    }
}