namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetEmitTouchEventsForMouse
    /// </summary>
    public sealed class SetEmitTouchEventsForMouseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setEmitTouchEventsForMouse";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether touch emulation based on mouse input should be enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
        /// <summary>
        /// Touch/gesture events configuration. Default: current platform.
        /// </summary>
        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Configuration
        {
            get;
            set;
        }
    }

    public sealed class SetEmitTouchEventsForMouseCommandResponse : ICommandResponse<SetEmitTouchEventsForMouseCommand>
    {
    }
}