namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Overlay domain to simplify the command interface.
    /// </summary>
    public class OverlayAdapter
    {
        private readonly ChromeSession m_session;
        
        public OverlayAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

        /// <summary>
        /// Enables domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows paint rectangles
        /// </summary>
        public async Task<SetShowPaintRectsCommandResponse> SetShowPaintRects(SetShowPaintRectsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowPaintRectsCommand, SetShowPaintRectsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows debug borders on layers
        /// </summary>
        public async Task<SetShowDebugBordersCommandResponse> SetShowDebugBorders(SetShowDebugBordersCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowDebugBordersCommand, SetShowDebugBordersCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows the FPS counter
        /// </summary>
        public async Task<SetShowFPSCounterCommandResponse> SetShowFPSCounter(SetShowFPSCounterCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowFPSCounterCommand, SetShowFPSCounterCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows scroll bottleneck rects
        /// </summary>
        public async Task<SetShowScrollBottleneckRectsCommandResponse> SetShowScrollBottleneckRects(SetShowScrollBottleneckRectsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowScrollBottleneckRectsCommand, SetShowScrollBottleneckRectsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Paints viewport size upon main frame resize.
        /// </summary>
        public async Task<SetShowViewportSizeOnResizeCommandResponse> SetShowViewportSizeOnResize(SetShowViewportSizeOnResizeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowViewportSizeOnResizeCommand, SetShowViewportSizeOnResizeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetPausedInDebuggerMessageCommandResponse> SetPausedInDebuggerMessage(SetPausedInDebuggerMessageCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPausedInDebuggerMessageCommand, SetPausedInDebuggerMessageCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetSuspendedCommandResponse> SetSuspended(SetSuspendedCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSuspendedCommand, SetSuspendedCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspectNodeRequested' event upon element selection.
        /// </summary>
        public async Task<SetInspectModeCommandResponse> SetInspectMode(SetInspectModeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInspectModeCommand, SetInspectModeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public async Task<HighlightRectCommandResponse> HighlightRect(HighlightRectCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightRectCommand, HighlightRectCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public async Task<HighlightQuadCommandResponse> HighlightQuad(HighlightQuadCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightQuadCommand, HighlightQuadCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
        /// </summary>
        public async Task<HighlightNodeCommandResponse> HighlightNode(HighlightNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightNodeCommand, HighlightNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights owner element of the frame with given id.
        /// </summary>
        public async Task<HighlightFrameCommandResponse> HighlightFrame(HighlightFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightFrameCommand, HighlightFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Hides any highlight.
        /// </summary>
        public async Task<HideHighlightCommandResponse> HideHighlight(HideHighlightCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HideHighlightCommand, HideHighlightCommandResponse>(command ?? new HideHighlightCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// For testing.
        /// </summary>
        public async Task<GetHighlightObjectForTestCommandResponse> GetHighlightObjectForTest(GetHighlightObjectForTestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetHighlightObjectForTestCommand, GetHighlightObjectForTestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Fired when the node should be highlighted. This happens after call to &lt;code&gt;setInspectMode&lt;/code&gt;.
        /// </summary>
        public void SubscribeToNodeHighlightRequestedEvent(Action<NodeHighlightRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when the node should be inspected. This happens after call to &lt;code&gt;setInspectMode&lt;/code&gt; or when user manually inspects an element.
        /// </summary>
        public void SubscribeToInspectNodeRequestedEvent(Action<InspectNodeRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}