namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets instrumentation breakpoint.
    /// </summary>
    public sealed class SetInstrumentationBreakpointCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setInstrumentationBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Instrumentation name.
        /// </summary>
        [JsonProperty("instrumentation")]
        public string Instrumentation
        {
            get;
            set;
        }
    }

    public sealed class SetInstrumentationBreakpointCommandResponse : ICommandResponse<SetInstrumentationBreakpointCommand>
    {
        /// <summary>
        /// Id of the created breakpoint for further reference.
        ///</summary>
        [JsonProperty("breakpointId")]
        public string BreakpointId
        {
            get;
            set;
        }
    }
}