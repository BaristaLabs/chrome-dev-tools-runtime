namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Add a dual screen device hinge
    /// </summary>
    public sealed class SetShowHingeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowHinge";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// hinge data, null means hideHinge
        /// </summary>
        [JsonProperty("hingeConfig", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HingeConfig HingeConfig
        {
            get;
            set;
        }
    }

    public sealed class SetShowHingeCommandResponse : ICommandResponse<SetShowHingeCommand>
    {
    }
}