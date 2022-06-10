namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables event updates for the service.
    /// </summary>
    public sealed class StartObservingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BackgroundService.startObserving";
        
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

    public sealed class StartObservingCommandResponse : ICommandResponse<StartObservingCommand>
    {
    }
}