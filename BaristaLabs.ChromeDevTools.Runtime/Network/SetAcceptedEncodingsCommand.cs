namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
    /// </summary>
    public sealed class SetAcceptedEncodingsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setAcceptedEncodings";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// List of accepted content encodings.
        /// </summary>
        [JsonProperty("encodings")]
        public ContentEncoding[] Encodings
        {
            get;
            set;
        }
    }

    public sealed class SetAcceptedEncodingsCommandResponse : ICommandResponse<SetAcceptedEncodingsCommand>
    {
    }
}