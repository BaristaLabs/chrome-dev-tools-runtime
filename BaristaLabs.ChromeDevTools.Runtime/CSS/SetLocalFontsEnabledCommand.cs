namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables/disables rendering of local CSS fonts (enabled by default).
    /// </summary>
    public sealed class SetLocalFontsEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setLocalFontsEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether rendering of local fonts is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetLocalFontsEnabledCommandResponse : ICommandResponse<SetLocalFontsEnabledCommand>
    {
    }
}