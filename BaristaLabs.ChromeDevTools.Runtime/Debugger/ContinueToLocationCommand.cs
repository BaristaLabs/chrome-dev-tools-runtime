namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Continues execution until specific location is reached.
    /// </summary>
    public sealed class ContinueToLocationCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.continueToLocation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Location to continue to.
        /// </summary>
        [JsonProperty("location")]
        public Location Location
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the targetCallFrames
        /// </summary>
        [JsonProperty("targetCallFrames", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TargetCallFrames
        {
            get;
            set;
        }
    }

    public sealed class ContinueToLocationCommandResponse : ICommandResponse<ContinueToLocationCommand>
    {
    }
}