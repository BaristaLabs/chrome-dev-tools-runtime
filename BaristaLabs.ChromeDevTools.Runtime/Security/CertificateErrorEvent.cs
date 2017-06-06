namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// There is a certificate error. If overriding certificate errors is enabled, then it should be handled with the handleCertificateError command. Note: this event does not fire if the certificate error has been allowed internally.
    /// </summary>
    public sealed class CertificateErrorEvent : IEvent
    {
    
        
        /// <summary>
        /// The ID of the event.
        /// </summary>
        
        [JsonProperty("eventId")]
        public long EventId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The type of the error.
        /// </summary>
        
        [JsonProperty("errorType")]
        public string ErrorType
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The url that was requested.
        /// </summary>
        
        [JsonProperty("requestURL")]
        public string RequestURL
        {
            get;
            set;
        }
    
    }
}