namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set position and/or size of the browser window.
    /// </summary>
    public sealed class SetWindowBoundsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.setWindowBounds";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Browser window id.
        /// </summary>
        
        [JsonProperty("windowId")]
        public long WindowId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// New window bounds. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined with 'left', 'top', 'width' or 'height'. Leaves unspecified fields unchanged.
        /// </summary>
        
        [JsonProperty("bounds")]
        public Bounds Bounds
        {
            get;
            set;
        }
    
    }

    public sealed class SetWindowBoundsCommandResponse : ICommandResponse<SetWindowBoundsCommand>
    {
    
    }
}