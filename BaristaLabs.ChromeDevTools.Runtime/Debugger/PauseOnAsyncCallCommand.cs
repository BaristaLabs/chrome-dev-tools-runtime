namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PauseOnAsyncCallCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.pauseOnAsyncCall";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Debugger will pause when async call with given stack trace is started.
        /// </summary>
        [JsonProperty("parentStackTraceId")]
        public Runtime.StackTraceId ParentStackTraceId
        {
            get;
            set;
        }
    }

    public sealed class PauseOnAsyncCallCommandResponse : ICommandResponse<PauseOnAsyncCallCommand>
    {
    }
}