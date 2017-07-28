namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// ServiceWorker version.
    /// </summary>
    public sealed class ServiceWorkerVersion
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("versionId")]
        public string VersionId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("registrationId")]
        public string RegistrationId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("scriptURL")]
        public string ScriptURL
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("runningStatus")]
        public ServiceWorkerVersionRunningStatus RunningStatus
        {
            get;
            set;
        }
        /// <summary>
        /// 
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
        /// The time at which the response headers of the main script were received from the server.  For cached script it is the last time the cache entry was validated.
        ///</summary>
        [JsonProperty("scriptResponseTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ScriptResponseTime
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("controlledClients", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ControlledClients
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("targetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TargetId
        {
            get;
            set;
        }
    }
}