namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Object private field descriptor.
    /// </summary>
    public sealed class PrivatePropertyDescriptor
    {
        /// <summary>
        /// Private property name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// The value associated with the private property.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RemoteObject Value
        {
            get;
            set;
        }
        /// <summary>
        /// A function which serves as a getter for the private property,
        /// or `undefined` if there is no getter (accessor descriptors only).
        ///</summary>
        [JsonProperty("get", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RemoteObject Get
        {
            get;
            set;
        }
        /// <summary>
        /// A function which serves as a setter for the private property,
        /// or `undefined` if there is no setter (accessor descriptors only).
        ///</summary>
        [JsonProperty("set", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RemoteObject Set
        {
            get;
            set;
        }
    }
}