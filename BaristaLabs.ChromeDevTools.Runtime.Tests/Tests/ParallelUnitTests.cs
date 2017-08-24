namespace BaristaLabs.ChromeDevTools.Runtime.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class ParallelUnitTests
    {
        private ChromeSessionInfo m_currentChromeSessionInfo;
        private TestContext m_testContext;

        public TestContext TestContext
        {
            get { return m_testContext; }
            set { m_testContext = value; }
        }

        [TestInitialize]
        public async Task GetNewChromeSession()
        {
            m_currentChromeSessionInfo = await RuntimeTestSetup.Chrome.CreateNewSession();
        }

        [TestCleanup]
        public async Task CleanupChromeSession()
        {
            await RuntimeTestSetup.Chrome.CloseSession(m_currentChromeSessionInfo);
            m_currentChromeSessionInfo = null;
        }

        [TestMethod]
        public async Task AssertParallelNavigationTasksSucceed()
        {
            int sessionCount = 10;

            var sessions = new ChromeSessionInfo[sessionCount];
            var tasks = new Task<string>[sessionCount];

            for(int i = 0; i < sessionCount; i++)
            {
                var session = await RuntimeTestSetup.Chrome.CreateNewSession();
                sessions[i] = session;
                tasks[i] = NavigateToPageInNewSession(session, "https://www.google.com/?q=foo" + i);
            }

            Task.WaitAll(tasks, 30000);
            for(int i = 0; i < sessionCount; i++)
            {
                Assert.IsTrue(tasks[i].Result.Contains($"value=\"foo{i}\""));
                await RuntimeTestSetup.Chrome.CloseSession(sessions[i]);
            }
        }

        public async Task<string> NavigateToPageInNewSession(ChromeSessionInfo sessionInfo, string address)
        {
            TestContext.WriteLine($"ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            var s = new SemaphoreSlim(0, 1);
            string body = null;
            string requestId = null;
            using (var session = new ChromeSession(sessionInfo.WebSocketDebuggerUrl))
            {
                await session.Page.Enable();
                await session.Network.Enable(new Network.EnableCommand() { });

                session.Network.SubscribeToResponseReceivedEvent((e2) =>
                {
                    if (e2.Response.Url != address)
                    {
                        return;
                    }

                    requestId = e2.RequestId;
                });

                session.Page.SubscribeToLoadEventFiredEvent(async (e) =>
                {
                    if (String.IsNullOrWhiteSpace(requestId))
                    {
                        throw new InvalidOperationException("RequestId not set");
                    }

                    var response = await session.Network.GetResponseBody(new Network.GetResponseBodyCommand()
                    {
                        RequestId = requestId
                    });

                    body = response.Body;
                    s.Release();
                });

                var navigateResult = await session.Page.Navigate(new Page.NavigateCommand
                {
                    Url = address
                });

                await s.WaitAsync();
                return body;
            }
        }
    }
}
