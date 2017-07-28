namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Obtain list of rules that became used since last call to this method (or since start of coverage instrumentation)
    /// </summary>
    public sealed class TakeCoverageDeltaCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.takeCoverageDelta";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class TakeCoverageDeltaCommandResponse : ICommandResponse<TakeCoverageDeltaCommand>
    {
        /// <summary>
        /// Gets or sets the coverage
        /// </summary>
        [JsonProperty("coverage")]
        public RuleUsage[] Coverage
        {
            get;
            set;
        }
    }
}