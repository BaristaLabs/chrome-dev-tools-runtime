namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resumes JavaScript execution.
    /// </summary>
    public sealed class ResumeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.resume";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Set to true to terminate execution upon resuming execution. In contrast
        /// to Runtime.terminateExecution, this will allows to execute further
        /// JavaScript (i.e. via evaluation) until execution of the paused code
        /// is actually resumed, at which point termination is triggered.
        /// If execution is currently not paused, this parameter has no effect.
        /// </summary>
        [JsonProperty("terminateOnResume", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? TerminateOnResume
        {
            get;
            set;
        }
    }

    public sealed class ResumeCommandResponse : ICommandResponse<ResumeCommand>
    {
    }
}