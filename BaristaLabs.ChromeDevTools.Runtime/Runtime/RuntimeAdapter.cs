namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Runtime domain to simplify the command interface.
    /// </summary>
    public class RuntimeAdapter
    {
        private readonly ChromeSession m_session;
        
        public RuntimeAdapter(ChromeSession session)
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
        /// Evaluates expression on global object.
        /// </summary>
        public async Task<EvaluateCommandResponse> Evaluate(EvaluateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EvaluateCommand, EvaluateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Add handler to promise with given promise object id.
        /// </summary>
        public async Task<AwaitPromiseCommandResponse> AwaitPromise(AwaitPromiseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AwaitPromiseCommand, AwaitPromiseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
        /// </summary>
        public async Task<CallFunctionOnCommandResponse> CallFunctionOn(CallFunctionOnCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CallFunctionOnCommand, CallFunctionOnCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns properties of a given object. Object group of the result is inherited from the target object.
        /// </summary>
        public async Task<GetPropertiesCommandResponse> GetProperties(GetPropertiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetPropertiesCommand, GetPropertiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Releases remote object with given id.
        /// </summary>
        public async Task<ReleaseObjectCommandResponse> ReleaseObject(ReleaseObjectCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReleaseObjectCommand, ReleaseObjectCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Releases all remote objects that belong to a given group.
        /// </summary>
        public async Task<ReleaseObjectGroupCommandResponse> ReleaseObjectGroup(ReleaseObjectGroupCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReleaseObjectGroupCommand, ReleaseObjectGroupCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Tells inspected instance to run if it was waiting for debugger to attach.
        /// </summary>
        public async Task<RunIfWaitingForDebuggerCommandResponse> RunIfWaitingForDebugger(RunIfWaitingForDebuggerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RunIfWaitingForDebuggerCommand, RunIfWaitingForDebuggerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Enables reporting of execution contexts creation by means of <code>executionContextCreated</code> event. When the reporting gets enabled the event will be sent immediately for each existing execution context.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables reporting of execution contexts creation.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Discards collected exceptions and console API calls.
        /// </summary>
        public async Task<DiscardConsoleEntriesCommandResponse> DiscardConsoleEntries(DiscardConsoleEntriesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DiscardConsoleEntriesCommand, DiscardConsoleEntriesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetCustomObjectFormatterEnabledCommandResponse> SetCustomObjectFormatterEnabled(SetCustomObjectFormatterEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCustomObjectFormatterEnabledCommand, SetCustomObjectFormatterEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Compiles expression.
        /// </summary>
        public async Task<CompileScriptCommandResponse> CompileScript(CompileScriptCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CompileScriptCommand, CompileScriptCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Runs script with given id in a given context.
        /// </summary>
        public async Task<RunScriptCommandResponse> RunScript(RunScriptCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RunScriptCommand, RunScriptCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// Issued when new execution context is created.
        /// </summary>
        public void SubscribeToExecutionContextCreatedEvent(Action<ExecutionContextCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when execution context is destroyed.
        /// </summary>
        public void SubscribeToExecutionContextDestroyedEvent(Action<ExecutionContextDestroyedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when all executionContexts were cleared in browser
        /// </summary>
        public void SubscribeToExecutionContextsClearedEvent(Action<ExecutionContextsClearedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when exception was thrown and unhandled.
        /// </summary>
        public void SubscribeToExceptionThrownEvent(Action<ExceptionThrownEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when unhandled exception was revoked.
        /// </summary>
        public void SubscribeToExceptionRevokedEvent(Action<ExceptionRevokedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when console API was called.
        /// </summary>
        public void SubscribeToConsoleAPICalledEvent(Action<ConsoleAPICalledEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when object should be inspected (for example, as a result of inspect() command line API call).
        /// </summary>
        public void SubscribeToInspectRequestedEvent(Action<InspectRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}