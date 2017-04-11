namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// States which apply to widgets.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXWidgetStates
    {
        private string m_value;
        
        public AXWidgetStates(string value)
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

    
        public static AXWidgetStates Checked = new AXWidgetStates("checked");
    
        public static AXWidgetStates Expanded = new AXWidgetStates("expanded");
    
        public static AXWidgetStates Pressed = new AXWidgetStates("pressed");
    
        public static AXWidgetStates Selected = new AXWidgetStates("selected");
    
    }
}