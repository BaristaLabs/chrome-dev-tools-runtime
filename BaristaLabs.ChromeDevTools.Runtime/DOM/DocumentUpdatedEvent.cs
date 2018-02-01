namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when `Document` has been totally updated. Node ids are no longer valid.
    /// </summary>
    public sealed class DocumentUpdatedEvent : IEvent
    {
    }
}