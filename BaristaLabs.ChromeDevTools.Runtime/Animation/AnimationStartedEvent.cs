namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for animation that has been started.
    /// </summary>
    public sealed class AnimationStartedEvent : IEvent
    {
        /// <summary>
        /// Animation that was started.
        /// </summary>
        [JsonProperty("animation")]
        public Animation Animation
        {
            get;
            set;
        }
    }
}