namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class DomStorageItemUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the storageId
        /// </summary>
        
        [JsonProperty("storageId")]
        public StorageId StorageId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the key
        /// </summary>
        
        [JsonProperty("key")]
        public string Key
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the oldValue
        /// </summary>
        
        [JsonProperty("oldValue")]
        public string OldValue
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the newValue
        /// </summary>
        
        [JsonProperty("newValue")]
        public string NewValue
        {
            get;
            set;
        }
    
    }
}