namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enum of possible property sources.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXValueSourceType
    {
        private string m_value;
        
        public AXValueSourceType(string value)
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

    
        public static AXValueSourceType Attribute = new AXValueSourceType("attribute");
    
        public static AXValueSourceType Implicit = new AXValueSourceType("implicit");
    
        public static AXValueSourceType Style = new AXValueSourceType("style");
    
        public static AXValueSourceType Contents = new AXValueSourceType("contents");
    
        public static AXValueSourceType Placeholder = new AXValueSourceType("placeholder");
    
        public static AXValueSourceType RelatedElement = new AXValueSourceType("relatedElement");
    
    }
}