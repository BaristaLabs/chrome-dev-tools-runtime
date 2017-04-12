namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    /// <summary>
    /// Violation configuration setting.
    /// </summary>
    public sealed class ViolationSetting
    {
    
        /// <summary>
        /// Violation type.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Time threshold to trigger upon.
        ///</summary>
        public double Threshold
        {
            get;
            set;
        }
    
    }
}