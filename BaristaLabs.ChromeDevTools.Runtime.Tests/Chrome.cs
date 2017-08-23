namespace BaristaLabs.ChromeDevTools.Runtime.Tests
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents and manages a chrome process instance
    /// </summary>
    public sealed class Chrome : IDisposable
    {
        private Process m_chromeProcess;
        private int m_remoteDebuggingPort;
        private DirectoryInfo m_userDirectory;

        internal Chrome(Process chromeProcess, DirectoryInfo userDirectory, int remoteDebuggingPort)
        {
            m_chromeProcess = chromeProcess ?? throw new ArgumentNullException(nameof(chromeProcess));
            m_userDirectory = userDirectory ?? throw new ArgumentNullException(nameof(userDirectory));
            m_remoteDebuggingPort = remoteDebuggingPort;
        }

        /// <summary>
        /// Gets the Process object for the Chrome Instance
        /// </summary>
        public Process Process
        {
            get { return m_chromeProcess; }
        }

        private HttpClient GetDebuggerClient()
        {
            var chromeHttpClient = new HttpClient()
            {
                BaseAddress = new Uri($"http://localhost:{m_remoteDebuggingPort}")
            };

            return chromeHttpClient;
        }

        public async Task<ICollection<ChromeSessionInfo>> GetActiveSessions()
        {
            using (var webClient = GetDebuggerClient())
            {
                var remoteSessions = await webClient.GetStringAsync("/json");
                return JsonConvert.DeserializeObject<ICollection<ChromeSessionInfo>>(remoteSessions);
            }
        }

        public async Task<ChromeSessionInfo> CreateNewSession()
        {
            using (var webClient = GetDebuggerClient())
            {
                var result = await webClient.PostAsync("/json/new", null);
                var contents = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ChromeSessionInfo>(contents);
            }
        }

        public async Task CloseSession(ChromeSessionInfo sessionInfo)
        {
            using (var webClient = GetDebuggerClient())
            {
                var result = await webClient.PostAsync("/json/close/" + sessionInfo.Id, null);
                var contents = await result.Content.ReadAsStringAsync();
                //Assert contents == "Target is closing"
            }
        }

        #region IDisposable Support
        void Dispose(bool disposing)
        {
            if (disposing)
            {
                //Kill the chrome process.
                if (m_chromeProcess != null)
                {
                    if (m_chromeProcess.HasExited == false)
                    {
                        m_chromeProcess.WaitForExit(1000);
                    }

                    m_chromeProcess.Kill();
                    m_chromeProcess.Dispose();
                    m_chromeProcess = null;
                }

                //Clean up the target user directory.
                if (m_userDirectory != null)
                {

                    //for (int i = 0; i < 10; i++)
                    //{
                    //    if (m_userDirectory.Exists == false)
                    //        continue;

                    //    try
                    //    {
                    //        Thread.Sleep(500);
                    //        m_userDirectory.Delete(true);
                    //    }
                    //    catch
                    //    {
                    //        //Do Nothing.
                    //    }
                    //}

                    //if (m_userDirectory.Exists)
                    //    throw new InvalidOperationException($"Unable to delete the user directory at {m_userDirectory.FullName} after 10 tries.");

                    m_userDirectory = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

        /// <summary>
        /// Creates a new chrome instance
        /// </summary>
        /// <param name="remoteDebuggingPort"></param>
        /// <returns></returns>
        public static Chrome OpenChrome(int remoteDebuggingPort = 9222, bool headless = true)
        {
            string path = Path.GetRandomFileName();
            var directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));
            var remoteDebuggingArg = $"--remote-debugging-port={remoteDebuggingPort}";
            var userDirectoryArg = $"--user-data-dir=\"{directoryInfo.FullName}\"";
            var chromeProcessArgs = $"{remoteDebuggingArg} {userDirectoryArg} --bwsi --no-first-run";

            if (headless == true)
            {
                chromeProcessArgs += " --headless";
            }

            Process chromeProcess;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                chromeProcess = Process.Start(new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", chromeProcessArgs) { CreateNoWindow = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                chromeProcess = Process.Start("google-chrome", chromeProcessArgs);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                chromeProcess = Process.Start("/Applications/Google Chrome.app/Contents/MacOS/Google Chrome", chromeProcessArgs);
            }
            else
            {
                throw new InvalidOperationException("Unknown or unsupported platform.");
            }

            return new Chrome(chromeProcess, directoryInfo, remoteDebuggingPort);
        }
    }
}
