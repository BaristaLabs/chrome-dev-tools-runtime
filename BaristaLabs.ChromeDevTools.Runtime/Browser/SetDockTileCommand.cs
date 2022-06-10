namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set dock tile details, platform-specific.
    /// </summary>
    public sealed class SetDockTileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.setDockTile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the badgeLabel
        /// </summary>
        [JsonProperty("badgeLabel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BadgeLabel
        {
            get;
            set;
        }
        /// <summary>
        /// Png encoded image.
        /// </summary>
        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] Image
        {
            get;
            set;
        }
    }

    public sealed class SetDockTileCommandResponse : ICommandResponse<SetDockTileCommand>
    {
    }
}