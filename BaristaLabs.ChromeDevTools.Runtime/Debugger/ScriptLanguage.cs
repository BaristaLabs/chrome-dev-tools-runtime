namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of possible script languages.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScriptLanguage
    {
        [EnumMember(Value = "JavaScript")]
        JavaScript,
        [EnumMember(Value = "WebAssembly")]
        WebAssembly,
    }
}