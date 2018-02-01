namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns stack trace with given <code>stackTraceId</code>.
    /// </summary>
    public sealed class GetStackTraceCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.getStackTrace";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the stackTraceId
        /// </summary>
        [JsonProperty("stackTraceId")]
        public Runtime.StackTraceId StackTraceId
        {
            get;
            set;
        }
    }

    public sealed class GetStackTraceCommandResponse : ICommandResponse<GetStackTraceCommand>
    {
        /// <summary>
        /// Gets or sets the stackTrace
        /// </summary>
        [JsonProperty("stackTrace")]
        public Runtime.StackTrace StackTrace
        {
            get;
            set;
        }
    }
}