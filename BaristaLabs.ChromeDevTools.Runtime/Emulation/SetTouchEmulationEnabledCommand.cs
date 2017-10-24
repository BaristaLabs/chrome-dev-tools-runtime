namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables touch on platforms which do not support them.
    /// </summary>
    public sealed class SetTouchEmulationEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setTouchEmulationEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether the touch event emulation should be enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
        /// <summary>
        /// Maximum touch points supported. Defaults to one.
        /// </summary>
        [JsonProperty("maxTouchPoints", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxTouchPoints
        {
            get;
            set;
        }
    }

    public sealed class SetTouchEmulationEnabledCommandResponse : ICommandResponse<SetTouchEmulationEnabledCommand>
    {
    }
}