namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Scope description.
    /// </summary>
    public sealed class Scope
    {
        /// <summary>
        /// Scope type.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// Object representing the scope. For &lt;code&gt;global&lt;/code&gt; and &lt;code&gt;with&lt;/code&gt; scopes it represents the actual object; for the rest of the scopes, it is artificial transient object enumerating scope variables as its properties.
        ///</summary>
        [JsonProperty("object")]
        public Runtime.RemoteObject Object
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Location in the source code where scope starts
        ///</summary>
        [JsonProperty("startLocation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location StartLocation
        {
            get;
            set;
        }
        /// <summary>
        /// Location in the source code where scope ends
        ///</summary>
        [JsonProperty("endLocation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location EndLocation
        {
            get;
            set;
        }
    }
}