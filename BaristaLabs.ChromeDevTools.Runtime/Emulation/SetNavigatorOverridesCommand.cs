namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides value returned by the javascript navigator object.
    /// </summary>
    public sealed class SetNavigatorOverridesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setNavigatorOverrides";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The platform navigator.platform should return.
        /// </summary>
        [JsonProperty("platform")]
        public string Platform
        {
            get;
            set;
        }
    }

    public sealed class SetNavigatorOverridesCommandResponse : ICommandResponse<SetNavigatorOverridesCommand>
    {
    }
}