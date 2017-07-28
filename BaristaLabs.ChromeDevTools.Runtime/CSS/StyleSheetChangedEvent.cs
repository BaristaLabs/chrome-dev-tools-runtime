namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired whenever a stylesheet is changed as a result of the client operation.
    /// </summary>
    public sealed class StyleSheetChangedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    }
}