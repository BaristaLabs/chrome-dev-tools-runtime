namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when exception was thrown and unhandled.
    /// </summary>
    public sealed class ExceptionThrownEvent : IEvent
    {
    
        
        /// <summary>
        /// Timestamp of the exception.
        /// </summary>
        
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the exceptionDetails
        /// </summary>
        
        [JsonProperty("exceptionDetails")]
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}