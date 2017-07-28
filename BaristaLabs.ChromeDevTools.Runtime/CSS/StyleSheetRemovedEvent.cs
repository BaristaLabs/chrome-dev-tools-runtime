namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired whenever an active document stylesheet is removed.
    /// </summary>
    public sealed class StyleSheetRemovedEvent : IEvent
    {
        /// <summary>
        /// Identifier of the removed stylesheet.
        /// </summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    }
}