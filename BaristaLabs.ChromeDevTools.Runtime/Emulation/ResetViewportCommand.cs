namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resets the visible area of the page to the original viewport, undoing any effects of the &lt;code&gt;forceViewport&lt;/code&gt; command.
    /// </summary>
    public sealed class ResetViewportCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.resetViewport";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ResetViewportCommandResponse : ICommandResponse<ResetViewportCommand>
    {
    }
}