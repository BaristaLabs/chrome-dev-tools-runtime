namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class GestureSourceType
    {
        private string m_value;
        
        public GestureSourceType(string value)
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

    
        public static GestureSourceType Default = new GestureSourceType("default");
    
        public static GestureSourceType Touch = new GestureSourceType("touch");
    
        public static GestureSourceType Mouse = new GestureSourceType("mouse");
    
    }
}