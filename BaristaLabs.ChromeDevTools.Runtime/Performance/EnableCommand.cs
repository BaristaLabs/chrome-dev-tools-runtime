namespace BaristaLabs.ChromeDevTools.Runtime.Performance
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable collecting and reporting metrics.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Performance.enable";
        
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