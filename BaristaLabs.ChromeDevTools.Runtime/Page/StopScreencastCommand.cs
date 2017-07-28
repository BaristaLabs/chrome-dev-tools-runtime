namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stops sending each frame in the &lt;code&gt;screencastFrame&lt;/code&gt;.
    /// </summary>
    public sealed class StopScreencastCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.stopScreencast";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopScreencastCommandResponse : ICommandResponse<StopScreencastCommand>
    {
    }
}