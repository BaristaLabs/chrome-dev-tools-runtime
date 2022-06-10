namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the overridden device metrics.
    /// </summary>
    public sealed class ClearDeviceMetricsOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.clearDeviceMetricsOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearDeviceMetricsOverrideCommandResponse : ICommandResponse<ClearDeviceMetricsOverrideCommand>
    {
    }
}