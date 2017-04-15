namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceWorkerVersionRunningStatus
    {
    
        [EnumMember(Value = "stopped")]
        Stopped,
    
        [EnumMember(Value = "starting")]
        Starting,
    
        [EnumMember(Value = "running")]
        Running,
    
        [EnumMember(Value = "stopping")]
        Stopping,
    
    }
}