namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// ServiceWorker version.
    /// </summary>
    public sealed class ServiceWorkerVersion
    {
        /// <summary>
        /// versionId
        ///</summary>
        [JsonProperty("versionId")]
        public string VersionId
        {
            get;
            set;
        }
        /// <summary>
        /// registrationId
        ///</summary>
        [JsonProperty("registrationId")]
        public string RegistrationId
        {
            get;
            set;
        }
        /// <summary>
        /// scriptURL
        ///</summary>
        [JsonProperty("scriptURL")]
        public string ScriptURL
        {
            get;
            set;
        }
        /// <summary>
        /// runningStatus
        ///</summary>
        [JsonProperty("runningStatus")]
        public ServiceWorkerVersionRunningStatus RunningStatus
        {
            get;
            set;
        }
        /// <summary>
        /// status
        ///</summary>
        [JsonProperty("status")]
        public ServiceWorkerVersionStatus Status
        {
            get;
            set;
        }
        /// <summary>
        /// The Last-Modified header value of the main script.
        ///</summary>
        [JsonProperty("scriptLastModified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ScriptLastModified
        {
            get;
            set;
        }
        /// <summary>
        /// The time at which the response headers of the main script were received from the server.
        /// For cached script it is the last time the cache entry was validated.
        ///</summary>
        [JsonProperty("scriptResponseTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ScriptResponseTime
        {
            get;
            set;
        }
        /// <summary>
        /// controlledClients
        ///</summary>
        [JsonProperty("controlledClients", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ControlledClients
        {
            get;
            set;
        }
        /// <summary>
        /// targetId
        ///</summary>
        [JsonProperty("targetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TargetId
        {
            get;
            set;
        }
    }
}