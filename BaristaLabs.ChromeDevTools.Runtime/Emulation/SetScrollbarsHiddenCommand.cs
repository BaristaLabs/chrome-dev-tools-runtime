namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetScrollbarsHidden
    /// </summary>
    public sealed class SetScrollbarsHiddenCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setScrollbarsHidden";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether scrollbars should be always hidden.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden
        {
            get;
            set;
        }
    }

    public sealed class SetScrollbarsHiddenCommandResponse : ICommandResponse<SetScrollbarsHiddenCommand>
    {
    }
}