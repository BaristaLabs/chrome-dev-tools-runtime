namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Get Origin Trials on given frame.
    /// </summary>
    public sealed class GetOriginTrialsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getOriginTrials";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the frameId
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetOriginTrialsCommandResponse : ICommandResponse<GetOriginTrialsCommand>
    {
        /// <summary>
        /// Gets or sets the originTrials
        /// </summary>
        [JsonProperty("originTrials")]
        public OriginTrial[] OriginTrials
        {
            get;
            set;
        }
    }
}