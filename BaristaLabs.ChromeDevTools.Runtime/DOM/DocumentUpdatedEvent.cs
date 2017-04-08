namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when <code>Document</code> has been totally updated. Node ids are no longer valid.
    /// </summary>
    [Event("DOM.documentUpdated")]
    public sealed class DocumentUpdatedEvent : IEvent
    {
    
    }
}