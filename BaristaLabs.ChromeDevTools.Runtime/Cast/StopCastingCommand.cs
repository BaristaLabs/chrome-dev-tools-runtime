namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stops the active Cast session on the sink.
    /// </summary>
    public sealed class StopCastingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Cast.stopCasting";
        
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

    public sealed class StopCastingCommandResponse : ICommandResponse<StopCastingCommand>
    {
    }
}