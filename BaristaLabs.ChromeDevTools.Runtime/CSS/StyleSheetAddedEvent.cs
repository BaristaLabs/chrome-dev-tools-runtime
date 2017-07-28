namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired whenever an active document stylesheet is added.
    /// </summary>
    public sealed class StyleSheetAddedEvent : IEvent
    {
        /// <summary>
        /// Added stylesheet metainfo.
        /// </summary>
        [JsonProperty("header")]
        public CSSStyleSheetHeader Header
        {
            get;
            set;
        }
    }
}