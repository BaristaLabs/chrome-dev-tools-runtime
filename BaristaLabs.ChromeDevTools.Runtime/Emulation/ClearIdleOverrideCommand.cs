namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears Idle state overrides.
    /// </summary>
    public sealed class ClearIdleOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.clearIdleOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearIdleOverrideCommandResponse : ICommandResponse<ClearIdleOverrideCommand>
    {
    }
}