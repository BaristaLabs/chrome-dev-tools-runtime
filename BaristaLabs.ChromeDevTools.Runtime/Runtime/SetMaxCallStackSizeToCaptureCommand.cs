namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetMaxCallStackSizeToCapture
    /// </summary>
    public sealed class SetMaxCallStackSizeToCaptureCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.setMaxCallStackSizeToCapture";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        [JsonProperty("size")]
        public long Size
        {
            get;
            set;
        }
    }

    public sealed class SetMaxCallStackSizeToCaptureCommandResponse : ICommandResponse<SetMaxCallStackSizeToCaptureCommand>
    {
    }
}