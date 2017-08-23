namespace BaristaLabs.ChromeDevTools.Runtime.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RuntimeTestSetup
    {
        private static Chrome s_chrome;

        public static Chrome Chrome
        {
            get { return s_chrome; }
        }

        [AssemblyInitialize]
        public static void ChromeInit(TestContext context)
        {
            s_chrome = Chrome.OpenChrome(9225);
        }

        [AssemblyCleanup]
        public static void ChromeCleanup()
        {
            s_chrome.Dispose();
        }
    }
}
