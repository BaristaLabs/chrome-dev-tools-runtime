namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Detaches session with given id.
    /// </summary>
    public sealed class DetachFromTargetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.detachFromTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Session to detach.
        /// </summary>
        [JsonProperty("sessionId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SessionId
        {
            get;
            set;
        }
        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty("targetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TargetId
        {
            get;
            set;
        }
    }

    public sealed class DetachFromTargetCommandResponse : ICommandResponse<DetachFromTargetCommand>
    {
    }
}