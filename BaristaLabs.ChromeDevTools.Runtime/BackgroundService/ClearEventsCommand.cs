namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears all stored data for the service.
    /// </summary>
    public sealed class ClearEventsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BackgroundService.clearEvents";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the service
        /// </summary>
        [JsonProperty("service")]
        public ServiceName Service
        {
            get;
            set;
        }
    }

    public sealed class ClearEventsCommandResponse : ICommandResponse<ClearEventsCommand>
    {
    }
}