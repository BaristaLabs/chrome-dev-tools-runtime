namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// For Persistent Grid testing.
    /// </summary>
    public sealed class GetGridHighlightObjectsForTestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.getGridHighlightObjectsForTest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Ids of the node to get highlight object for.
        /// </summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }

    public sealed class GetGridHighlightObjectsForTestCommandResponse : ICommandResponse<GetGridHighlightObjectsForTestCommand>
    {
        /// <summary>
        /// Grid Highlight data for the node ids provided.
        ///</summary>
        [JsonProperty("highlights")]
        public object Highlights
        {
            get;
            set;
        }
    }
}