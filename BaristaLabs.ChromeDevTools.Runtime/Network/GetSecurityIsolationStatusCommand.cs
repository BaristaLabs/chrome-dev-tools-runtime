namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns information about the COEP/COOP isolation status.
    /// </summary>
    public sealed class GetSecurityIsolationStatusCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.getSecurityIsolationStatus";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If no frameId is provided, the status of the target is provided.
        /// </summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetSecurityIsolationStatusCommandResponse : ICommandResponse<GetSecurityIsolationStatusCommand>
    {
        /// <summary>
        /// Gets or sets the status
        /// </summary>
        [JsonProperty("status")]
        public SecurityIsolationStatus Status
        {
            get;
            set;
        }
    }
}