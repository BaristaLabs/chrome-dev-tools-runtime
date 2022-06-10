namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether the frame is a secure context and why it is the case.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SecureContextType
    {
        [EnumMember(Value = "Secure")]
        Secure,
        [EnumMember(Value = "SecureLocalhost")]
        SecureLocalhost,
        [EnumMember(Value = "InsecureScheme")]
        InsecureScheme,
        [EnumMember(Value = "InsecureAncestor")]
        InsecureAncestor,
    }
}