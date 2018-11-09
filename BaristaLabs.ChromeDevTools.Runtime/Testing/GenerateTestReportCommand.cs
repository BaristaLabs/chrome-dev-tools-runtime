namespace BaristaLabs.ChromeDevTools.Runtime.Testing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Generates a report for testing.
    /// </summary>
    public sealed class GenerateTestReportCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Testing.generateTestReport";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Message to be displayed in the report.
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
        /// <summary>
        /// Specifies the endpoint group to deliver the report to.
        /// </summary>
        [JsonProperty("group", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Group
        {
            get;
            set;
        }
    }

    public sealed class GenerateTestReportCommandResponse : ICommandResponse<GenerateTestReportCommand>
    {
    }
}