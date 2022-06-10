namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables the WebAudio domain and starts sending context lifetime events.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAudio.enable";
        
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