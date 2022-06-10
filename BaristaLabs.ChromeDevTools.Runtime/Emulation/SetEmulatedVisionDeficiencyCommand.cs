namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Emulates the given vision deficiency.
    /// </summary>
    public sealed class SetEmulatedVisionDeficiencyCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setEmulatedVisionDeficiency";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Vision deficiency to emulate.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }

    public sealed class SetEmulatedVisionDeficiencyCommandResponse : ICommandResponse<SetEmulatedVisionDeficiencyCommand>
    {
    }
}