namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Debugger domain to simplify the command interface.
    /// </summary>
    public class DebuggerAdapter
    {
        private readonly ChromeSession m_session;
        
        public DebuggerAdapter(ChromeSession session)
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
        /// Enables debugger for the given page. Clients should not assume that the debugging has been enabled until the result for this command is received.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables debugger for given page.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Activates / deactivates all breakpoints on the page.
        /// </summary>
        public async Task<SetBreakpointsActiveCommandResponse> SetBreakpointsActive(SetBreakpointsActiveCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBreakpointsActiveCommand, SetBreakpointsActiveCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
        /// </summary>
        public async Task<SetSkipAllPausesCommandResponse> SetSkipAllPauses(SetSkipAllPausesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSkipAllPausesCommand, SetSkipAllPausesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this command is issued, all existing parsed scripts will have breakpoints resolved and returned in &lt;code&gt;locations&lt;/code&gt; property. Further matching script parsing will result in subsequent &lt;code&gt;breakpointResolved&lt;/code&gt; events issued. This logical breakpoint will survive page reloads.
        /// </summary>
        public async Task<SetBreakpointByUrlCommandResponse> SetBreakpointByUrl(SetBreakpointByUrlCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBreakpointByUrlCommand, SetBreakpointByUrlCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets JavaScript breakpoint at a given location.
        /// </summary>
        public async Task<SetBreakpointCommandResponse> SetBreakpoint(SetBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBreakpointCommand, SetBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes JavaScript breakpoint.
        /// </summary>
        public async Task<RemoveBreakpointCommandResponse> RemoveBreakpoint(RemoveBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveBreakpointCommand, RemoveBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns possible locations for breakpoint. scriptId in start and end range locations should be the same.
        /// </summary>
        public async Task<GetPossibleBreakpointsCommandResponse> GetPossibleBreakpoints(GetPossibleBreakpointsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetPossibleBreakpointsCommand, GetPossibleBreakpointsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Continues execution until specific location is reached.
        /// </summary>
        public async Task<ContinueToLocationCommandResponse> ContinueToLocation(ContinueToLocationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ContinueToLocationCommand, ContinueToLocationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Steps over the statement.
        /// </summary>
        public async Task<StepOverCommandResponse> StepOver(StepOverCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StepOverCommand, StepOverCommandResponse>(command ?? new StepOverCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Steps into the function call.
        /// </summary>
        public async Task<StepIntoCommandResponse> StepInto(StepIntoCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StepIntoCommand, StepIntoCommandResponse>(command ?? new StepIntoCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Steps out of the function call.
        /// </summary>
        public async Task<StepOutCommandResponse> StepOut(StepOutCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StepOutCommand, StepOutCommandResponse>(command ?? new StepOutCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Stops on the next JavaScript statement.
        /// </summary>
        public async Task<PauseCommandResponse> Pause(PauseCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PauseCommand, PauseCommandResponse>(command ?? new PauseCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Steps into next scheduled async task if any is scheduled before next pause. Returns success when async task is actually scheduled, returns error if no task were scheduled or another scheduleStepIntoAsync was called.
        /// </summary>
        public async Task<ScheduleStepIntoAsyncCommandResponse> ScheduleStepIntoAsync(ScheduleStepIntoAsyncCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ScheduleStepIntoAsyncCommand, ScheduleStepIntoAsyncCommandResponse>(command ?? new ScheduleStepIntoAsyncCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Resumes JavaScript execution.
        /// </summary>
        public async Task<ResumeCommandResponse> Resume(ResumeCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResumeCommand, ResumeCommandResponse>(command ?? new ResumeCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Searches for given string in script content.
        /// </summary>
        public async Task<SearchInContentCommandResponse> SearchInContent(SearchInContentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SearchInContentCommand, SearchInContentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Edits JavaScript source live.
        /// </summary>
        public async Task<SetScriptSourceCommandResponse> SetScriptSource(SetScriptSourceCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetScriptSourceCommand, SetScriptSourceCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Restarts particular call frame from the beginning.
        /// </summary>
        public async Task<RestartFrameCommandResponse> RestartFrame(RestartFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RestartFrameCommand, RestartFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns source for the script with given id.
        /// </summary>
        public async Task<GetScriptSourceCommandResponse> GetScriptSource(GetScriptSourceCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetScriptSourceCommand, GetScriptSourceCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is &lt;code&gt;none&lt;/code&gt;.
        /// </summary>
        public async Task<SetPauseOnExceptionsCommandResponse> SetPauseOnExceptions(SetPauseOnExceptionsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPauseOnExceptionsCommand, SetPauseOnExceptionsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Evaluates expression on a given call frame.
        /// </summary>
        public async Task<EvaluateOnCallFrameCommandResponse> EvaluateOnCallFrame(EvaluateOnCallFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EvaluateOnCallFrameCommand, EvaluateOnCallFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Changes value of variable in a callframe. Object-based scopes are not supported and must be mutated manually.
        /// </summary>
        public async Task<SetVariableValueCommandResponse> SetVariableValue(SetVariableValueCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetVariableValueCommand, SetVariableValueCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables or disables async call stacks tracking.
        /// </summary>
        public async Task<SetAsyncCallStackDepthCommandResponse> SetAsyncCallStackDepth(SetAsyncCallStackDepthCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAsyncCallStackDepthCommand, SetAsyncCallStackDepthCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in scripts with url matching one of the patterns. VM will try to leave blackboxed script by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
        /// </summary>
        public async Task<SetBlackboxPatternsCommandResponse> SetBlackboxPatterns(SetBlackboxPatternsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBlackboxPatternsCommand, SetBlackboxPatternsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful. Positions array contains positions where blackbox state is changed. First interval isn't blackboxed. Array should be sorted.
        /// </summary>
        public async Task<SetBlackboxedRangesCommandResponse> SetBlackboxedRanges(SetBlackboxedRangesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBlackboxedRangesCommand, SetBlackboxedRangesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Fired when virtual machine parses script. This event is also fired for all known and uncollected scripts upon enabling debugger.
        /// </summary>
        public void SubscribeToScriptParsedEvent(Action<ScriptParsedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when virtual machine fails to parse the script.
        /// </summary>
        public void SubscribeToScriptFailedToParseEvent(Action<ScriptFailedToParseEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when breakpoint is resolved to an actual script and location.
        /// </summary>
        public void SubscribeToBreakpointResolvedEvent(Action<BreakpointResolvedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
        /// </summary>
        public void SubscribeToPausedEvent(Action<PausedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when the virtual machine resumed execution.
        /// </summary>
        public void SubscribeToResumedEvent(Action<ResumedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}