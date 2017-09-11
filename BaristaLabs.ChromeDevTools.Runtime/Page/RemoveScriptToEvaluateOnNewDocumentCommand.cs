namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes given script from the list.
    /// </summary>
    public sealed class RemoveScriptToEvaluateOnNewDocumentCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.removeScriptToEvaluateOnNewDocument";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier
        {
            get;
            set;
        }
    }

    public sealed class RemoveScriptToEvaluateOnNewDocumentCommandResponse : ICommandResponse<RemoveScriptToEvaluateOnNewDocumentCommand>
    {
    }
}