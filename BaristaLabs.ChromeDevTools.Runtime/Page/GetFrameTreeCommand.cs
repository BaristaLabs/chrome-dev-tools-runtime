namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns present frame tree structure.
    /// </summary>
    public sealed class GetFrameTreeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getFrameTree";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetFrameTreeCommandResponse : ICommandResponse<GetFrameTreeCommand>
    {
        /// <summary>
        /// Present frame tree structure.
        ///</summary>
        [JsonProperty("frameTree")]
        public FrameTree FrameTree
        {
            get;
            set;
        }
    }
}