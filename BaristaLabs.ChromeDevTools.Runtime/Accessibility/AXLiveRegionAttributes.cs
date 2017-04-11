namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Attributes which apply to nodes in live regions.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXLiveRegionAttributes
    {
        private string m_value;
        
        public AXLiveRegionAttributes(string value)
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

    
        public static AXLiveRegionAttributes Live = new AXLiveRegionAttributes("live");
    
        public static AXLiveRegionAttributes Atomic = new AXLiveRegionAttributes("atomic");
    
        public static AXLiveRegionAttributes Relevant = new AXLiveRegionAttributes("relevant");
    
        public static AXLiveRegionAttributes Busy = new AXLiveRegionAttributes("busy");
    
        public static AXLiveRegionAttributes Root = new AXLiveRegionAttributes("root");
    
    }
}