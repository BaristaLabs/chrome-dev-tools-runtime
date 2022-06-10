namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sends protocol message over session with given id.
    /// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
    /// and crbug.com/991325.
    /// </summary>
    public sealed class SendMessageToTargetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.sendMessageToTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the message
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the session.
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

    public sealed class SendMessageToTargetCommandResponse : ICommandResponse<SendMessageToTargetCommand>
    {
    }
}