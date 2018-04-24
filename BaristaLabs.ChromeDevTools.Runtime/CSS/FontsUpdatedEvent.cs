namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
    /// web font
    /// </summary>
    public sealed class FontsUpdatedEvent : IEvent
    {
        /// <summary>
        /// The web font that has loaded.
        /// </summary>
        [JsonProperty("font", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FontFace Font
        {
            get;
            set;
        }
    }
}