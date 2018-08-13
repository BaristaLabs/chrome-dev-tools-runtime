namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tries to update the web lifecycle state of the page.
    /// It will transition the page to the given state according to:
    /// https://github.com/WICG/web-lifecycle/
    /// </summary>
    public sealed class SetWebLifecycleStateCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setWebLifecycleState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Target lifecycle state
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
    }

    public sealed class SetWebLifecycleStateCommandResponse : ICommandResponse<SetWebLifecycleStateCommand>
    {
    }
}