namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Invoke custom browser commands used by telemetry.
    /// </summary>
    public sealed class ExecuteBrowserCommandCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.executeBrowserCommand";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the commandId
        /// </summary>
        [JsonProperty("commandId")]
        public BrowserCommandId CommandId
        {
            get;
            set;
        }
    }

    public sealed class ExecuteBrowserCommandCommandResponse : ICommandResponse<ExecuteBrowserCommandCommand>
    {
    }
}