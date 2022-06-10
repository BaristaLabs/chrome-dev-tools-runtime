namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Stages of the request to handle. Request will intercept before the request is
    /// sent. Response will intercept after the response is received (but before response
    /// body is received).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequestStage
    {
        [EnumMember(Value = "Request")]
        Request,
        [EnumMember(Value = "Response")]
        Response,
    }
}