namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables DOM agent for the given page.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to include whitespaces in the children array of returned Nodes.
        /// </summary>
        [JsonProperty("includeWhitespace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IncludeWhitespace
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}