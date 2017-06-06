namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
    /// </summary>
    public sealed class JavascriptDialogOpeningEvent : IEvent
    {
    
        
        /// <summary>
        /// Message that will be displayed by the dialog.
        /// </summary>
        
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Dialog type.
        /// </summary>
        
        [JsonProperty("type")]
        public DialogType Type
        {
            get;
            set;
        }
    
    }
}