namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides default host system locale with the specified one.
    /// </summary>
    public sealed class SetLocaleOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setLocaleOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// ICU style C locale (e.g. "en_US"). If not specified or empty, disables the override and
        /// restores default host system locale.
        /// </summary>
        [JsonProperty("locale", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Locale
        {
            get;
            set;
        }
    }

    public sealed class SetLocaleOverrideCommandResponse : ICommandResponse<SetLocaleOverrideCommand>
    {
    }
}