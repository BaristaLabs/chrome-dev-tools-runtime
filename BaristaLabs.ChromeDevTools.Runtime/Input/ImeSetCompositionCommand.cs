namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// This method sets the current candidate text for ime.
    /// Use imeCommitComposition to commit the final text.
    /// Use imeSetComposition with empty string as text to cancel composition.
    /// </summary>
    public sealed class ImeSetCompositionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Input.imeSetComposition";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The text to insert
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// selection start
        /// </summary>
        [JsonProperty("selectionStart")]
        public long SelectionStart
        {
            get;
            set;
        }
        /// <summary>
        /// selection end
        /// </summary>
        [JsonProperty("selectionEnd")]
        public long SelectionEnd
        {
            get;
            set;
        }
        /// <summary>
        /// replacement start
        /// </summary>
        [JsonProperty("replacementStart", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ReplacementStart
        {
            get;
            set;
        }
        /// <summary>
        /// replacement end
        /// </summary>
        [JsonProperty("replacementEnd", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ReplacementEnd
        {
            get;
            set;
        }
    }

    public sealed class ImeSetCompositionCommandResponse : ICommandResponse<ImeSetCompositionCommand>
    {
    }
}