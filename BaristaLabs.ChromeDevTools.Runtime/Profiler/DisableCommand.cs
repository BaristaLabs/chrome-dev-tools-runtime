namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.disable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class DisableCommandResponse : ICommandResponse<DisableCommand>
    {
    }
}