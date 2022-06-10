namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets a sink to be used when the web page requests the browser to choose a
    /// sink via Presentation API, Remote Playback API, or Cast SDK.
    /// </summary>
    public sealed class SetSinkToUseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Cast.setSinkToUse";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the sinkName
        /// </summary>
        [JsonProperty("sinkName")]
        public string SinkName
        {
            get;
            set;
        }
    }

    public sealed class SetSinkToUseCommandResponse : ICommandResponse<SetSinkToUseCommand>
    {
    }
}