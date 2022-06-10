namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Types of reasons why a cookie may not be stored from a response.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SetCookieBlockedReason
    {
        [EnumMember(Value = "SecureOnly")]
        SecureOnly,
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
        [EnumMember(Value = "SyntaxError")]
        SyntaxError,
        [EnumMember(Value = "SchemeNotSupported")]
        SchemeNotSupported,
        [EnumMember(Value = "OverwriteSecure")]
        OverwriteSecure,
        [EnumMember(Value = "InvalidDomain")]
        InvalidDomain,
        [EnumMember(Value = "InvalidPrefix")]
        InvalidPrefix,
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
        [EnumMember(Value = "SamePartyConflictsWithOtherAttributes")]
        SamePartyConflictsWithOtherAttributes,
        [EnumMember(Value = "NameValuePairExceedsMaxSize")]
        NameValuePairExceedsMaxSize,
    }
}