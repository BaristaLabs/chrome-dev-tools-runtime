namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of possible property types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXValueType
    {
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "tristate")]
        Tristate,
        [EnumMember(Value = "booleanOrUndefined")]
        BooleanOrUndefined,
        [EnumMember(Value = "idref")]
        Idref,
        [EnumMember(Value = "idrefList")]
        IdrefList,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "node")]
        Node,
        [EnumMember(Value = "nodeList")]
        NodeList,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "computedString")]
        ComputedString,
        [EnumMember(Value = "token")]
        Token,
        [EnumMember(Value = "tokenList")]
        TokenList,
        [EnumMember(Value = "domRelation")]
        DomRelation,
        [EnumMember(Value = "role")]
        Role,
        [EnumMember(Value = "internalRole")]
        InternalRole,
        [EnumMember(Value = "valueUndefined")]
        ValueUndefined,
    }
}