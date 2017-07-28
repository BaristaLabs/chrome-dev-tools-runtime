namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Stylesheet type: &quot;injected&quot; for stylesheets injected via extension, &quot;user-agent&quot; for user-agent stylesheets, &quot;inspector&quot; for stylesheets created by the inspector (i.e. those holding the &quot;via inspector&quot; rules), &quot;regular&quot; for regular stylesheets.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StyleSheetOrigin
    {
        [EnumMember(Value = "injected")]
        Injected,
        [EnumMember(Value = "user-agent")]
        UserAgent,
        [EnumMember(Value = "inspector")]
        Inspector,
        [EnumMember(Value = "regular")]
        Regular,
    }
}