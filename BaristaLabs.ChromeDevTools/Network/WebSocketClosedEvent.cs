namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired when WebSocket is closed.
    /// </summary>
    public sealed class WebSocketClosedEvent
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
    
    }
}