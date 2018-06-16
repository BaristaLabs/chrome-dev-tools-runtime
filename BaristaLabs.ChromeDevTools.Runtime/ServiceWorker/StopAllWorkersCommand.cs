namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// StopAllWorkers
    /// </summary>
    public sealed class StopAllWorkersCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.stopAllWorkers";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopAllWorkersCommandResponse : ICommandResponse<StopAllWorkersCommand>
    {
    }
}