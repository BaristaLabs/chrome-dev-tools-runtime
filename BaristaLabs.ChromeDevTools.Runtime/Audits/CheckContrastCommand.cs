namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Runs the contrast check for the target page. Found issues are reported
    /// using Audits.issueAdded event.
    /// </summary>
    public sealed class CheckContrastCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Audits.checkContrast";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to report WCAG AAA level issues. Default is false.
        /// </summary>
        [JsonProperty("reportAAA", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ReportAAA
        {
            get;
            set;
        }
    }

    public sealed class CheckContrastCommandResponse : ICommandResponse<CheckContrastCommand>
    {
    }
}