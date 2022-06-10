namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables/Disables issuing of interestGroupAccessed events.
    /// </summary>
    public sealed class SetInterestGroupTrackingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.setInterestGroupTracking";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the enable
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable
        {
            get;
            set;
        }
    }

    public sealed class SetInterestGroupTrackingCommandResponse : ICommandResponse<SetInterestGroupTrackingCommand>
    {
    }
}