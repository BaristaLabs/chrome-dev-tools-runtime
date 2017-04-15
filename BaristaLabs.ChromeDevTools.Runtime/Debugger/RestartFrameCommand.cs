namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Restarts particular call frame from the beginning.
    /// </summary>
    public sealed class RestartFrameCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.restartFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Call frame identifier to evaluate on.
        /// </summary>
        
        [JsonProperty("callFrameId")]
        public string CallFrameId
        {
            get;
            set;
        }
    
    }

    public sealed class RestartFrameCommandResponse : ICommandResponse<RestartFrameCommand>
    {
    
        
        /// <summary>
        /// New stack trace.
        ///</summary>
        
        [JsonProperty("callFrames")]
        public CallFrame[] CallFrames
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Async stack trace, if any.
        ///</summary>
        
        [JsonProperty("asyncStackTrace, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public Runtime.StackTrace AsyncStackTrace
        {
            get;
            set;
        }
    
    }
}