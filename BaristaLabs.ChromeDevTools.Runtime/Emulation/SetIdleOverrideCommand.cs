namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the Idle state.
    /// </summary>
    public sealed class SetIdleOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setIdleOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Mock isUserActive
        /// </summary>
        [JsonProperty("isUserActive")]
        public bool IsUserActive
        {
            get;
            set;
        }
        /// <summary>
        /// Mock isScreenUnlocked
        /// </summary>
        [JsonProperty("isScreenUnlocked")]
        public bool IsScreenUnlocked
        {
            get;
            set;
        }
    }

    public sealed class SetIdleOverrideCommandResponse : ICommandResponse<SetIdleOverrideCommand>
    {
    }
}