namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SetSuspendedCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setSuspended";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether overlay should be suspended and not consume any resources until resumed.
        /// </summary>
        [JsonProperty("suspended")]
        public bool Suspended
        {
            get;
            set;
        }
    }

    public sealed class SetSuspendedCommandResponse : ICommandResponse<SetSuspendedCommand>
    {
    }
}