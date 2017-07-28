namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Hides any highlight.
    /// </summary>
    public sealed class HideHighlightCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.hideHighlight";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class HideHighlightCommandResponse : ICommandResponse<HideHighlightCommand>
    {
    }
}