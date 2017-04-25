namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using Newtonsoft.Json;

    /// <summary>
    /// start violation reporting.
    /// </summary>
    public sealed class StartViolationsReportCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Log.startViolationsReport";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Configuration for violations.
        /// </summary>
        [JsonProperty("config")]
        public ViolationSetting[] Config
        {
            get;
            set;
        }
    }

    public sealed class StartViolationsReportCommandResponse : ICommandResponse<StartViolationsReportCommand>
    {
    }
}