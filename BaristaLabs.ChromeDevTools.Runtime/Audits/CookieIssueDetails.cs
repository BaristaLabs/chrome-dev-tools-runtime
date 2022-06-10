namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This information is currently necessary, as the front-end has a difficult
    /// time finding a specific cookie. With this, we can convey specific error
    /// information without the cookie.
    /// </summary>
    public sealed class CookieIssueDetails
    {
        /// <summary>
        /// If AffectedCookie is not set then rawCookieLine contains the raw
        /// Set-Cookie header string. This hints at a problem where the
        /// cookie line is syntactically or semantically malformed in a way
        /// that no valid cookie could be created.
        ///</summary>
        [JsonProperty("cookie", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedCookie Cookie
        {
            get;
            set;
        }
        /// <summary>
        /// rawCookieLine
        ///</summary>
        [JsonProperty("rawCookieLine", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RawCookieLine
        {
            get;
            set;
        }
        /// <summary>
        /// cookieWarningReasons
        ///</summary>
        [JsonProperty("cookieWarningReasons")]
        public CookieWarningReason[] CookieWarningReasons
        {
            get;
            set;
        }
        /// <summary>
        /// cookieExclusionReasons
        ///</summary>
        [JsonProperty("cookieExclusionReasons")]
        public CookieExclusionReason[] CookieExclusionReasons
        {
            get;
            set;
        }
        /// <summary>
        /// Optionally identifies the site-for-cookies and the cookie url, which
        /// may be used by the front-end as additional context.
        ///</summary>
        [JsonProperty("operation")]
        public CookieOperation Operation
        {
            get;
            set;
        }
        /// <summary>
        /// siteForCookies
        ///</summary>
        [JsonProperty("siteForCookies", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SiteForCookies
        {
            get;
            set;
        }
        /// <summary>
        /// cookieUrl
        ///</summary>
        [JsonProperty("cookieUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CookieUrl
        {
            get;
            set;
        }
        /// <summary>
        /// request
        ///</summary>
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedRequest Request
        {
            get;
            set;
        }
    }
}