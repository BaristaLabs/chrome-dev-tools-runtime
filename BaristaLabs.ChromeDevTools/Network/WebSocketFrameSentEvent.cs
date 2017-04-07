namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired when WebSocket frame is sent.
    /// </summary>
    public sealed class WebSocketFrameSentEvent
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
        /// WebSocket response data.
        /// </summary>
        
        public WebSocketFrame Response
        {
            get;
            set;
        }
    
    }
}