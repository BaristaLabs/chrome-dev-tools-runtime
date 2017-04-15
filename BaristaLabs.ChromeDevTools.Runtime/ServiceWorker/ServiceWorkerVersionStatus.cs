namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceWorkerVersionStatus
    {
    
        [EnumMember(Value = "new")]
        New,
    
        [EnumMember(Value = "installing")]
        Installing,
    
        [EnumMember(Value = "installed")]
        Installed,
    
        [EnumMember(Value = "activating")]
        Activating,
    
        [EnumMember(Value = "activated")]
        Activated,
    
        [EnumMember(Value = "redundant")]
        Redundant,
    
    }
}