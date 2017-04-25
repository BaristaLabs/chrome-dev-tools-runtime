namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows executing optimized code.
    /// </summary>
    public sealed class StopPreciseCoverageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.stopPreciseCoverage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopPreciseCoverageCommandResponse : ICommandResponse<StopPreciseCoverageCommand>
    {
    }
}