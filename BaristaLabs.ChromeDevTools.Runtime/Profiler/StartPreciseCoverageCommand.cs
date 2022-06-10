namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code
    /// coverage may be incomplete. Enabling prevents running optimized code and resets execution
    /// counters.
    /// </summary>
    public sealed class StartPreciseCoverageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.startPreciseCoverage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Collect accurate call counts beyond simple 'covered' or 'not covered'.
        /// </summary>
        [JsonProperty("callCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CallCount
        {
            get;
            set;
        }
        /// <summary>
        /// Collect block-based coverage.
        /// </summary>
        [JsonProperty("detailed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Detailed
        {
            get;
            set;
        }
        /// <summary>
        /// Allow the backend to send updates on its own initiative
        /// </summary>
        [JsonProperty("allowTriggeredUpdates", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AllowTriggeredUpdates
        {
            get;
            set;
        }
    }

    public sealed class StartPreciseCoverageCommandResponse : ICommandResponse<StartPreciseCoverageCommand>
    {
        /// <summary>
        /// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
        ///</summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    }
}