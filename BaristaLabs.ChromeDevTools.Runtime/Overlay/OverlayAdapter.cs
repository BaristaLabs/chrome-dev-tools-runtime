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
        /// Disables domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// For testing.
        /// </summary>
        public async Task<GetHighlightObjectForTestCommandResponse> GetHighlightObjectForTest(GetHighlightObjectForTestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetHighlightObjectForTestCommand, GetHighlightObjectForTestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// For Persistent Grid testing.
        /// </summary>
        public async Task<GetGridHighlightObjectsForTestCommandResponse> GetGridHighlightObjectsForTest(GetGridHighlightObjectsForTestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetGridHighlightObjectsForTestCommand, GetGridHighlightObjectsForTestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// For Source Order Viewer testing.
        /// </summary>
        public async Task<GetSourceOrderHighlightObjectForTestCommandResponse> GetSourceOrderHighlightObjectForTest(GetSourceOrderHighlightObjectForTestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSourceOrderHighlightObjectForTestCommand, GetSourceOrderHighlightObjectForTestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Hides any highlight.
        /// </summary>
        public async Task<HideHighlightCommandResponse> HideHighlight(HideHighlightCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HideHighlightCommand, HideHighlightCommandResponse>(command ?? new HideHighlightCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights owner element of the frame with given id.
        /// Deprecated: Doesn't work reliablity and cannot be fixed due to process
        /// separatation (the owner node might be in a different process). Determine
        /// the owner node in the client and use highlightNode.
        /// </summary>
        public async Task<HighlightFrameCommandResponse> HighlightFrame(HighlightFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightFrameCommand, HighlightFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or
        /// objectId must be specified.
        /// </summary>
        public async Task<HighlightNodeCommandResponse> HighlightNode(HighlightNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightNodeCommand, HighlightNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public async Task<HighlightQuadCommandResponse> HighlightQuad(HighlightQuadCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightQuadCommand, HighlightQuadCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public async Task<HighlightRectCommandResponse> HighlightRect(HighlightRectCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightRectCommand, HighlightRectCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights the source order of the children of the DOM node with given id or with the given
        /// JavaScript object wrapper. Either nodeId or objectId must be specified.
        /// </summary>
        public async Task<HighlightSourceOrderCommandResponse> HighlightSourceOrder(HighlightSourceOrderCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightSourceOrderCommand, HighlightSourceOrderCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
        /// Backend then generates 'inspectNodeRequested' event upon element selection.
        /// </summary>
        public async Task<SetInspectModeCommandResponse> SetInspectMode(SetInspectModeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInspectModeCommand, SetInspectModeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Highlights owner element of all frames detected to be ads.
        /// </summary>
        public async Task<SetShowAdHighlightsCommandResponse> SetShowAdHighlights(SetShowAdHighlightsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowAdHighlightsCommand, SetShowAdHighlightsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setPausedInDebuggerMessage
        /// </summary>
        public async Task<SetPausedInDebuggerMessageCommandResponse> SetPausedInDebuggerMessage(SetPausedInDebuggerMessageCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPausedInDebuggerMessageCommand, SetPausedInDebuggerMessageCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
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
        /// Highlight multiple elements with the CSS Grid overlay.
        /// </summary>
        public async Task<SetShowGridOverlaysCommandResponse> SetShowGridOverlays(SetShowGridOverlaysCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowGridOverlaysCommand, SetShowGridOverlaysCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setShowFlexOverlays
        /// </summary>
        public async Task<SetShowFlexOverlaysCommandResponse> SetShowFlexOverlays(SetShowFlexOverlaysCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowFlexOverlaysCommand, SetShowFlexOverlaysCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setShowScrollSnapOverlays
        /// </summary>
        public async Task<SetShowScrollSnapOverlaysCommandResponse> SetShowScrollSnapOverlays(SetShowScrollSnapOverlaysCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowScrollSnapOverlaysCommand, SetShowScrollSnapOverlaysCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setShowContainerQueryOverlays
        /// </summary>
        public async Task<SetShowContainerQueryOverlaysCommandResponse> SetShowContainerQueryOverlays(SetShowContainerQueryOverlaysCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowContainerQueryOverlaysCommand, SetShowContainerQueryOverlaysCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows paint rectangles
        /// </summary>
        public async Task<SetShowPaintRectsCommandResponse> SetShowPaintRects(SetShowPaintRectsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowPaintRectsCommand, SetShowPaintRectsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows layout shift regions
        /// </summary>
        public async Task<SetShowLayoutShiftRegionsCommandResponse> SetShowLayoutShiftRegions(SetShowLayoutShiftRegionsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowLayoutShiftRegionsCommand, SetShowLayoutShiftRegionsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that backend shows scroll bottleneck rects
        /// </summary>
        public async Task<SetShowScrollBottleneckRectsCommandResponse> SetShowScrollBottleneckRects(SetShowScrollBottleneckRectsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowScrollBottleneckRectsCommand, SetShowScrollBottleneckRectsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deprecated, no longer has any effect.
        /// </summary>
        public async Task<SetShowHitTestBordersCommandResponse> SetShowHitTestBorders(SetShowHitTestBordersCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowHitTestBordersCommand, SetShowHitTestBordersCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Request that backend shows an overlay with web vital metrics.
        /// </summary>
        public async Task<SetShowWebVitalsCommandResponse> SetShowWebVitals(SetShowWebVitalsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowWebVitalsCommand, SetShowWebVitalsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Paints viewport size upon main frame resize.
        /// </summary>
        public async Task<SetShowViewportSizeOnResizeCommandResponse> SetShowViewportSizeOnResize(SetShowViewportSizeOnResizeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowViewportSizeOnResizeCommand, SetShowViewportSizeOnResizeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Add a dual screen device hinge
        /// </summary>
        public async Task<SetShowHingeCommandResponse> SetShowHinge(SetShowHingeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowHingeCommand, SetShowHingeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Show elements in isolation mode with overlays.
        /// </summary>
        public async Task<SetShowIsolatedElementsCommandResponse> SetShowIsolatedElements(SetShowIsolatedElementsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetShowIsolatedElementsCommand, SetShowIsolatedElementsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Fired when the node should be inspected. This happens after call to `setInspectMode` or when
        /// user manually inspects an element.
        /// </summary>
        public void SubscribeToInspectNodeRequestedEvent(Action<InspectNodeRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when the node should be highlighted. This happens after call to `setInspectMode`.
        /// </summary>
        public void SubscribeToNodeHighlightRequestedEvent(Action<NodeHighlightRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when user asks to capture screenshot of some area on the page.
        /// </summary>
        public void SubscribeToScreenshotRequestedEvent(Action<ScreenshotRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when user cancels the inspect mode.
        /// </summary>
        public void SubscribeToInspectModeCanceledEvent(Action<InspectModeCanceledEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}