namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AuthenticatorTransport
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticatorTransport
    {
        [EnumMember(Value = "usb")]
        Usb,
        [EnumMember(Value = "nfc")]
        Nfc,
        [EnumMember(Value = "ble")]
        Ble,
        [EnumMember(Value = "cable")]
        Cable,
        [EnumMember(Value = "internal")]
        Internal,
    }
}