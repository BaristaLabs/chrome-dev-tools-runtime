namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all layers parsed by the rendering engine for the tree scope of a node.
    /// Given a DOM element identified by nodeId, getLayersForNode returns the root
    /// layer for the nearest ancestor document or shadow root. The layer root contains
    /// the full layer tree for the tree scope and their ordering.
    /// </summary>
    public sealed class GetLayersForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getLayersForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

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

    public sealed class GetLayersForNodeCommandResponse : ICommandResponse<GetLayersForNodeCommand>
    {
        /// <summary>
        /// Gets or sets the rootLayer
        /// </summary>
        [JsonProperty("rootLayer")]
        public CSSLayerData RootLayer
        {
            get;
            set;
        }
    }
}