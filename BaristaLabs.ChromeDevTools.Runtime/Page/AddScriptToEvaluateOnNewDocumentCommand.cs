namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Evaluates given script in every frame upon creation (before loading frame's scripts).
    /// </summary>
    public sealed class AddScriptToEvaluateOnNewDocumentCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.addScriptToEvaluateOnNewDocument";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the source
        /// </summary>
        [JsonProperty("source")]
        public string Source
        {
            get;
            set;
        }
    }

    public sealed class AddScriptToEvaluateOnNewDocumentCommandResponse : ICommandResponse<AddScriptToEvaluateOnNewDocumentCommand>
    {
        /// <summary>
        /// Identifier of the added script.
        ///</summary>
        [JsonProperty("identifier")]
        public string Identifier
        {
            get;
            set;
        }
    }
}