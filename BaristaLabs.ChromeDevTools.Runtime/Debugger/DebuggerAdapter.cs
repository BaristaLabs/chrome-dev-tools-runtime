namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using System;
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
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables debugger for given page.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Activates / deactivates all breakpoints on the page.
        /// </summary>
        public async Task<SetBreakpointsActiveCommandResponse> SetBreakpointsActive(SetBreakpointsActiveCommand command)
        {
            return await m_session.SendCommand<SetBreakpointsActiveCommand, SetBreakpointsActiveCommandResponse>(command);
        }
    
        /// <summary>
        /// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
        /// </summary>
        public async Task<SetSkipAllPausesCommandResponse> SetSkipAllPauses(SetSkipAllPausesCommand command)
        {
            return await m_session.SendCommand<SetSkipAllPausesCommand, SetSkipAllPausesCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this command is issued, all existing parsed scripts will have breakpoints resolved and returned in <code>locations</code> property. Further matching script parsing will result in subsequent <code>breakpointResolved</code> events issued. This logical breakpoint will survive page reloads.
        /// </summary>
        public async Task<SetBreakpointByUrlCommandResponse> SetBreakpointByUrl(SetBreakpointByUrlCommand command)
        {
            return await m_session.SendCommand<SetBreakpointByUrlCommand, SetBreakpointByUrlCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets JavaScript breakpoint at a given location.
        /// </summary>
        public async Task<SetBreakpointCommandResponse> SetBreakpoint(SetBreakpointCommand command)
        {
            return await m_session.SendCommand<SetBreakpointCommand, SetBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes JavaScript breakpoint.
        /// </summary>
        public async Task<RemoveBreakpointCommandResponse> RemoveBreakpoint(RemoveBreakpointCommand command)
        {
            return await m_session.SendCommand<RemoveBreakpointCommand, RemoveBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns possible locations for breakpoint. scriptId in start and end range locations should be the same.
        /// </summary>
        public async Task<GetPossibleBreakpointsCommandResponse> GetPossibleBreakpoints(GetPossibleBreakpointsCommand command)
        {
            return await m_session.SendCommand<GetPossibleBreakpointsCommand, GetPossibleBreakpointsCommandResponse>(command);
        }
    
        /// <summary>
        /// Continues execution until specific location is reached.
        /// </summary>
        public async Task<ContinueToLocationCommandResponse> ContinueToLocation(ContinueToLocationCommand command)
        {
            return await m_session.SendCommand<ContinueToLocationCommand, ContinueToLocationCommandResponse>(command);
        }
    
        /// <summary>
        /// Steps over the statement.
        /// </summary>
        public async Task<StepOverCommandResponse> StepOver(StepOverCommand command)
        {
            return await m_session.SendCommand<StepOverCommand, StepOverCommandResponse>(command);
        }
    
        /// <summary>
        /// Steps into the function call.
        /// </summary>
        public async Task<StepIntoCommandResponse> StepInto(StepIntoCommand command)
        {
            return await m_session.SendCommand<StepIntoCommand, StepIntoCommandResponse>(command);
        }
    
        /// <summary>
        /// Steps out of the function call.
        /// </summary>
        public async Task<StepOutCommandResponse> StepOut(StepOutCommand command)
        {
            return await m_session.SendCommand<StepOutCommand, StepOutCommandResponse>(command);
        }
    
        /// <summary>
        /// Stops on the next JavaScript statement.
        /// </summary>
        public async Task<PauseCommandResponse> Pause(PauseCommand command)
        {
            return await m_session.SendCommand<PauseCommand, PauseCommandResponse>(command);
        }
    
        /// <summary>
        /// Resumes JavaScript execution.
        /// </summary>
        public async Task<ResumeCommandResponse> Resume(ResumeCommand command)
        {
            return await m_session.SendCommand<ResumeCommand, ResumeCommandResponse>(command);
        }
    
        /// <summary>
        /// Searches for given string in script content.
        /// </summary>
        public async Task<SearchInContentCommandResponse> SearchInContent(SearchInContentCommand command)
        {
            return await m_session.SendCommand<SearchInContentCommand, SearchInContentCommandResponse>(command);
        }
    
        /// <summary>
        /// Edits JavaScript source live.
        /// </summary>
        public async Task<SetScriptSourceCommandResponse> SetScriptSource(SetScriptSourceCommand command)
        {
            return await m_session.SendCommand<SetScriptSourceCommand, SetScriptSourceCommandResponse>(command);
        }
    
        /// <summary>
        /// Restarts particular call frame from the beginning.
        /// </summary>
        public async Task<RestartFrameCommandResponse> RestartFrame(RestartFrameCommand command)
        {
            return await m_session.SendCommand<RestartFrameCommand, RestartFrameCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns source for the script with given id.
        /// </summary>
        public async Task<GetScriptSourceCommandResponse> GetScriptSource(GetScriptSourceCommand command)
        {
            return await m_session.SendCommand<GetScriptSourceCommand, GetScriptSourceCommandResponse>(command);
        }
    
        /// <summary>
        /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
        /// </summary>
        public async Task<SetPauseOnExceptionsCommandResponse> SetPauseOnExceptions(SetPauseOnExceptionsCommand command)
        {
            return await m_session.SendCommand<SetPauseOnExceptionsCommand, SetPauseOnExceptionsCommandResponse>(command);
        }
    
        /// <summary>
        /// Evaluates expression on a given call frame.
        /// </summary>
        public async Task<EvaluateOnCallFrameCommandResponse> EvaluateOnCallFrame(EvaluateOnCallFrameCommand command)
        {
            return await m_session.SendCommand<EvaluateOnCallFrameCommand, EvaluateOnCallFrameCommandResponse>(command);
        }
    
        /// <summary>
        /// Changes value of variable in a callframe. Object-based scopes are not supported and must be mutated manually.
        /// </summary>
        public async Task<SetVariableValueCommandResponse> SetVariableValue(SetVariableValueCommand command)
        {
            return await m_session.SendCommand<SetVariableValueCommand, SetVariableValueCommandResponse>(command);
        }
    
        /// <summary>
        /// Enables or disables async call stacks tracking.
        /// </summary>
        public async Task<SetAsyncCallStackDepthCommandResponse> SetAsyncCallStackDepth(SetAsyncCallStackDepthCommand command)
        {
            return await m_session.SendCommand<SetAsyncCallStackDepthCommand, SetAsyncCallStackDepthCommandResponse>(command);
        }
    
        /// <summary>
        /// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in scripts with url matching one of the patterns. VM will try to leave blackboxed script by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
        /// </summary>
        public async Task<SetBlackboxPatternsCommandResponse> SetBlackboxPatterns(SetBlackboxPatternsCommand command)
        {
            return await m_session.SendCommand<SetBlackboxPatternsCommand, SetBlackboxPatternsCommandResponse>(command);
        }
    
        /// <summary>
        /// Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful. Positions array contains positions where blackbox state is changed. First interval isn't blackboxed. Array should be sorted.
        /// </summary>
        public async Task<SetBlackboxedRangesCommandResponse> SetBlackboxedRanges(SetBlackboxedRangesCommand command)
        {
            return await m_session.SendCommand<SetBlackboxedRangesCommand, SetBlackboxedRangesCommandResponse>(command);
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