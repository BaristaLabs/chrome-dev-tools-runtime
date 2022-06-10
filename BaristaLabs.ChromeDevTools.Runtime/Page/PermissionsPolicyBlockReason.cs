namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Reason for a permissions policy feature to be disabled.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionsPolicyBlockReason
    {
        [EnumMember(Value = "Header")]
        Header,
        [EnumMember(Value = "IframeAttribute")]
        IframeAttribute,
        [EnumMember(Value = "InFencedFrameTree")]
        InFencedFrameTree,
    }
}