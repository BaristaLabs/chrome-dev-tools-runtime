namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Adds the specified target to the list of targets that will be monitored for any related target
    /// creation (such as child frames, child workers and new versions of service worker) and reported
    /// through `attachedToTarget`. The specified target is also auto-attached.
    /// This cancels the effect of any previous `setAutoAttach` and is also cancelled by subsequent
    /// `setAutoAttach`. Only available at the Browser target.
    /// </summary>
    public sealed class AutoAttachRelatedCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.autoAttachRelated";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to pause new targets when attaching to them. Use `Runtime.runIfWaitingForDebugger`
        /// to run paused targets.
        /// </summary>
        [JsonProperty("waitForDebuggerOnStart")]
        public bool WaitForDebuggerOnStart
        {
            get;
            set;
        }
    }

    public sealed class AutoAttachRelatedCommandResponse : ICommandResponse<AutoAttachRelatedCommand>
    {
    }
}