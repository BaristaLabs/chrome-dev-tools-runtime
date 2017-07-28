namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Attaches to the target with given id.
    /// </summary>
    public sealed class AttachToTargetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.attachToTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    }

    public sealed class AttachToTargetCommandResponse : ICommandResponse<AttachToTargetCommand>
    {
        /// <summary>
        /// Whether attach succeeded.
        ///</summary>
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    }
}