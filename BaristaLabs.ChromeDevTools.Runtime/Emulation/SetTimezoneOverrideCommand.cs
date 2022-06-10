namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides default host system timezone with the specified one.
    /// </summary>
    public sealed class SetTimezoneOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setTimezoneOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The timezone identifier. If empty, disables the override and
        /// restores default host system timezone.
        /// </summary>
        [JsonProperty("timezoneId")]
        public string TimezoneId
        {
            get;
            set;
        }
    }

    public sealed class SetTimezoneOverrideCommandResponse : ICommandResponse<SetTimezoneOverrideCommand>
    {
    }
}