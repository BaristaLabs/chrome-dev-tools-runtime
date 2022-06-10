namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables event updates for the service.
    /// </summary>
    public sealed class StopObservingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BackgroundService.stopObserving";
        
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

    public sealed class StopObservingCommandResponse : ICommandResponse<StopObservingCommand>
    {
    }
}