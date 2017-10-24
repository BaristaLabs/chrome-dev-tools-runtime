namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Brings page to front (activates tab).
    /// </summary>
    public sealed class BringToFrontCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.bringToFront";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class BringToFrontCommandResponse : ICommandResponse<BringToFrontCommand>
    {
    }
}