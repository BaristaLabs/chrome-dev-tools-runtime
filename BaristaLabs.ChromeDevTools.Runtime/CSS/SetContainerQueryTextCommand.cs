namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the expression of a container query.
    /// </summary>
    public sealed class SetContainerQueryTextCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setContainerQueryText";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the range
        /// </summary>
        [JsonProperty("range")]
        public SourceRange Range
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the text
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    }

    public sealed class SetContainerQueryTextCommandResponse : ICommandResponse<SetContainerQueryTextCommand>
    {
        /// <summary>
        /// The resulting CSS container query rule after modification.
        ///</summary>
        [JsonProperty("containerQuery")]
        public CSSContainerQuery ContainerQuery
        {
            get;
            set;
        }
    }
}