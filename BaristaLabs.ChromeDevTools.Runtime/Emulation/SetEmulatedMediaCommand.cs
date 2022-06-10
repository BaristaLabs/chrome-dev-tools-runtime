namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Emulates the given media type or media feature for CSS media queries.
    /// </summary>
    public sealed class SetEmulatedMediaCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setEmulatedMedia";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Media type to emulate. Empty string disables the override.
        /// </summary>
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media
        {
            get;
            set;
        }
        /// <summary>
        /// Media features to emulate.
        /// </summary>
        [JsonProperty("features", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MediaFeature[] Features
        {
            get;
            set;
        }
    }

    public sealed class SetEmulatedMediaCommandResponse : ICommandResponse<SetEmulatedMediaCommand>
    {
    }
}