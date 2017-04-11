namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enum of possible storage types.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class StorageType
    {
        private string m_value;
        
        public StorageType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

        public override bool Equals(object obj)
        {
            return m_value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return m_value.GetHashCode();
        }

    
        public static StorageType Appcache = new StorageType("appcache");
    
        public static StorageType Cookies = new StorageType("cookies");
    
        public static StorageType FileSystems = new StorageType("file_systems");
    
        public static StorageType Indexeddb = new StorageType("indexeddb");
    
        public static StorageType LocalStorage = new StorageType("local_storage");
    
        public static StorageType ShaderCache = new StorageType("shader_cache");
    
        public static StorageType Websql = new StorageType("websql");
    
        public static StorageType ServiceWorkers = new StorageType("service_workers");
    
        public static StorageType CacheStorage = new StorageType("cache_storage");
    
        public static StorageType All = new StorageType("all");
    
    }
}