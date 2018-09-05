namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Attaches to the browser target, only uses flat sessionId mode.
    /// </summary>
    public sealed class AttachToBrowserTargetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.attachToBrowserTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class AttachToBrowserTargetCommandResponse : ICommandResponse<AttachToBrowserTargetCommand>
    {
        /// <summary>
        /// Id assigned to the session.
        ///</summary>
        [JsonProperty("sessionId")]
        public string SessionId
        {
            get;
            set;
        }
    }
}