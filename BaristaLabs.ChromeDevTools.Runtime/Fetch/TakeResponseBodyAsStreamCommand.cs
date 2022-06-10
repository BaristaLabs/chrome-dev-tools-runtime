namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns a handle to the stream representing the response body.
    /// The request must be paused in the HeadersReceived stage.
    /// Note that after this command the request can't be continued
    /// as is -- client either needs to cancel it or to provide the
    /// response body.
    /// The stream only supports sequential read, IO.read will fail if the position
    /// is specified.
    /// This method is mutually exclusive with getResponseBody.
    /// Calling other methods that affect the request or disabling fetch
    /// domain before body is received results in an undefined behavior.
    /// </summary>
    public sealed class TakeResponseBodyAsStreamCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Fetch.takeResponseBodyAsStream";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the requestId
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    }

    public sealed class TakeResponseBodyAsStreamCommandResponse : ICommandResponse<TakeResponseBodyAsStreamCommand>
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