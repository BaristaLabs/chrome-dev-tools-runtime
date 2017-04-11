namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Shadow root type.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class ShadowRootType
    {
        private string m_value;
        
        public ShadowRootType(string value)
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

    
        public static ShadowRootType UserAgent = new ShadowRootType("user-agent");
    
        public static ShadowRootType Open = new ShadowRootType("open");
    
        public static ShadowRootType Closed = new ShadowRootType("closed");
    
    }
}