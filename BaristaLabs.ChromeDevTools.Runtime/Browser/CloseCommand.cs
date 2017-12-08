namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Close browser gracefully.
    /// </summary>
    public sealed class CloseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.close";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class CloseCommandResponse : ICommandResponse<CloseCommand>
    {
    }
}