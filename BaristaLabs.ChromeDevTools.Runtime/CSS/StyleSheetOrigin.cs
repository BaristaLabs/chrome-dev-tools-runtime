namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stylesheet type: "injected" for stylesheets injected via extension, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class StyleSheetOrigin
    {
        private string m_value;
        
        public StyleSheetOrigin(string value)
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

    
        public static StyleSheetOrigin Injected = new StyleSheetOrigin("injected");
    
        public static StyleSheetOrigin UserAgent = new StyleSheetOrigin("user-agent");
    
        public static StyleSheetOrigin Inspector = new StyleSheetOrigin("inspector");
    
        public static StyleSheetOrigin Regular = new StyleSheetOrigin("regular");
    
    }
}