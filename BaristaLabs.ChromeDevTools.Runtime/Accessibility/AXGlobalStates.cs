namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// States which apply to every AX node.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXGlobalStates
    {
        private string m_value;
        
        public AXGlobalStates(string value)
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

    
        public static AXGlobalStates Disabled = new AXGlobalStates("disabled");
    
        public static AXGlobalStates Hidden = new AXGlobalStates("hidden");
    
        public static AXGlobalStates HiddenRoot = new AXGlobalStates("hiddenRoot");
    
        public static AXGlobalStates Invalid = new AXGlobalStates("invalid");
    
    }
}