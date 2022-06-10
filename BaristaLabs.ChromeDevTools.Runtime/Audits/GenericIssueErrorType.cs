namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// GenericIssueErrorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenericIssueErrorType
    {
        [EnumMember(Value = "CrossOriginPortalPostMessageError")]
        CrossOriginPortalPostMessageError,
    }
}