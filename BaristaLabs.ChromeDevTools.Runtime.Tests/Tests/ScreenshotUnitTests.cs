namespace BaristaLabs.ChromeDevTools.Runtime.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class ScreenshotTests
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
        public async Task EnsureCaptureScreenshotHasData()
        {
            var s = new SemaphoreSlim(0, 1);
            var fileName = $".\\{m_testContext.TestName}.png";

            using (var session = new ChromeSession(m_currentChromeSessionInfo.WebSocketDebuggerUrl))
            {
                await session.Page.Enable();

                session.Page.SubscribeToLoadEventFiredEvent(async (e) =>
                {
                    var screenshot = await session.Page.CaptureScreenshot(new Page.CaptureScreenshotCommand());
                    if (!string.IsNullOrWhiteSpace(screenshot.Data))
                    {
                        File.WriteAllBytes(fileName, Convert.FromBase64String(screenshot.Data));
                        m_testContext.WriteLine($"saved to {fileName}");
                        s.Release();
                    }
                });

                var navigateResult = await session.Page.Navigate(new Page.NavigateCommand
                {
                    Url = "https://www.google.com"
                });

                await s.WaitAsync();
                Assert.IsTrue(File.Exists(fileName));
            }
        }
    }
}
