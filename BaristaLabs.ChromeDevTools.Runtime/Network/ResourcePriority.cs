namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Loading priority of a resource request.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class ResourcePriority
    {
        private string m_value;
        
        public ResourcePriority(string value)
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

    
        public static ResourcePriority VeryLow = new ResourcePriority("VeryLow");
    
        public static ResourcePriority Low = new ResourcePriority("Low");
    
        public static ResourcePriority Medium = new ResourcePriority("Medium");
    
        public static ResourcePriority High = new ResourcePriority("High");
    
        public static ResourcePriority VeryHigh = new ResourcePriority("VeryHigh");
    
    }
}