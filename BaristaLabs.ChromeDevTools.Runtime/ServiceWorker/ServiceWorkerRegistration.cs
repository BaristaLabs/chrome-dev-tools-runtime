namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// ServiceWorker registration.
    /// </summary>
    public sealed class ServiceWorkerRegistration
    {
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
        /// scopeURL
        ///</summary>
        [JsonProperty("scopeURL")]
        public string ScopeURL
        {
            get;
            set;
        }
        /// <summary>
        /// isDeleted
        ///</summary>
        [JsonProperty("isDeleted")]
        public bool IsDeleted
        {
            get;
            set;
        }
    }
}