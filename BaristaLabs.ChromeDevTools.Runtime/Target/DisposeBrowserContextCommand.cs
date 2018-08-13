namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes a BrowserContext. All the belonging pages will be closed without calling their
    /// beforeunload hooks.
    /// </summary>
    public sealed class DisposeBrowserContextCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.disposeBrowserContext";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the browserContextId
        /// </summary>
        [JsonProperty("browserContextId")]
        public string BrowserContextId
        {
            get;
            set;
        }
    }

    public sealed class DisposeBrowserContextCommandResponse : ICommandResponse<DisposeBrowserContextCommand>
    {
    }
}