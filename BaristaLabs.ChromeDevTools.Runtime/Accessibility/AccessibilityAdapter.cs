namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Accessibility domain to simplify the command interface.
    /// </summary>
    public class AccessibilityAdapter
    {
        private readonly ChromeSession m_session;
        
        public AccessibilityAdapter(ChromeSession session)
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
        /// Disables the accessibility domain.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables the accessibility domain which causes `AXNodeId`s to remain consistent between method calls.
        /// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
        /// </summary>
        public async Task<GetPartialAXTreeCommandResponse> GetPartialAXTree(GetPartialAXTreeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetPartialAXTreeCommand, GetPartialAXTreeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetches the entire accessibility tree for the root Document
        /// </summary>
        public async Task<GetFullAXTreeCommandResponse> GetFullAXTree(GetFullAXTreeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetFullAXTreeCommand, GetFullAXTreeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetches the root node.
        /// Requires `enable()` to have been called previously.
        /// </summary>
        public async Task<GetRootAXNodeCommandResponse> GetRootAXNode(GetRootAXNodeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetRootAXNodeCommand, GetRootAXNodeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetches a node and all ancestors up to and including the root.
        /// Requires `enable()` to have been called previously.
        /// </summary>
        public async Task<GetAXNodeAndAncestorsCommandResponse> GetAXNodeAndAncestors(GetAXNodeAndAncestorsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAXNodeAndAncestorsCommand, GetAXNodeAndAncestorsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetches a particular accessibility node by AXNodeId.
        /// Requires `enable()` to have been called previously.
        /// </summary>
        public async Task<GetChildAXNodesCommandResponse> GetChildAXNodes(GetChildAXNodesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetChildAXNodesCommand, GetChildAXNodesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Query a DOM node's accessibility subtree for accessible name and role.
        /// This command computes the name and role for all nodes in the subtree, including those that are
        /// ignored for accessibility, and returns those that mactch the specified name and role. If no DOM
        /// node is specified, or the DOM node does not exist, the command returns an error. If neither
        /// `accessibleName` or `role` is specified, it returns all the accessibility nodes in the subtree.
        /// </summary>
        public async Task<QueryAXTreeCommandResponse> QueryAXTree(QueryAXTreeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<QueryAXTreeCommand, QueryAXTreeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// The loadComplete event mirrors the load complete event sent by the browser to assistive
        /// technology when the web page has finished loading.
        /// </summary>
        public void SubscribeToLoadCompleteEvent(Action<LoadCompleteEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
        /// </summary>
        public void SubscribeToNodesUpdatedEvent(Action<NodesUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}