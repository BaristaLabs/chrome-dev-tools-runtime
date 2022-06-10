namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using Newtonsoft.Json;

    /// <summary>
    /// Previously buffered events would be reported before method returns.
    /// See also: timelineEventAdded
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "PerformanceTimeline.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The types of event to report, as specified in
        /// https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
        /// The specified filter overrides any previous filters, passing empty
        /// filter disables recording.
        /// Note that not all types exposed to the web platform are currently supported.
        /// </summary>
        [JsonProperty("eventTypes")]
        public string[] EventTypes
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}