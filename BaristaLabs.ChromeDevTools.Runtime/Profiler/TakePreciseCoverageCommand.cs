namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Collect coverage data for the current isolate, and resets execution counters. Precise code coverage needs to have started.
    /// </summary>
    public sealed class TakePreciseCoverageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.takePreciseCoverage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class TakePreciseCoverageCommandResponse : ICommandResponse<TakePreciseCoverageCommand>
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