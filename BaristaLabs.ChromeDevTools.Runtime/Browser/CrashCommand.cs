namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Crashes browser on the main thread.
    /// </summary>
    public sealed class CrashCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.crash";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class CrashCommandResponse : ICommandResponse<CrashCommand>
    {
    }
}