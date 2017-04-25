namespace BaristaLabs.ChromeDevTools.Runtime.Rendering
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Rendering domain to simplify the command interface.
    /// </summary>
    public class RenderingAdapter
    {
        private readonly ChromeSession m_session;
        
        public RenderingAdapter(ChromeSession session)
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

    }
}