namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cookie which was not stored from a response with the corresponding reason.
    /// </summary>
    public sealed class BlockedSetCookieWithReason
    {
        /// <summary>
        /// The reason(s) this cookie was blocked.
        ///</summary>
        [JsonProperty("blockedReasons")]
        public SetCookieBlockedReason[] BlockedReasons
        {
            get;
            set;
        }
        /// <summary>
        /// The string representing this individual cookie as it would appear in the header.
        /// This is not the entire "cookie" or "set-cookie" header which could have multiple cookies.
        ///</summary>
        [JsonProperty("cookieLine")]
        public string CookieLine
        {
            get;
            set;
        }
        /// <summary>
        /// The cookie object which represents the cookie which was not stored. It is optional because
        /// sometimes complete cookie information is not available, such as in the case of parsing
        /// errors.
        ///</summary>
        [JsonProperty("cookie", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Cookie Cookie
        {
            get;
            set;
        }
    }
}