namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enum of possible native property sources (as a subtype of a particular AXValueSourceType).
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXValueNativeSourceType
    {
        private string m_value;
        
        public AXValueNativeSourceType(string value)
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

    
        public static AXValueNativeSourceType Figcaption = new AXValueNativeSourceType("figcaption");
    
        public static AXValueNativeSourceType Label = new AXValueNativeSourceType("label");
    
        public static AXValueNativeSourceType Labelfor = new AXValueNativeSourceType("labelfor");
    
        public static AXValueNativeSourceType Labelwrapped = new AXValueNativeSourceType("labelwrapped");
    
        public static AXValueNativeSourceType Legend = new AXValueNativeSourceType("legend");
    
        public static AXValueNativeSourceType Tablecaption = new AXValueNativeSourceType("tablecaption");
    
        public static AXValueNativeSourceType Title = new AXValueNativeSourceType("title");
    
        public static AXValueNativeSourceType Other = new AXValueNativeSourceType("other");
    
    }
}