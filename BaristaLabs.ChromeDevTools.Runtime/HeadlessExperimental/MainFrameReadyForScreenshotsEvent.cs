namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when the main frame has first submitted a frame to the browser. May only be fired while a BeginFrame is in flight. Before this event, screenshotting requests may fail.
    /// </summary>
    public sealed class MainFrameReadyForScreenshotsEvent : IEvent
    {
    }
}