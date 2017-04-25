namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Proceed: allow the navigation; Cancel: cancel the navigation; CancelAndIgnore: cancels the navigation and makes the requester of the navigation acts like the request was never made.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NavigationResponse
    {
        [EnumMember(Value = "Proceed")]
        Proceed,
        [EnumMember(Value = "Cancel")]
        Cancel,
        [EnumMember(Value = "CancelAndIgnore")]
        CancelAndIgnore,
    }
}