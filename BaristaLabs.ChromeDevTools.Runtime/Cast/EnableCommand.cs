namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts observing for sinks that can be used for tab mirroring, and if set,
    /// sinks compatible with |presentationUrl| as well. When sinks are found, a
    /// |sinksUpdated| event is fired.
    /// Also starts observing for issue messages. When an issue is added or removed,
    /// an |issueUpdated| event is fired.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Cast.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the presentationUrl
        /// </summary>
        [JsonProperty("presentationUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PresentationUrl
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}