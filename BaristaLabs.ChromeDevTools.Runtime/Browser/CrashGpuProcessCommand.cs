namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Crashes GPU process.
    /// </summary>
    public sealed class CrashGpuProcessCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.crashGpuProcess";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class CrashGpuProcessCommandResponse : ICommandResponse<CrashGpuProcessCommand>
    {
    }
}