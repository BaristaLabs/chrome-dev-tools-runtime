namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Toggles monitoring of XMLHttpRequest. If &lt;code&gt;true&lt;/code&gt;, console will receive messages upon each XHR issued.
    /// </summary>
    public sealed class SetMonitoringXHREnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setMonitoringXHREnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Monitoring enabled state.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetMonitoringXHREnabledCommandResponse : ICommandResponse<SetMonitoringXHREnabledCommand>
    {
    }
}