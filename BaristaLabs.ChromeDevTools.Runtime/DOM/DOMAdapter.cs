namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the DOM domain to simplify the command interface.
    /// </summary>
    public class DOMAdapter
    {
        private readonly ChromeSession m_session;
        
        public DOMAdapter(ChromeSession session)
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
        /// Enables DOM agent for the given page.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables DOM agent for the given page.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns the root DOM node (and optionally the subtree) to the caller.
        /// </summary>
        public async Task<GetDocumentCommandResponse> GetDocument(GetDocumentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetDocumentCommand, GetDocumentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns the root DOM node (and optionally the subtree) to the caller.
        /// </summary>
        public async Task<GetFlattenedDocumentCommandResponse> GetFlattenedDocument(GetFlattenedDocumentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetFlattenedDocumentCommand, GetFlattenedDocumentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Collects class names for the node with given id and all of it's child nodes.
        /// </summary>
        public async Task<CollectClassNamesFromSubtreeCommandResponse> CollectClassNamesFromSubtree(CollectClassNamesFromSubtreeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CollectClassNamesFromSubtreeCommand, CollectClassNamesFromSubtreeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Requests that children of the node with given id are returned to the caller in form of <code>setChildNodes</code> events where not only immediate children are retrieved, but all children down to the specified depth.
        /// </summary>
        public async Task<RequestChildNodesCommandResponse> RequestChildNodes(RequestChildNodesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestChildNodesCommand, RequestChildNodesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Executes <code>querySelector</code> on a given node.
        /// </summary>
        public async Task<QuerySelectorCommandResponse> QuerySelector(QuerySelectorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<QuerySelectorCommand, QuerySelectorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Executes <code>querySelectorAll</code> on a given node.
        /// </summary>
        public async Task<QuerySelectorAllCommandResponse> QuerySelectorAll(QuerySelectorAllCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<QuerySelectorAllCommand, QuerySelectorAllCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets node name for a node with given id.
        /// </summary>
        public async Task<SetNodeNameCommandResponse> SetNodeName(SetNodeNameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetNodeNameCommand, SetNodeNameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets node value for a node with given id.
        /// </summary>
        public async Task<SetNodeValueCommandResponse> SetNodeValue(SetNodeValueCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetNodeValueCommand, SetNodeValueCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Removes node with given id.
        /// </summary>
        public async Task<RemoveNodeCommandResponse> RemoveNode(RemoveNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveNodeCommand, RemoveNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets attribute for an element with given id.
        /// </summary>
        public async Task<SetAttributeValueCommandResponse> SetAttributeValue(SetAttributeValueCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAttributeValueCommand, SetAttributeValueCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets attributes on element with given id. This method is useful when user edits some existing attribute value and types in several attribute name/value pairs.
        /// </summary>
        public async Task<SetAttributesAsTextCommandResponse> SetAttributesAsText(SetAttributesAsTextCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAttributesAsTextCommand, SetAttributesAsTextCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Removes attribute with given name from an element with given id.
        /// </summary>
        public async Task<RemoveAttributeCommandResponse> RemoveAttribute(RemoveAttributeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveAttributeCommand, RemoveAttributeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns node's HTML markup.
        /// </summary>
        public async Task<GetOuterHTMLCommandResponse> GetOuterHTML(GetOuterHTMLCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetOuterHTMLCommand, GetOuterHTMLCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets node HTML markup, returns new node id.
        /// </summary>
        public async Task<SetOuterHTMLCommandResponse> SetOuterHTML(SetOuterHTMLCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetOuterHTMLCommand, SetOuterHTMLCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
        /// </summary>
        public async Task<PerformSearchCommandResponse> PerformSearch(PerformSearchCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PerformSearchCommand, PerformSearchCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
        /// </summary>
        public async Task<GetSearchResultsCommandResponse> GetSearchResults(GetSearchResultsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSearchResultsCommand, GetSearchResultsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
        /// </summary>
        public async Task<DiscardSearchResultsCommandResponse> DiscardSearchResults(DiscardSearchResultsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DiscardSearchResultsCommand, DiscardSearchResultsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Requests that the node is sent to the caller given the JavaScript node object reference. All nodes that form the path from the node to the root are also sent to the client as a series of <code>setChildNodes</code> notifications.
        /// </summary>
        public async Task<RequestNodeCommandResponse> RequestNode(RequestNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestNodeCommand, RequestNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
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
        /// Hides DOM node highlight.
        /// </summary>
        public async Task<HideHighlightCommandResponse> HideHighlight(HideHighlightCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HideHighlightCommand, HideHighlightCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Highlights owner element of the frame with given id.
        /// </summary>
        public async Task<HighlightFrameCommandResponse> HighlightFrame(HighlightFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HighlightFrameCommand, HighlightFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Requests that the node is sent to the caller given its path. // FIXME, use XPath
        /// </summary>
        public async Task<PushNodeByPathToFrontendCommandResponse> PushNodeByPathToFrontend(PushNodeByPathToFrontendCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PushNodeByPathToFrontendCommand, PushNodeByPathToFrontendCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Requests that a batch of nodes is sent to the caller given their backend node ids.
        /// </summary>
        public async Task<PushNodesByBackendIdsToFrontendCommandResponse> PushNodesByBackendIdsToFrontend(PushNodesByBackendIdsToFrontendCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PushNodesByBackendIdsToFrontendCommand, PushNodesByBackendIdsToFrontendCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
        /// </summary>
        public async Task<SetInspectedNodeCommandResponse> SetInspectedNode(SetInspectedNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInspectedNodeCommand, SetInspectedNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Resolves JavaScript node object for given node id.
        /// </summary>
        public async Task<ResolveNodeCommandResponse> ResolveNode(ResolveNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResolveNodeCommand, ResolveNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns attributes for the specified node.
        /// </summary>
        public async Task<GetAttributesCommandResponse> GetAttributes(GetAttributesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAttributesCommand, GetAttributesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Creates a deep copy of the specified node and places it into the target container before the given anchor.
        /// </summary>
        public async Task<CopyToCommandResponse> CopyTo(CopyToCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CopyToCommand, CopyToCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Moves node into the new container, places it before the given anchor.
        /// </summary>
        public async Task<MoveToCommandResponse> MoveTo(MoveToCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<MoveToCommand, MoveToCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Undoes the last performed action.
        /// </summary>
        public async Task<UndoCommandResponse> Undo(UndoCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UndoCommand, UndoCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Re-does the last undone action.
        /// </summary>
        public async Task<RedoCommandResponse> Redo(RedoCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RedoCommand, RedoCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Marks last undoable state.
        /// </summary>
        public async Task<MarkUndoableStateCommandResponse> MarkUndoableState(MarkUndoableStateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<MarkUndoableStateCommand, MarkUndoableStateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Focuses the given element.
        /// </summary>
        public async Task<FocusCommandResponse> Focus(FocusCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<FocusCommand, FocusCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets files for the given file input element.
        /// </summary>
        public async Task<SetFileInputFilesCommandResponse> SetFileInputFiles(SetFileInputFilesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetFileInputFilesCommand, SetFileInputFilesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns boxes for the currently selected nodes.
        /// </summary>
        public async Task<GetBoxModelCommandResponse> GetBoxModel(GetBoxModelCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetBoxModelCommand, GetBoxModelCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns node id at given location.
        /// </summary>
        public async Task<GetNodeForLocationCommandResponse> GetNodeForLocation(GetNodeForLocationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetNodeForLocationCommand, GetNodeForLocationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns the id of the nearest ancestor that is a relayout boundary.
        /// </summary>
        public async Task<GetRelayoutBoundaryCommandResponse> GetRelayoutBoundary(GetRelayoutBoundaryCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetRelayoutBoundaryCommand, GetRelayoutBoundaryCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// For testing.
        /// </summary>
        public async Task<GetHighlightObjectForTestCommandResponse> GetHighlightObjectForTest(GetHighlightObjectForTestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetHighlightObjectForTestCommand, GetHighlightObjectForTestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// Fired when <code>Document</code> has been totally updated. Node ids are no longer valid.
        /// </summary>
        public void SubscribeToDocumentUpdatedEvent(Action<DocumentUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when the node should be inspected. This happens after call to <code>setInspectMode</code>.
        /// </summary>
        public void SubscribeToInspectNodeRequestedEvent(Action<InspectNodeRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when backend wants to provide client with the missing DOM structure. This happens upon most of the calls requesting node ids.
        /// </summary>
        public void SubscribeToSetChildNodesEvent(Action<SetChildNodesEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when <code>Element</code>'s attribute is modified.
        /// </summary>
        public void SubscribeToAttributeModifiedEvent(Action<AttributeModifiedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when <code>Element</code>'s attribute is removed.
        /// </summary>
        public void SubscribeToAttributeRemovedEvent(Action<AttributeRemovedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when <code>Element</code>'s inline style is modified via a CSS property modification.
        /// </summary>
        public void SubscribeToInlineStyleInvalidatedEvent(Action<InlineStyleInvalidatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Mirrors <code>DOMCharacterDataModified</code> event.
        /// </summary>
        public void SubscribeToCharacterDataModifiedEvent(Action<CharacterDataModifiedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when <code>Container</code>'s child node count has changed.
        /// </summary>
        public void SubscribeToChildNodeCountUpdatedEvent(Action<ChildNodeCountUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Mirrors <code>DOMNodeInserted</code> event.
        /// </summary>
        public void SubscribeToChildNodeInsertedEvent(Action<ChildNodeInsertedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Mirrors <code>DOMNodeRemoved</code> event.
        /// </summary>
        public void SubscribeToChildNodeRemovedEvent(Action<ChildNodeRemovedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Called when shadow root is pushed into the element.
        /// </summary>
        public void SubscribeToShadowRootPushedEvent(Action<ShadowRootPushedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Called when shadow root is popped from the element.
        /// </summary>
        public void SubscribeToShadowRootPoppedEvent(Action<ShadowRootPoppedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Called when a pseudo element is added to an element.
        /// </summary>
        public void SubscribeToPseudoElementAddedEvent(Action<PseudoElementAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Called when a pseudo element is removed from an element.
        /// </summary>
        public void SubscribeToPseudoElementRemovedEvent(Action<PseudoElementRemovedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Called when distrubution is changed.
        /// </summary>
        public void SubscribeToDistributedNodesUpdatedEvent(Action<DistributedNodesUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToNodeHighlightRequestedEvent(Action<NodeHighlightRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}