namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Puts the browser into deterministic mode.  Only effective for subsequently created web contents.
    /// Only supported in headless mode.  Once set there's no way of leaving deterministic mode.
    /// </summary>
    public sealed class EnterDeterministicModeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeadlessExperimental.enterDeterministicMode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Number of seconds since the Epoch
        /// </summary>
        [JsonProperty("initialDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? InitialDate
        {
            get;
            set;
        }
    }

    public sealed class EnterDeterministicModeCommandResponse : ICommandResponse<EnterDeterministicModeCommand>
    {
    }
}