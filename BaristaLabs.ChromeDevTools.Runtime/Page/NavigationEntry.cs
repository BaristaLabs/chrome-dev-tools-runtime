namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Navigation history entry.
    /// </summary>
    public sealed class NavigationEntry
    {
    
        /// <summary>
        /// Unique id of the navigation history entry.
        ///</summary>
        [JsonProperty("id")]
        public long Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// URL of the navigation history entry.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Title of the navigation history entry.
        ///</summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }
    
    }
}