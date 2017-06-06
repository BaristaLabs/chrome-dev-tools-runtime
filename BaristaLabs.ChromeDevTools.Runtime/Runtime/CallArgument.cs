namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents function call argument. Either remote object id <code>objectId</code>, primitive <code>value</code>, unserializable primitive value or neither of (for undefined) them should be specified.
    /// </summary>
    public sealed class CallArgument
    {
    
        /// <summary>
        /// Primitive value.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Primitive value which can not be JSON-stringified.
        ///</summary>
        [JsonProperty("unserializableValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public UnserializableValue? UnserializableValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// Remote object handle.
        ///</summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
    
    }
}