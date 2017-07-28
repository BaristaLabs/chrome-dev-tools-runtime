namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for when an animation has been cancelled.
    /// </summary>
    public sealed class AnimationCanceledEvent : IEvent
    {
        /// <summary>
        /// Id of the animation that was cancelled.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    }
}