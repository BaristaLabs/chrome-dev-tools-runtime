namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when WebSocket frame is sent.
    /// </summary>
    public sealed class WebSocketFrameSentEvent : IEvent
    {
    
        
        /// <summary>
        /// Request identifier.
        /// </summary>
        
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Timestamp.
        /// </summary>
        
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// WebSocket response data.
        /// </summary>
        
        [JsonProperty("response")]
        public WebSocketFrame Response
        {
            get;
            set;
        }
    
    }
}