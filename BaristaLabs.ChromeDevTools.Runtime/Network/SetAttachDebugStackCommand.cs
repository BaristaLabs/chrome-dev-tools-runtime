namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Specifies whether to attach a page script stack id in requests
    /// </summary>
    public sealed class SetAttachDebugStackCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setAttachDebugStack";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to attach a page script stack for debugging purpose.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetAttachDebugStackCommandResponse : ICommandResponse<SetAttachDebugStackCommand>
    {
    }
}