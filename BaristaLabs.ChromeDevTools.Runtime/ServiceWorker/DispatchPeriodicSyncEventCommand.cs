namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// DispatchPeriodicSyncEvent
    /// </summary>
    public sealed class DispatchPeriodicSyncEventCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.dispatchPeriodicSyncEvent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the origin
        /// </summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the registrationId
        /// </summary>
        [JsonProperty("registrationId")]
        public string RegistrationId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag
        {
            get;
            set;
        }
    }

    public sealed class DispatchPeriodicSyncEventCommandResponse : ICommandResponse<DispatchPeriodicSyncEventCommand>
    {
    }
}