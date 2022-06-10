namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Allows overriding the automation flag.
    /// </summary>
    public sealed class SetAutomationOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setAutomationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether the override should be enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetAutomationOverrideCommandResponse : ICommandResponse<SetAutomationOverrideCommand>
    {
    }
}