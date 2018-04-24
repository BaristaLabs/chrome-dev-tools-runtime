namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stop tracking rule usage and return the list of rules that were used since last call to
    /// `takeCoverageDelta` (or since start of coverage instrumentation)
    /// </summary>
    public sealed class StopRuleUsageTrackingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.stopRuleUsageTracking";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopRuleUsageTrackingCommandResponse : ICommandResponse<StopRuleUsageTrackingCommand>
    {
        /// <summary>
        /// Gets or sets the ruleUsage
        /// </summary>
        [JsonProperty("ruleUsage")]
        public RuleUsage[] RuleUsage
        {
            get;
            set;
        }
    }
}