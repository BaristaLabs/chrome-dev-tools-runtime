namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the CSS domain to simplify the command interface.
    /// </summary>
    public class CSSAdapter
    {
        private readonly ChromeSession m_session;
        
        public CSSAdapter(ChromeSession session)
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
        /// Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the
        /// position specified by `location`.
        /// </summary>
        public async Task<AddRuleCommandResponse> AddRule(AddRuleCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddRuleCommand, AddRuleCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all class names from specified stylesheet.
        /// </summary>
        public async Task<CollectClassNamesCommandResponse> CollectClassNames(CollectClassNamesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CollectClassNamesCommand, CollectClassNamesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Creates a new special "via-inspector" stylesheet in the frame with given `frameId`.
        /// </summary>
        public async Task<CreateStyleSheetCommandResponse> CreateStyleSheet(CreateStyleSheetCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CreateStyleSheetCommand, CreateStyleSheetCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables the CSS agent for the given page.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been
        /// enabled until the result of this command is received.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Ensures that the given node will have specified pseudo-classes whenever its style is computed by
        /// the browser.
        /// </summary>
        public async Task<ForcePseudoStateCommandResponse> ForcePseudoState(ForcePseudoStateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ForcePseudoStateCommand, ForcePseudoStateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetBackgroundColorsCommandResponse> GetBackgroundColors(GetBackgroundColorsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetBackgroundColorsCommand, GetBackgroundColorsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the computed style for a DOM node identified by `nodeId`.
        /// </summary>
        public async Task<GetComputedStyleForNodeCommandResponse> GetComputedStyleForNode(GetComputedStyleForNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetComputedStyleForNodeCommand, GetComputedStyleForNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM
        /// attributes) for a DOM node identified by `nodeId`.
        /// </summary>
        public async Task<GetInlineStylesForNodeCommandResponse> GetInlineStylesForNode(GetInlineStylesForNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetInlineStylesForNodeCommand, GetInlineStylesForNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns requested styles for a DOM node identified by `nodeId`.
        /// </summary>
        public async Task<GetMatchedStylesForNodeCommandResponse> GetMatchedStylesForNode(GetMatchedStylesForNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetMatchedStylesForNodeCommand, GetMatchedStylesForNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all media queries parsed by the rendering engine.
        /// </summary>
        public async Task<GetMediaQueriesCommandResponse> GetMediaQueries(GetMediaQueriesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetMediaQueriesCommand, GetMediaQueriesCommandResponse>(command ?? new GetMediaQueriesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests information about platform fonts which we used to render child TextNodes in the given
        /// node.
        /// </summary>
        public async Task<GetPlatformFontsForNodeCommandResponse> GetPlatformFontsForNode(GetPlatformFontsForNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetPlatformFontsForNodeCommand, GetPlatformFontsForNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the current textual content and the URL for a stylesheet.
        /// </summary>
        public async Task<GetStyleSheetTextCommandResponse> GetStyleSheetText(GetStyleSheetTextCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetStyleSheetTextCommand, GetStyleSheetTextCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Find a rule with the given active property for the given node and set the new value for this
        /// property
        /// </summary>
        public async Task<SetEffectivePropertyValueForNodeCommandResponse> SetEffectivePropertyValueForNode(SetEffectivePropertyValueForNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEffectivePropertyValueForNodeCommand, SetEffectivePropertyValueForNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Modifies the keyframe rule key text.
        /// </summary>
        public async Task<SetKeyframeKeyCommandResponse> SetKeyframeKey(SetKeyframeKeyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetKeyframeKeyCommand, SetKeyframeKeyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Modifies the rule selector.
        /// </summary>
        public async Task<SetMediaTextCommandResponse> SetMediaText(SetMediaTextCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetMediaTextCommand, SetMediaTextCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Modifies the rule selector.
        /// </summary>
        public async Task<SetRuleSelectorCommandResponse> SetRuleSelector(SetRuleSelectorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetRuleSelectorCommand, SetRuleSelectorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets the new stylesheet text.
        /// </summary>
        public async Task<SetStyleSheetTextCommandResponse> SetStyleSheetText(SetStyleSheetTextCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetStyleSheetTextCommand, SetStyleSheetTextCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Applies specified style edits one after another in the given order.
        /// </summary>
        public async Task<SetStyleTextsCommandResponse> SetStyleTexts(SetStyleTextsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetStyleTextsCommand, SetStyleTextsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables the selector recording.
        /// </summary>
        public async Task<StartRuleUsageTrackingCommandResponse> StartRuleUsageTracking(StartRuleUsageTrackingCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartRuleUsageTrackingCommand, StartRuleUsageTrackingCommandResponse>(command ?? new StartRuleUsageTrackingCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Stop tracking rule usage and return the list of rules that were used since last call to
        /// `takeCoverageDelta` (or since start of coverage instrumentation)
        /// </summary>
        public async Task<StopRuleUsageTrackingCommandResponse> StopRuleUsageTracking(StopRuleUsageTrackingCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopRuleUsageTrackingCommand, StopRuleUsageTrackingCommandResponse>(command ?? new StopRuleUsageTrackingCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Obtain list of rules that became used since last call to this method (or since start of coverage
        /// instrumentation)
        /// </summary>
        public async Task<TakeCoverageDeltaCommandResponse> TakeCoverageDelta(TakeCoverageDeltaCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TakeCoverageDeltaCommand, TakeCoverageDeltaCommandResponse>(command ?? new TakeCoverageDeltaCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
        /// web font
        /// </summary>
        public void SubscribeToFontsUpdatedEvent(Action<FontsUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fires whenever a MediaQuery result changes (for example, after a browser window has been
        /// resized.) The current implementation considers only viewport-dependent media features.
        /// </summary>
        public void SubscribeToMediaQueryResultChangedEvent(Action<MediaQueryResultChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired whenever an active document stylesheet is added.
        /// </summary>
        public void SubscribeToStyleSheetAddedEvent(Action<StyleSheetAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired whenever a stylesheet is changed as a result of the client operation.
        /// </summary>
        public void SubscribeToStyleSheetChangedEvent(Action<StyleSheetChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired whenever an active document stylesheet is removed.
        /// </summary>
        public void SubscribeToStyleSheetRemovedEvent(Action<StyleSheetRemovedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}