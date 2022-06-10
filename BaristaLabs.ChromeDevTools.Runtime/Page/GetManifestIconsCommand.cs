namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// GetManifestIcons
    /// </summary>
    public sealed class GetManifestIconsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getManifestIcons";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetManifestIconsCommandResponse : ICommandResponse<GetManifestIconsCommand>
    {
        /// <summary>
        /// Gets or sets the primaryIcon
        /// </summary>
        [JsonProperty("primaryIcon", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] PrimaryIcon
        {
            get;
            set;
        }
    }
}