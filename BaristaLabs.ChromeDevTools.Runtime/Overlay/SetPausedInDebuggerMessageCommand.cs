namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SetPausedInDebuggerMessageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setPausedInDebuggerMessage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The message to display, also triggers resume and step over controls.
        /// </summary>
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message
        {
            get;
            set;
        }
    }

    public sealed class SetPausedInDebuggerMessageCommandResponse : ICommandResponse<SetPausedInDebuggerMessageCommand>
    {
    }
}