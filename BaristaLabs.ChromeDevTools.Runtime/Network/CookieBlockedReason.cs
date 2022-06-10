namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Types of reasons why a cookie may not be sent with a request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CookieBlockedReason
    {
        [EnumMember(Value = "SecureOnly")]
        SecureOnly,
        [EnumMember(Value = "NotOnPath")]
        NotOnPath,
        [EnumMember(Value = "DomainMismatch")]
        DomainMismatch,
        [EnumMember(Value = "SameSiteStrict")]
        SameSiteStrict,
        [EnumMember(Value = "SameSiteLax")]
        SameSiteLax,
        [EnumMember(Value = "SameSiteUnspecifiedTreatedAsLax")]
        SameSiteUnspecifiedTreatedAsLax,
        [EnumMember(Value = "SameSiteNoneInsecure")]
        SameSiteNoneInsecure,
        [EnumMember(Value = "UserPreferences")]
        UserPreferences,
        [EnumMember(Value = "UnknownError")]
        UnknownError,
        [EnumMember(Value = "SchemefulSameSiteStrict")]
        SchemefulSameSiteStrict,
        [EnumMember(Value = "SchemefulSameSiteLax")]
        SchemefulSameSiteLax,
        [EnumMember(Value = "SchemefulSameSiteUnspecifiedTreatedAsLax")]
        SchemefulSameSiteUnspecifiedTreatedAsLax,
        [EnumMember(Value = "SamePartyFromCrossPartyContext")]
        SamePartyFromCrossPartyContext,
        [EnumMember(Value = "NameValuePairExceedsMaxSize")]
        NameValuePairExceedsMaxSize,
    }
}