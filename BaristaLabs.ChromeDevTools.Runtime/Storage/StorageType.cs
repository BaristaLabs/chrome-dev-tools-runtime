namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of possible storage types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageType
    {
    
        [EnumMember(Value = "appcache")]
        Appcache,
    
        [EnumMember(Value = "cookies")]
        Cookies,
    
        [EnumMember(Value = "file_systems")]
        FileSystems,
    
        [EnumMember(Value = "indexeddb")]
        Indexeddb,
    
        [EnumMember(Value = "local_storage")]
        LocalStorage,
    
        [EnumMember(Value = "shader_cache")]
        ShaderCache,
    
        [EnumMember(Value = "websql")]
        Websql,
    
        [EnumMember(Value = "service_workers")]
        ServiceWorkers,
    
        [EnumMember(Value = "cache_storage")]
        CacheStorage,
    
        [EnumMember(Value = "all")]
        All,
    
    }
}