namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// The security level of a page or resource.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class SecurityState
    {
        private string m_value;
        
        public SecurityState(string value)
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

    
        public static SecurityState Unknown = new SecurityState("unknown");
    
        public static SecurityState Neutral = new SecurityState("neutral");
    
        public static SecurityState Insecure = new SecurityState("insecure");
    
        public static SecurityState Warning = new SecurityState("warning");
    
        public static SecurityState Secure = new SecurityState("secure");
    
        public static SecurityState Info = new SecurityState("info");
    
    }
}