namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests backend to produce compilation cache for the specified scripts.
    /// `scripts` are appeneded to the list of scripts for which the cache
    /// would be produced. The list may be reset during page navigation.
    /// When script with a matching URL is encountered, the cache is optionally
    /// produced upon backend discretion, based on internal heuristics.
    /// See also: `Page.compilationCacheProduced`.
    /// </summary>
    public sealed class ProduceCompilationCacheCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.produceCompilationCache";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the scripts
        /// </summary>
        [JsonProperty("scripts")]
        public CompilationCacheParams[] Scripts
        {
            get;
            set;
        }
    }

    public sealed class ProduceCompilationCacheCommandResponse : ICommandResponse<ProduceCompilationCacheCommand>
    {
    }
}