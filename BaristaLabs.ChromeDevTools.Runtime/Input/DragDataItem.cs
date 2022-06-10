namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// DragDataItem
    /// </summary>
    public sealed class DragDataItem
    {
        /// <summary>
        /// Mime type of the dragged data.
        ///</summary>
        [JsonProperty("mimeType")]
        public string MimeType
        {
            get;
            set;
        }
        /// <summary>
        /// Depending of the value of `mimeType`, it contains the dragged link,
        /// text, HTML markup or any other data.
        ///</summary>
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
        /// <summary>
        /// Title associated with a link. Only valid when `mimeType` == "text/uri-list".
        ///</summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// Stores the base URL for the contained markup. Only valid when `mimeType`
        /// == "text/html".
        ///</summary>
        [JsonProperty("baseURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BaseURL
        {
            get;
            set;
        }
    }
}