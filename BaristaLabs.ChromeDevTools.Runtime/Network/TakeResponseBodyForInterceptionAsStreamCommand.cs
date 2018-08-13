namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns a handle to the stream representing the response body. Note that after this command,
    /// the intercepted request can't be continued as is -- you either need to cancel it or to provide
    /// the response body. The stream only supports sequential read, IO.read will fail if the position
    /// is specified.
    /// </summary>
    public sealed class TakeResponseBodyForInterceptionAsStreamCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.takeResponseBodyForInterceptionAsStream";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the interceptionId
        /// </summary>
        [JsonProperty("interceptionId")]
        public string InterceptionId
        {
            get;
            set;
        }
    }

    public sealed class TakeResponseBodyForInterceptionAsStreamCommandResponse : ICommandResponse<TakeResponseBodyForInterceptionAsStreamCommand>
    {
        /// <summary>
        /// Gets or sets the stream
        /// </summary>
        [JsonProperty("stream")]
        public string Stream
        {
            get;
            set;
        }
    }
}