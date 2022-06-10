namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AuthenticatorProtocol
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticatorProtocol
    {
        [EnumMember(Value = "u2f")]
        U2f,
        [EnumMember(Value = "ctap2")]
        Ctap2,
    }
}