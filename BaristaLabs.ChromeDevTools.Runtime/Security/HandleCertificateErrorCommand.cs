namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// Handles a certificate error that fired a certificateError event.
    /// </summary>
    public sealed class HandleCertificateErrorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Security.handleCertificateError";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The ID of the event.
        /// </summary>
        [JsonProperty("eventId")]
        public long EventId
        {
            get;
            set;
        }
        /// <summary>
        /// The action to take on the certificate error.
        /// </summary>
        [JsonProperty("action")]
        public CertificateErrorAction Action
        {
            get;
            set;
        }
    }

    public sealed class HandleCertificateErrorCommandResponse : ICommandResponse<HandleCertificateErrorCommand>
    {
    }
}