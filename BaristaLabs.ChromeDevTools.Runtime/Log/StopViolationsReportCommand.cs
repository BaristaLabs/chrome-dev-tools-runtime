namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stop violation reporting.
    /// </summary>
    public sealed class StopViolationsReportCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Log.stopViolationsReport";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopViolationsReportCommandResponse : ICommandResponse<StopViolationsReportCommand>
    {
    }
}