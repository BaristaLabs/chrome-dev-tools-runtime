namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when EventSource message is received.
    /// </summary>
    public sealed class EventSourceMessageReceivedEvent : IEvent
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
        /// Message type.
        /// </summary>
        
        [JsonProperty("eventName")]
        public string EventName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Message identifier.
        /// </summary>
        
        [JsonProperty("eventId")]
        public string EventId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Message content.
        /// </summary>
        
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    
    }
}