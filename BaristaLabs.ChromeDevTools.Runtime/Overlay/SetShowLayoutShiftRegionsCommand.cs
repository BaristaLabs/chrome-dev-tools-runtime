namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that backend shows layout shift regions
    /// </summary>
    public sealed class SetShowLayoutShiftRegionsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowLayoutShiftRegions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// True for showing layout shift regions
        /// </summary>
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    }

    public sealed class SetShowLayoutShiftRegionsCommandResponse : ICommandResponse<SetShowLayoutShiftRegionsCommand>
    {
    }
}