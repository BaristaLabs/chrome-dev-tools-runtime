namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Steps into the function call.
    /// </summary>
    public sealed class StepIntoCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.stepInto";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Debugger will pause on the execution of the first async task which was scheduled
        /// before next pause.
        /// </summary>
        [JsonProperty("breakOnAsyncCall", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? BreakOnAsyncCall
        {
            get;
            set;
        }
        /// <summary>
        /// The skipList specifies location ranges that should be skipped on step into.
        /// </summary>
        [JsonProperty("skipList", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LocationRange[] SkipList
        {
            get;
            set;
        }
    }

    public sealed class StepIntoCommandResponse : ICommandResponse<StepIntoCommand>
    {
    }
}