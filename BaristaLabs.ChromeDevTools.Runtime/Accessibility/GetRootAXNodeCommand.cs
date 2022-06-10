namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches the root node.
    /// Requires `enable()` to have been called previously.
    /// </summary>
    public sealed class GetRootAXNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Accessibility.getRootAXNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The frame in whose document the node resides.
        /// If omitted, the root frame is used.
        /// </summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetRootAXNodeCommandResponse : ICommandResponse<GetRootAXNodeCommand>
    {
        /// <summary>
        /// Gets or sets the node
        /// </summary>
        [JsonProperty("node")]
        public AXNode Node
        {
            get;
            set;
        }
    }
}