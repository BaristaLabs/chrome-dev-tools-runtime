namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the expression of a supports at-rule.
    /// </summary>
    public sealed class SetSupportsTextCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setSupportsText";
        
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

    public sealed class SetSupportsTextCommandResponse : ICommandResponse<SetSupportsTextCommand>
    {
        /// <summary>
        /// The resulting CSS Supports rule after modification.
        ///</summary>
        [JsonProperty("supports")]
        public CSSSupports Supports
        {
            get;
            set;
        }
    }
}