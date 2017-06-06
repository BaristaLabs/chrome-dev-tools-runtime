namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
    /// </summary>
    public sealed class JavascriptDialogClosedEvent : IEvent
    {
    
        
        /// <summary>
        /// Whether dialog was confirmed.
        /// </summary>
        
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    
    }
}