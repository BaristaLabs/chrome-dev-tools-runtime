namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code coverage may be incomplete. Enabling prevents running optimized code and resets execution counters.
    /// </summary>
    public sealed class StartPreciseCoverageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.startPreciseCoverage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StartPreciseCoverageCommandResponse : ICommandResponse<StartPreciseCoverageCommand>
    {
    }
}