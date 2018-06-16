namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the command line switches for the browser process if, and only if
    /// --enable-automation is on the commandline.
    /// </summary>
    public sealed class GetBrowserCommandLineCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.getBrowserCommandLine";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetBrowserCommandLineCommandResponse : ICommandResponse<GetBrowserCommandLineCommand>
    {
        /// <summary>
        /// Commandline parameters
        ///</summary>
        [JsonProperty("arguments")]
        public string[] Arguments
        {
            get;
            set;
        }
    }
}