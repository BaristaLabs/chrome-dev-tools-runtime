namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set the recording state for the service.
    /// </summary>
    public sealed class SetRecordingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BackgroundService.setRecording";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the shouldRecord
        /// </summary>
        [JsonProperty("shouldRecord")]
        public bool ShouldRecord
        {
            get;
            set;
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

    public sealed class SetRecordingCommandResponse : ICommandResponse<SetRecordingCommand>
    {
    }
}