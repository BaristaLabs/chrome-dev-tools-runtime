namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Attributes which apply to widgets.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXWidgetAttributes
    {
        private string m_value;
        
        public AXWidgetAttributes(string value)
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

    
        public static AXWidgetAttributes Autocomplete = new AXWidgetAttributes("autocomplete");
    
        public static AXWidgetAttributes Haspopup = new AXWidgetAttributes("haspopup");
    
        public static AXWidgetAttributes Level = new AXWidgetAttributes("level");
    
        public static AXWidgetAttributes Multiselectable = new AXWidgetAttributes("multiselectable");
    
        public static AXWidgetAttributes Orientation = new AXWidgetAttributes("orientation");
    
        public static AXWidgetAttributes Multiline = new AXWidgetAttributes("multiline");
    
        public static AXWidgetAttributes Readonly = new AXWidgetAttributes("readonly");
    
        public static AXWidgetAttributes Required = new AXWidgetAttributes("required");
    
        public static AXWidgetAttributes Valuemin = new AXWidgetAttributes("valuemin");
    
        public static AXWidgetAttributes Valuemax = new AXWidgetAttributes("valuemax");
    
        public static AXWidgetAttributes Valuetext = new AXWidgetAttributes("valuetext");
    
    }
}