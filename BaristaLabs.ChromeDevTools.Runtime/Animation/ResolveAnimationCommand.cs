namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets the remote object of the Animation.
    /// </summary>
    public sealed class ResolveAnimationCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.resolveAnimation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Animation id.
        /// </summary>
        [JsonProperty("animationId")]
        public string AnimationId
        {
            get;
            set;
        }
    }

    public sealed class ResolveAnimationCommandResponse : ICommandResponse<ResolveAnimationCommand>
    {
        /// <summary>
        /// Corresponding remote object.
        ///</summary>
        [JsonProperty("remoteObject")]
        public Runtime.RemoteObject RemoteObject
        {
            get;
            set;
        }
    }
}