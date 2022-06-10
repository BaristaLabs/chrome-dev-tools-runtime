namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables or disables simulating a focused and active page.
    /// </summary>
    public sealed class SetFocusEmulationEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setFocusEmulationEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to enable to disable focus emulation.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetFocusEmulationEnabledCommandResponse : ICommandResponse<SetFocusEmulationEnabledCommand>
    {
    }
}