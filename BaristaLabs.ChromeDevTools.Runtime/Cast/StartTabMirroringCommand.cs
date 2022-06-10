namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts mirroring the tab to the sink.
    /// </summary>
    public sealed class StartTabMirroringCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Cast.startTabMirroring";
        
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

    public sealed class StartTabMirroringCommandResponse : ICommandResponse<StartTabMirroringCommand>
    {
    }
}