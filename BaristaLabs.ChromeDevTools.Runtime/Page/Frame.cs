namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about the Frame on the page.
    /// </summary>
    public sealed class Frame
    {
        /// <summary>
        /// Frame unique identifier.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// Parent frame identifier.
        ///</summary>
        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParentId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the loader associated with this frame.
        ///</summary>
        [JsonProperty("loaderId")]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// Frame's name as specified in the tag.
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Frame document's URL without fragment.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Frame document's URL fragment including the '#'.
        ///</summary>
        [JsonProperty("urlFragment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlFragment
        {
            get;
            set;
        }
        /// <summary>
        /// Frame document's registered domain, taking the public suffixes list into account.
        /// Extracted from the Frame's url.
        /// Example URLs: http://www.google.com/file.html -> "google.com"
        ///               http://a.b.co.uk/file.html      -> "b.co.uk"
        ///</summary>
        [JsonProperty("domainAndRegistry")]
        public string DomainAndRegistry
        {
            get;
            set;
        }
        /// <summary>
        /// Frame document's security origin.
        ///</summary>
        [JsonProperty("securityOrigin")]
        public string SecurityOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Frame document's mimeType as determined by the browser.
        ///</summary>
        [JsonProperty("mimeType")]
        public string MimeType
        {
            get;
            set;
        }
        /// <summary>
        /// If the frame failed to load, this contains the URL that could not be loaded. Note that unlike url above, this URL may contain a fragment.
        ///</summary>
        [JsonProperty("unreachableUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UnreachableUrl
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates whether this frame was tagged as an ad and why.
        ///</summary>
        [JsonProperty("adFrameStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdFrameStatus AdFrameStatus
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates whether the main document is a secure context and explains why that is the case.
        ///</summary>
        [JsonProperty("secureContextType")]
        public SecureContextType SecureContextType
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates whether this is a cross origin isolated context.
        ///</summary>
        [JsonProperty("crossOriginIsolatedContextType")]
        public CrossOriginIsolatedContextType CrossOriginIsolatedContextType
        {
            get;
            set;
        }
        /// <summary>
        /// Indicated which gated APIs / features are available.
        ///</summary>
        [JsonProperty("gatedAPIFeatures")]
        public GatedAPIFeatures[] GatedAPIFeatures
        {
            get;
            set;
        }
    }
}