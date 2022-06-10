namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// BackgroundServiceEvent
    /// </summary>
    public sealed class BackgroundServiceEvent
    {
        /// <summary>
        /// Timestamp of the event (in seconds).
        ///</summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// The origin this event belongs to.
        ///</summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// The Service Worker ID that initiated the event.
        ///</summary>
        [JsonProperty("serviceWorkerRegistrationId")]
        public string ServiceWorkerRegistrationId
        {
            get;
            set;
        }
        /// <summary>
        /// The Background Service this event belongs to.
        ///</summary>
        [JsonProperty("service")]
        public ServiceName Service
        {
            get;
            set;
        }
        /// <summary>
        /// A description of the event.
        ///</summary>
        [JsonProperty("eventName")]
        public string EventName
        {
            get;
            set;
        }
        /// <summary>
        /// An identifier that groups related events together.
        ///</summary>
        [JsonProperty("instanceId")]
        public string InstanceId
        {
            get;
            set;
        }
        /// <summary>
        /// A list of event-specific information.
        ///</summary>
        [JsonProperty("eventMetadata")]
        public EventMetadata[] EventMetadata
        {
            get;
            set;
        }
    }
}