namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Ctap2Version
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Ctap2Version
    {
        [EnumMember(Value = "ctap2_0")]
        Ctap20,
        [EnumMember(Value = "ctap2_1")]
        Ctap21,
    }
}