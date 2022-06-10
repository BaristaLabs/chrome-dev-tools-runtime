namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cookie with was not sent with a request with the corresponding reason.
    /// </summary>
    public sealed class BlockedCookieWithReason
    {
        /// <summary>
        /// The reason(s) the cookie was blocked.
        ///</summary>
        [JsonProperty("blockedReasons")]
        public CookieBlockedReason[] BlockedReasons
        {
            get;
            set;
        }
        /// <summary>
        /// The cookie object representing the cookie which was not sent.
        ///</summary>
        [JsonProperty("cookie")]
        public Cookie Cookie
        {
            get;
            set;
        }
    }
}