namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}