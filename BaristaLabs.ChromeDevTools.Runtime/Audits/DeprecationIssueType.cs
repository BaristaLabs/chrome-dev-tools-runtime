namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// DeprecationIssueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeprecationIssueType
    {
        [EnumMember(Value = "DeprecationExample")]
        DeprecationExample,
        [EnumMember(Value = "Untranslated")]
        Untranslated,
    }
}