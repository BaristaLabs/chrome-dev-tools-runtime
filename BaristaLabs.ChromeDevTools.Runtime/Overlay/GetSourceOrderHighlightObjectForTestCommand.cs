namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// For Source Order Viewer testing.
    /// </summary>
    public sealed class GetSourceOrderHighlightObjectForTestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.getSourceOrderHighlightObjectForTest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the node to highlight.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetSourceOrderHighlightObjectForTestCommandResponse : ICommandResponse<GetSourceOrderHighlightObjectForTestCommand>
    {
        /// <summary>
        /// Source order highlight data for the node id provided.
        ///</summary>
        [JsonProperty("highlight")]
        public object Highlight
        {
            get;
            set;
        }
    }
}