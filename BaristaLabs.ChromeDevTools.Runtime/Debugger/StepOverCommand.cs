namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Steps over the statement.
    /// </summary>
    public sealed class StepOverCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.stepOver";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The skipList specifies location ranges that should be skipped on step over.
        /// </summary>
        [JsonProperty("skipList", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LocationRange[] SkipList
        {
            get;
            set;
        }
    }

    public sealed class StepOverCommandResponse : ICommandResponse<StepOverCommand>
    {
    }
}