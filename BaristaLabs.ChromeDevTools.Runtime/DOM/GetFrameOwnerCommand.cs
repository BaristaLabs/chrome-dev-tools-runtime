namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns iframe node that owns iframe with the given domain.
    /// </summary>
    public sealed class GetFrameOwnerCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getFrameOwner";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the frameId
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetFrameOwnerCommandResponse : ICommandResponse<GetFrameOwnerCommand>
    {
        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}