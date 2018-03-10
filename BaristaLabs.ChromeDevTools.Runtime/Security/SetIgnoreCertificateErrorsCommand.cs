namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable/disable whether all certificate errors should be ignored.
    /// </summary>
    public sealed class SetIgnoreCertificateErrorsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Security.setIgnoreCertificateErrors";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If true, all certificate errors will be ignored.
        /// </summary>
        [JsonProperty("ignore")]
        public bool Ignore
        {
            get;
            set;
        }
    }

    public sealed class SetIgnoreCertificateErrorsCommandResponse : ICommandResponse<SetIgnoreCertificateErrorsCommand>
    {
    }
}