namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Automatically render all web contents using a dark theme.
    /// </summary>
    public sealed class SetAutoDarkModeOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setAutoDarkModeOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to enable or disable automatic dark mode.
        /// If not specified, any existing override will be cleared.
        /// </summary>
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetAutoDarkModeOverrideCommandResponse : ICommandResponse<SetAutoDarkModeOverrideCommand>
    {
    }
}