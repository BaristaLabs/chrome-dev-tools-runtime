namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Collect coverage data for the current isolate. The coverage data may be incomplete due to garbage collection.
    /// </summary>
    public sealed class GetBestEffortCoverageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.getBestEffortCoverage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetBestEffortCoverageCommandResponse : ICommandResponse<GetBestEffortCoverageCommand>
    {
    
        
        /// <summary>
        /// Coverage data for the current isolate.
        ///</summary>
        
        [JsonProperty("result")]
        public ScriptCoverage[] Result
        {
            get;
            set;
        }
    
    }
}