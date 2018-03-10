namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Crashes renderer on the IO thread, generates minidumps.
    /// </summary>
    public sealed class CrashCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.crash";
        
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