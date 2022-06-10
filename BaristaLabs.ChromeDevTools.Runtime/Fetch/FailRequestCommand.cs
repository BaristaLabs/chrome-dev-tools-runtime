namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Causes the request to fail with specified reason.
    /// </summary>
    public sealed class FailRequestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Fetch.failRequest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// An id the client received in requestPaused event.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// Causes the request to fail with the given reason.
        /// </summary>
        [JsonProperty("errorReason")]
        public Network.ErrorReason ErrorReason
        {
            get;
            set;
        }
    }

    public sealed class FailRequestCommandResponse : ICommandResponse<FailRequestCommand>
    {
    }
}