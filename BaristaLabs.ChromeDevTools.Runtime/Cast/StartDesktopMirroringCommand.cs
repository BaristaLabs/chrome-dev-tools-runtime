namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts mirroring the desktop to the sink.
    /// </summary>
    public sealed class StartDesktopMirroringCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Cast.startDesktopMirroring";
        
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

    public sealed class StartDesktopMirroringCommandResponse : ICommandResponse<StartDesktopMirroringCommand>
    {
    }
}