namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets breakpoint on particular CSP violations.
    /// </summary>
    public sealed class SetBreakOnCSPViolationCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.setBreakOnCSPViolation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// CSP Violations to stop upon.
        /// </summary>
        [JsonProperty("violationTypes")]
        public CSPViolationType[] ViolationTypes
        {
            get;
            set;
        }
    }

    public sealed class SetBreakOnCSPViolationCommandResponse : ICommandResponse<SetBreakOnCSPViolationCommand>
    {
    }
}