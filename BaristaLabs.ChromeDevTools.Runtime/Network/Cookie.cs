namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Cookie object
    /// </summary>
    public sealed class Cookie
    {
        /// <summary>
        /// Cookie name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie value.
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie domain.
        ///</summary>
        [JsonProperty("domain")]
        public string Domain
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie path.
        ///</summary>
        [JsonProperty("path")]
        public string Path
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie expiration date as the number of seconds since the UNIX epoch.
        ///</summary>
        [JsonProperty("expires")]
        public double Expires
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie size.
        ///</summary>
        [JsonProperty("size")]
        public long Size
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie is http-only.
        ///</summary>
        [JsonProperty("httpOnly")]
        public bool HttpOnly
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie is secure.
        ///</summary>
        [JsonProperty("secure")]
        public bool Secure
        {
            get;
            set;
        }
        /// <summary>
        /// True in case of session cookie.
        ///</summary>
        [JsonProperty("session")]
        public bool Session
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie SameSite type.
        ///</summary>
        [JsonProperty("sameSite", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CookieSameSite? SameSite
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie Priority
        ///</summary>
        [JsonProperty("priority")]
        public CookiePriority Priority
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie is SameParty.
        ///</summary>
        [JsonProperty("sameParty")]
        public bool SameParty
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie source scheme type.
        ///</summary>
        [JsonProperty("sourceScheme")]
        public CookieSourceScheme SourceScheme
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
        /// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
        /// This is a temporary ability and it will be removed in the future.
        ///</summary>
        [JsonProperty("sourcePort")]
        public long SourcePort
        {
            get;
            set;
        }
        /// <summary>
        /// Cookie partition key. The site of the top-level URL the browser was visiting at the start
        /// of the request to the endpoint that set the cookie.
        ///</summary>
        [JsonProperty("partitionKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PartitionKey
        {
            get;
            set;
        }
        /// <summary>
        /// True if cookie partition key is opaque.
        ///</summary>
        [JsonProperty("partitionKeyOpaque", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? PartitionKeyOpaque
        {
            get;
            set;
        }
    }
}