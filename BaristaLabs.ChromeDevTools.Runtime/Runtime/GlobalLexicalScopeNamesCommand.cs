namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all let, const and class variables from global scope.
    /// </summary>
    public sealed class GlobalLexicalScopeNamesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.globalLexicalScopeNames";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Specifies in which execution context to lookup global scope variables.
        /// </summary>
        [JsonProperty("executionContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ExecutionContextId
        {
            get;
            set;
        }
    }

    public sealed class GlobalLexicalScopeNamesCommandResponse : ICommandResponse<GlobalLexicalScopeNamesCommand>
    {
        /// <summary>
        /// Gets or sets the names
        /// </summary>
        [JsonProperty("names")]
        public string[] Names
        {
            get;
            set;
        }
    }
}