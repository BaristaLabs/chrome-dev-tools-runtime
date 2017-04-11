namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// The reason why request was blocked.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class BlockedReason
    {
        private string m_value;
        
        public BlockedReason(string value)
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

    
        public static BlockedReason Csp = new BlockedReason("csp");
    
        public static BlockedReason MixedContent = new BlockedReason("mixed-content");
    
        public static BlockedReason Origin = new BlockedReason("origin");
    
        public static BlockedReason Inspector = new BlockedReason("inspector");
    
        public static BlockedReason SubresourceFilter = new BlockedReason("subresource-filter");
    
        public static BlockedReason Other = new BlockedReason("other");
    
    }
}