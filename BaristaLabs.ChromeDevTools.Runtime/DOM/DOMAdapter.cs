namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using System;
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
        /// Enables DOM agent for the given page.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables DOM agent for the given page.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns the root DOM node (and optionally the subtree) to the caller.
        /// </summary>
        public async Task<GetDocumentCommandResponse> GetDocument(GetDocumentCommand command)
        {
            return await m_session.SendCommand<GetDocumentCommand, GetDocumentCommandResponse>(command);
        }
    
        /// <summary>
        /// Collects class names for the node with given id and all of it's child nodes.
        /// </summary>
        public async Task<CollectClassNamesFromSubtreeCommandResponse> CollectClassNamesFromSubtree(CollectClassNamesFromSubtreeCommand command)
        {
            return await m_session.SendCommand<CollectClassNamesFromSubtreeCommand, CollectClassNamesFromSubtreeCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests that children of the node with given id are returned to the caller in form of <code>setChildNodes</code> events where not only immediate children are retrieved, but all children down to the specified depth.
        /// </summary>
        public async Task<RequestChildNodesCommandResponse> RequestChildNodes(RequestChildNodesCommand command)
        {
            return await m_session.SendCommand<RequestChildNodesCommand, RequestChildNodesCommandResponse>(command);
        }
    
        /// <summary>
        /// Executes <code>querySelector</code> on a given node.
        /// </summary>
        public async Task<QuerySelectorCommandResponse> QuerySelector(QuerySelectorCommand command)
        {
            return await m_session.SendCommand<QuerySelectorCommand, QuerySelectorCommandResponse>(command);
        }
    
        /// <summary>
        /// Executes <code>querySelectorAll</code> on a given node.
        /// </summary>
        public async Task<QuerySelectorAllCommandResponse> QuerySelectorAll(QuerySelectorAllCommand command)
        {
            return await m_session.SendCommand<QuerySelectorAllCommand, QuerySelectorAllCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets node name for a node with given id.
        /// </summary>
        public async Task<SetNodeNameCommandResponse> SetNodeName(SetNodeNameCommand command)
        {
            return await m_session.SendCommand<SetNodeNameCommand, SetNodeNameCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets node value for a node with given id.
        /// </summary>
        public async Task<SetNodeValueCommandResponse> SetNodeValue(SetNodeValueCommand command)
        {
            return await m_session.SendCommand<SetNodeValueCommand, SetNodeValueCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes node with given id.
        /// </summary>
        public async Task<RemoveNodeCommandResponse> RemoveNode(RemoveNodeCommand command)
        {
            return await m_session.SendCommand<RemoveNodeCommand, RemoveNodeCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets attribute for an element with given id.
        /// </summary>
        public async Task<SetAttributeValueCommandResponse> SetAttributeValue(SetAttributeValueCommand command)
        {
            return await m_session.SendCommand<SetAttributeValueCommand, SetAttributeValueCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets attributes on element with given id. This method is useful when user edits some existing attribute value and types in several attribute name/value pairs.
        /// </summary>
        public async Task<SetAttributesAsTextCommandResponse> SetAttributesAsText(SetAttributesAsTextCommand command)
        {
            return await m_session.SendCommand<SetAttributesAsTextCommand, SetAttributesAsTextCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes attribute with given name from an element with given id.
        /// </summary>
        public async Task<RemoveAttributeCommandResponse> RemoveAttribute(RemoveAttributeCommand command)
        {
            return await m_session.SendCommand<RemoveAttributeCommand, RemoveAttributeCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns node's HTML markup.
        /// </summary>
        public async Task<GetOuterHTMLCommandResponse> GetOuterHTML(GetOuterHTMLCommand command)
        {
            return await m_session.SendCommand<GetOuterHTMLCommand, GetOuterHTMLCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets node HTML markup, returns new node id.
        /// </summary>
        public async Task<SetOuterHTMLCommandResponse> SetOuterHTML(SetOuterHTMLCommand command)
        {
            return await m_session.SendCommand<SetOuterHTMLCommand, SetOuterHTMLCommandResponse>(command);
        }
    
        /// <summary>
        /// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
        /// </summary>
        public async Task<PerformSearchCommandResponse> PerformSearch(PerformSearchCommand command)
        {
            return await m_session.SendCommand<PerformSearchCommand, PerformSearchCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
        /// </summary>
        public async Task<GetSearchResultsCommandResponse> GetSearchResults(GetSearchResultsCommand command)
        {
            return await m_session.SendCommand<GetSearchResultsCommand, GetSearchResultsCommandResponse>(command);
        }
    
        /// <summary>
        /// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
        /// </summary>
        public async Task<DiscardSearchResultsCommandResponse> DiscardSearchResults(DiscardSearchResultsCommand command)
        {
            return await m_session.SendCommand<DiscardSearchResultsCommand, DiscardSearchResultsCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests that the node is sent to the caller given the JavaScript node object reference. All nodes that form the path from the node to the root are also sent to the client as a series of <code>setChildNodes</code> notifications.
        /// </summary>
        public async Task<RequestNodeCommandResponse> RequestNode(RequestNodeCommand command)
        {
            return await m_session.SendCommand<RequestNodeCommand, RequestNodeCommandResponse>(command);
        }
    
        /// <summary>
        /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspectNodeRequested' event upon element selection.
        /// </summary>
        public async Task<SetInspectModeCommandResponse> SetInspectMode(SetInspectModeCommand command)
        {
            return await m_session.SendCommand<SetInspectModeCommand, SetInspectModeCommandResponse>(command);
        }
    
        /// <summary>
        /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public async Task<HighlightRectCommandResponse> HighlightRect(HighlightRectCommand command)
        {
            return await m_session.SendCommand<HighlightRectCommand, HighlightRectCommandResponse>(command);
        }
    
        /// <summary>
        /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public async Task<HighlightQuadCommandResponse> HighlightQuad(HighlightQuadCommand command)
        {
            return await m_session.SendCommand<HighlightQuadCommand, HighlightQuadCommandResponse>(command);
        }
    
        /// <summary>
        /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
        /// </summary>
        public async Task<HighlightNodeCommandResponse> HighlightNode(HighlightNodeCommand command)
        {
            return await m_session.SendCommand<HighlightNodeCommand, HighlightNodeCommandResponse>(command);
        }
    
        /// <summary>
        /// Hides DOM node highlight.
        /// </summary>
        public async Task<HideHighlightCommandResponse> HideHighlight(HideHighlightCommand command)
        {
            return await m_session.SendCommand<HideHighlightCommand, HideHighlightCommandResponse>(command);
        }
    
        /// <summary>
        /// Highlights owner element of the frame with given id.
        /// </summary>
        public async Task<HighlightFrameCommandResponse> HighlightFrame(HighlightFrameCommand command)
        {
            return await m_session.SendCommand<HighlightFrameCommand, HighlightFrameCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests that the node is sent to the caller given its path. // FIXME, use XPath
        /// </summary>
        public async Task<PushNodeByPathToFrontendCommandResponse> PushNodeByPathToFrontend(PushNodeByPathToFrontendCommand command)
        {
            return await m_session.SendCommand<PushNodeByPathToFrontendCommand, PushNodeByPathToFrontendCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests that a batch of nodes is sent to the caller given their backend node ids.
        /// </summary>
        public async Task<PushNodesByBackendIdsToFrontendCommandResponse> PushNodesByBackendIdsToFrontend(PushNodesByBackendIdsToFrontendCommand command)
        {
            return await m_session.SendCommand<PushNodesByBackendIdsToFrontendCommand, PushNodesByBackendIdsToFrontendCommandResponse>(command);
        }
    
        /// <summary>
        /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
        /// </summary>
        public async Task<SetInspectedNodeCommandResponse> SetInspectedNode(SetInspectedNodeCommand command)
        {
            return await m_session.SendCommand<SetInspectedNodeCommand, SetInspectedNodeCommandResponse>(command);
        }
    
        /// <summary>
        /// Resolves JavaScript node object for given node id.
        /// </summary>
        public async Task<ResolveNodeCommandResponse> ResolveNode(ResolveNodeCommand command)
        {
            return await m_session.SendCommand<ResolveNodeCommand, ResolveNodeCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns attributes for the specified node.
        /// </summary>
        public async Task<GetAttributesCommandResponse> GetAttributes(GetAttributesCommand command)
        {
            return await m_session.SendCommand<GetAttributesCommand, GetAttributesCommandResponse>(command);
        }
    
        /// <summary>
        /// Creates a deep copy of the specified node and places it into the target container before the given anchor.
        /// </summary>
        public async Task<CopyToCommandResponse> CopyTo(CopyToCommand command)
        {
            return await m_session.SendCommand<CopyToCommand, CopyToCommandResponse>(command);
        }
    
        /// <summary>
        /// Moves node into the new container, places it before the given anchor.
        /// </summary>
        public async Task<MoveToCommandResponse> MoveTo(MoveToCommand command)
        {
            return await m_session.SendCommand<MoveToCommand, MoveToCommandResponse>(command);
        }
    
        /// <summary>
        /// Undoes the last performed action.
        /// </summary>
        public async Task<UndoCommandResponse> Undo(UndoCommand command)
        {
            return await m_session.SendCommand<UndoCommand, UndoCommandResponse>(command);
        }
    
        /// <summary>
        /// Re-does the last undone action.
        /// </summary>
        public async Task<RedoCommandResponse> Redo(RedoCommand command)
        {
            return await m_session.SendCommand<RedoCommand, RedoCommandResponse>(command);
        }
    
        /// <summary>
        /// Marks last undoable state.
        /// </summary>
        public async Task<MarkUndoableStateCommandResponse> MarkUndoableState(MarkUndoableStateCommand command)
        {
            return await m_session.SendCommand<MarkUndoableStateCommand, MarkUndoableStateCommandResponse>(command);
        }
    
        /// <summary>
        /// Focuses the given element.
        /// </summary>
        public async Task<FocusCommandResponse> Focus(FocusCommand command)
        {
            return await m_session.SendCommand<FocusCommand, FocusCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets files for the given file input element.
        /// </summary>
        public async Task<SetFileInputFilesCommandResponse> SetFileInputFiles(SetFileInputFilesCommand command)
        {
            return await m_session.SendCommand<SetFileInputFilesCommand, SetFileInputFilesCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns boxes for the currently selected nodes.
        /// </summary>
        public async Task<GetBoxModelCommandResponse> GetBoxModel(GetBoxModelCommand command)
        {
            return await m_session.SendCommand<GetBoxModelCommand, GetBoxModelCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns node id at given location.
        /// </summary>
        public async Task<GetNodeForLocationCommandResponse> GetNodeForLocation(GetNodeForLocationCommand command)
        {
            return await m_session.SendCommand<GetNodeForLocationCommand, GetNodeForLocationCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns the id of the nearest ancestor that is a relayout boundary.
        /// </summary>
        public async Task<GetRelayoutBoundaryCommandResponse> GetRelayoutBoundary(GetRelayoutBoundaryCommand command)
        {
            return await m_session.SendCommand<GetRelayoutBoundaryCommand, GetRelayoutBoundaryCommandResponse>(command);
        }
    
        /// <summary>
        /// For testing.
        /// </summary>
        public async Task<GetHighlightObjectForTestCommandResponse> GetHighlightObjectForTest(GetHighlightObjectForTestCommand command)
        {
            return await m_session.SendCommand<GetHighlightObjectForTestCommand, GetHighlightObjectForTestCommandResponse>(command);
        }
    
    }
}