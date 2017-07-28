namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Get the browser window that contains the devtools target.
    /// </summary>
    public sealed class GetWindowForTargetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.getWindowForTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Devtools agent host id.
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    }

    public sealed class GetWindowForTargetCommandResponse : ICommandResponse<GetWindowForTargetCommand>
    {
        /// <summary>
        /// Browser window id.
        ///</summary>
        [JsonProperty("windowId")]
        public long WindowId
        {
            get;
            set;
        }
        /// <summary>
        /// Bounds information of the window. When window state is 'minimized', the restored window position and size are returned.
        ///</summary>
        [JsonProperty("bounds")]
        public Bounds Bounds
        {
            get;
            set;
        }
    }
}