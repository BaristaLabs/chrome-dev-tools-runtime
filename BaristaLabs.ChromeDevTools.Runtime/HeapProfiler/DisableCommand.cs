namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.disable";
        
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