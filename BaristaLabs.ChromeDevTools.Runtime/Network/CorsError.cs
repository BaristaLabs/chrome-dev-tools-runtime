namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The reason why request was blocked.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CorsError
    {
        [EnumMember(Value = "DisallowedByMode")]
        DisallowedByMode,
        [EnumMember(Value = "InvalidResponse")]
        InvalidResponse,
        [EnumMember(Value = "WildcardOriginNotAllowed")]
        WildcardOriginNotAllowed,
        [EnumMember(Value = "MissingAllowOriginHeader")]
        MissingAllowOriginHeader,
        [EnumMember(Value = "MultipleAllowOriginValues")]
        MultipleAllowOriginValues,
        [EnumMember(Value = "InvalidAllowOriginValue")]
        InvalidAllowOriginValue,
        [EnumMember(Value = "AllowOriginMismatch")]
        AllowOriginMismatch,
        [EnumMember(Value = "InvalidAllowCredentials")]
        InvalidAllowCredentials,
        [EnumMember(Value = "CorsDisabledScheme")]
        CorsDisabledScheme,
        [EnumMember(Value = "PreflightInvalidStatus")]
        PreflightInvalidStatus,
        [EnumMember(Value = "PreflightDisallowedRedirect")]
        PreflightDisallowedRedirect,
        [EnumMember(Value = "PreflightWildcardOriginNotAllowed")]
        PreflightWildcardOriginNotAllowed,
        [EnumMember(Value = "PreflightMissingAllowOriginHeader")]
        PreflightMissingAllowOriginHeader,
        [EnumMember(Value = "PreflightMultipleAllowOriginValues")]
        PreflightMultipleAllowOriginValues,
        [EnumMember(Value = "PreflightInvalidAllowOriginValue")]
        PreflightInvalidAllowOriginValue,
        [EnumMember(Value = "PreflightAllowOriginMismatch")]
        PreflightAllowOriginMismatch,
        [EnumMember(Value = "PreflightInvalidAllowCredentials")]
        PreflightInvalidAllowCredentials,
        [EnumMember(Value = "PreflightMissingAllowExternal")]
        PreflightMissingAllowExternal,
        [EnumMember(Value = "PreflightInvalidAllowExternal")]
        PreflightInvalidAllowExternal,
        [EnumMember(Value = "PreflightMissingAllowPrivateNetwork")]
        PreflightMissingAllowPrivateNetwork,
        [EnumMember(Value = "PreflightInvalidAllowPrivateNetwork")]
        PreflightInvalidAllowPrivateNetwork,
        [EnumMember(Value = "InvalidAllowMethodsPreflightResponse")]
        InvalidAllowMethodsPreflightResponse,
        [EnumMember(Value = "InvalidAllowHeadersPreflightResponse")]
        InvalidAllowHeadersPreflightResponse,
        [EnumMember(Value = "MethodDisallowedByPreflightResponse")]
        MethodDisallowedByPreflightResponse,
        [EnumMember(Value = "HeaderDisallowedByPreflightResponse")]
        HeaderDisallowedByPreflightResponse,
        [EnumMember(Value = "RedirectContainsCredentials")]
        RedirectContainsCredentials,
        [EnumMember(Value = "InsecurePrivateNetwork")]
        InsecurePrivateNetwork,
        [EnumMember(Value = "InvalidPrivateNetworkAccess")]
        InvalidPrivateNetworkAccess,
        [EnumMember(Value = "UnexpectedPrivateNetworkAccess")]
        UnexpectedPrivateNetworkAccess,
        [EnumMember(Value = "NoCorsRedirectModeNotFollow")]
        NoCorsRedirectModeNotFollow,
    }
}