namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
    /// </summary>
    public sealed class SetCookieCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setCookie";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Cookie name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie value.
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
        /// <summary>
        /// The request-URI to associate with the setting of the cookie. This value can affect the
        /// default domain, path, source port, and source scheme values of the created cookie.
        /// </summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie domain.
        /// </summary>
        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Domain
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie path.
        /// </summary>
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Path
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie is secure.
        /// </summary>
        [JsonProperty("secure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Secure
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie is http-only.
        /// </summary>
        [JsonProperty("httpOnly", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HttpOnly
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie SameSite type.
        /// </summary>
        [JsonProperty("sameSite", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CookieSameSite? SameSite
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie expiration date, session cookie if not set
        /// </summary>
        [JsonProperty("expires", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Expires
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie Priority type.
        /// </summary>
        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CookiePriority? Priority
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie is SameParty.
        /// </summary>
        [JsonProperty("sameParty", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SameParty
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie source scheme type.
        /// </summary>
        [JsonProperty("sourceScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CookieSourceScheme? SourceScheme
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
        /// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
        /// This is a temporary ability and it will be removed in the future.
        /// </summary>
        [JsonProperty("sourcePort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? SourcePort
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie partition key. The site of the top-level URL the browser was visiting at the start
        /// of the request to the endpoint that set the cookie.
        /// If not set, the cookie will be set as not partitioned.
        /// </summary>
        [JsonProperty("partitionKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PartitionKey
        {
            get;
            set;
        }
    }

    public sealed class SetCookieCommandResponse : ICommandResponse<SetCookieCommand>
    {
        /// <summary>
        /// Always set to true. If an error occurs, the response indicates protocol error.
        ///</summary>
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    }
}