namespace BaristaLabs.ChromeDevTools.Runtime
{
    using System;
    
    public partial class ChromeSession
    {
        private Lazy<Accessibility.AccessibilityAdapter> m_Accessibility;
        private Lazy<Animation.AnimationAdapter> m_Animation;
        private Lazy<ApplicationCache.ApplicationCacheAdapter> m_ApplicationCache;
        private Lazy<Audits.AuditsAdapter> m_Audits;
        private Lazy<Browser.BrowserAdapter> m_Browser;
        private Lazy<CSS.CSSAdapter> m_CSS;
        private Lazy<CacheStorage.CacheStorageAdapter> m_CacheStorage;
        private Lazy<DOM.DOMAdapter> m_DOM;
        private Lazy<DOMDebugger.DOMDebuggerAdapter> m_DOMDebugger;
        private Lazy<DOMSnapshot.DOMSnapshotAdapter> m_DOMSnapshot;
        private Lazy<DOMStorage.DOMStorageAdapter> m_DOMStorage;
        private Lazy<Database.DatabaseAdapter> m_Database;
        private Lazy<DeviceOrientation.DeviceOrientationAdapter> m_DeviceOrientation;
        private Lazy<Emulation.EmulationAdapter> m_Emulation;
        private Lazy<HeadlessExperimental.HeadlessExperimentalAdapter> m_HeadlessExperimental;
        private Lazy<IO.IOAdapter> m_IO;
        private Lazy<IndexedDB.IndexedDBAdapter> m_IndexedDB;
        private Lazy<Input.InputAdapter> m_Input;
        private Lazy<Inspector.InspectorAdapter> m_Inspector;
        private Lazy<LayerTree.LayerTreeAdapter> m_LayerTree;
        private Lazy<Log.LogAdapter> m_Log;
        private Lazy<Memory.MemoryAdapter> m_Memory;
        private Lazy<Network.NetworkAdapter> m_Network;
        private Lazy<Overlay.OverlayAdapter> m_Overlay;
        private Lazy<Page.PageAdapter> m_Page;
        private Lazy<Performance.PerformanceAdapter> m_Performance;
        private Lazy<Security.SecurityAdapter> m_Security;
        private Lazy<ServiceWorker.ServiceWorkerAdapter> m_ServiceWorker;
        private Lazy<Storage.StorageAdapter> m_Storage;
        private Lazy<SystemInfo.SystemInfoAdapter> m_SystemInfo;
        private Lazy<Target.TargetAdapter> m_Target;
        private Lazy<Tethering.TetheringAdapter> m_Tethering;
        private Lazy<Tracing.TracingAdapter> m_Tracing;
        private Lazy<Testing.TestingAdapter> m_Testing;
        private Lazy<Console.ConsoleAdapter> m_Console;
        private Lazy<Debugger.DebuggerAdapter> m_Debugger;
        private Lazy<HeapProfiler.HeapProfilerAdapter> m_HeapProfiler;
        private Lazy<Profiler.ProfilerAdapter> m_Profiler;
        private Lazy<Runtime.RuntimeAdapter> m_Runtime;
        private Lazy<Schema.SchemaAdapter> m_Schema;

        public ChromeSession()
        {
            m_Accessibility = new Lazy<Accessibility.AccessibilityAdapter>(() => new Accessibility.AccessibilityAdapter(this));
            m_Animation = new Lazy<Animation.AnimationAdapter>(() => new Animation.AnimationAdapter(this));
            m_ApplicationCache = new Lazy<ApplicationCache.ApplicationCacheAdapter>(() => new ApplicationCache.ApplicationCacheAdapter(this));
            m_Audits = new Lazy<Audits.AuditsAdapter>(() => new Audits.AuditsAdapter(this));
            m_Browser = new Lazy<Browser.BrowserAdapter>(() => new Browser.BrowserAdapter(this));
            m_CSS = new Lazy<CSS.CSSAdapter>(() => new CSS.CSSAdapter(this));
            m_CacheStorage = new Lazy<CacheStorage.CacheStorageAdapter>(() => new CacheStorage.CacheStorageAdapter(this));
            m_DOM = new Lazy<DOM.DOMAdapter>(() => new DOM.DOMAdapter(this));
            m_DOMDebugger = new Lazy<DOMDebugger.DOMDebuggerAdapter>(() => new DOMDebugger.DOMDebuggerAdapter(this));
            m_DOMSnapshot = new Lazy<DOMSnapshot.DOMSnapshotAdapter>(() => new DOMSnapshot.DOMSnapshotAdapter(this));
            m_DOMStorage = new Lazy<DOMStorage.DOMStorageAdapter>(() => new DOMStorage.DOMStorageAdapter(this));
            m_Database = new Lazy<Database.DatabaseAdapter>(() => new Database.DatabaseAdapter(this));
            m_DeviceOrientation = new Lazy<DeviceOrientation.DeviceOrientationAdapter>(() => new DeviceOrientation.DeviceOrientationAdapter(this));
            m_Emulation = new Lazy<Emulation.EmulationAdapter>(() => new Emulation.EmulationAdapter(this));
            m_HeadlessExperimental = new Lazy<HeadlessExperimental.HeadlessExperimentalAdapter>(() => new HeadlessExperimental.HeadlessExperimentalAdapter(this));
            m_IO = new Lazy<IO.IOAdapter>(() => new IO.IOAdapter(this));
            m_IndexedDB = new Lazy<IndexedDB.IndexedDBAdapter>(() => new IndexedDB.IndexedDBAdapter(this));
            m_Input = new Lazy<Input.InputAdapter>(() => new Input.InputAdapter(this));
            m_Inspector = new Lazy<Inspector.InspectorAdapter>(() => new Inspector.InspectorAdapter(this));
            m_LayerTree = new Lazy<LayerTree.LayerTreeAdapter>(() => new LayerTree.LayerTreeAdapter(this));
            m_Log = new Lazy<Log.LogAdapter>(() => new Log.LogAdapter(this));
            m_Memory = new Lazy<Memory.MemoryAdapter>(() => new Memory.MemoryAdapter(this));
            m_Network = new Lazy<Network.NetworkAdapter>(() => new Network.NetworkAdapter(this));
            m_Overlay = new Lazy<Overlay.OverlayAdapter>(() => new Overlay.OverlayAdapter(this));
            m_Page = new Lazy<Page.PageAdapter>(() => new Page.PageAdapter(this));
            m_Performance = new Lazy<Performance.PerformanceAdapter>(() => new Performance.PerformanceAdapter(this));
            m_Security = new Lazy<Security.SecurityAdapter>(() => new Security.SecurityAdapter(this));
            m_ServiceWorker = new Lazy<ServiceWorker.ServiceWorkerAdapter>(() => new ServiceWorker.ServiceWorkerAdapter(this));
            m_Storage = new Lazy<Storage.StorageAdapter>(() => new Storage.StorageAdapter(this));
            m_SystemInfo = new Lazy<SystemInfo.SystemInfoAdapter>(() => new SystemInfo.SystemInfoAdapter(this));
            m_Target = new Lazy<Target.TargetAdapter>(() => new Target.TargetAdapter(this));
            m_Tethering = new Lazy<Tethering.TetheringAdapter>(() => new Tethering.TetheringAdapter(this));
            m_Tracing = new Lazy<Tracing.TracingAdapter>(() => new Tracing.TracingAdapter(this));
            m_Testing = new Lazy<Testing.TestingAdapter>(() => new Testing.TestingAdapter(this));
            m_Console = new Lazy<Console.ConsoleAdapter>(() => new Console.ConsoleAdapter(this));
            m_Debugger = new Lazy<Debugger.DebuggerAdapter>(() => new Debugger.DebuggerAdapter(this));
            m_HeapProfiler = new Lazy<HeapProfiler.HeapProfilerAdapter>(() => new HeapProfiler.HeapProfilerAdapter(this));
            m_Profiler = new Lazy<Profiler.ProfilerAdapter>(() => new Profiler.ProfilerAdapter(this));
            m_Runtime = new Lazy<Runtime.RuntimeAdapter>(() => new Runtime.RuntimeAdapter(this));
            m_Schema = new Lazy<Schema.SchemaAdapter>(() => new Schema.SchemaAdapter(this));
        }

        /// <summary>
        /// Gets the adapter for the Accessibility domain.
        /// </summary>
        public Accessibility.AccessibilityAdapter Accessibility
        {
            get { return m_Accessibility.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Animation domain.
        /// </summary>
        public Animation.AnimationAdapter Animation
        {
            get { return m_Animation.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the ApplicationCache domain.
        /// </summary>
        public ApplicationCache.ApplicationCacheAdapter ApplicationCache
        {
            get { return m_ApplicationCache.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Audits domain.
        /// </summary>
        public Audits.AuditsAdapter Audits
        {
            get { return m_Audits.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Browser domain.
        /// </summary>
        public Browser.BrowserAdapter Browser
        {
            get { return m_Browser.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the CSS domain.
        /// </summary>
        public CSS.CSSAdapter CSS
        {
            get { return m_CSS.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the CacheStorage domain.
        /// </summary>
        public CacheStorage.CacheStorageAdapter CacheStorage
        {
            get { return m_CacheStorage.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the DOM domain.
        /// </summary>
        public DOM.DOMAdapter DOM
        {
            get { return m_DOM.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the DOMDebugger domain.
        /// </summary>
        public DOMDebugger.DOMDebuggerAdapter DOMDebugger
        {
            get { return m_DOMDebugger.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the DOMSnapshot domain.
        /// </summary>
        public DOMSnapshot.DOMSnapshotAdapter DOMSnapshot
        {
            get { return m_DOMSnapshot.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the DOMStorage domain.
        /// </summary>
        public DOMStorage.DOMStorageAdapter DOMStorage
        {
            get { return m_DOMStorage.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Database domain.
        /// </summary>
        public Database.DatabaseAdapter Database
        {
            get { return m_Database.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the DeviceOrientation domain.
        /// </summary>
        public DeviceOrientation.DeviceOrientationAdapter DeviceOrientation
        {
            get { return m_DeviceOrientation.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Emulation domain.
        /// </summary>
        public Emulation.EmulationAdapter Emulation
        {
            get { return m_Emulation.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the HeadlessExperimental domain.
        /// </summary>
        public HeadlessExperimental.HeadlessExperimentalAdapter HeadlessExperimental
        {
            get { return m_HeadlessExperimental.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the IO domain.
        /// </summary>
        public IO.IOAdapter IO
        {
            get { return m_IO.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the IndexedDB domain.
        /// </summary>
        public IndexedDB.IndexedDBAdapter IndexedDB
        {
            get { return m_IndexedDB.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Input domain.
        /// </summary>
        public Input.InputAdapter Input
        {
            get { return m_Input.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Inspector domain.
        /// </summary>
        public Inspector.InspectorAdapter Inspector
        {
            get { return m_Inspector.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the LayerTree domain.
        /// </summary>
        public LayerTree.LayerTreeAdapter LayerTree
        {
            get { return m_LayerTree.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Log domain.
        /// </summary>
        public Log.LogAdapter Log
        {
            get { return m_Log.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Memory domain.
        /// </summary>
        public Memory.MemoryAdapter Memory
        {
            get { return m_Memory.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Network domain.
        /// </summary>
        public Network.NetworkAdapter Network
        {
            get { return m_Network.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Overlay domain.
        /// </summary>
        public Overlay.OverlayAdapter Overlay
        {
            get { return m_Overlay.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Page domain.
        /// </summary>
        public Page.PageAdapter Page
        {
            get { return m_Page.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Performance domain.
        /// </summary>
        public Performance.PerformanceAdapter Performance
        {
            get { return m_Performance.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Security domain.
        /// </summary>
        public Security.SecurityAdapter Security
        {
            get { return m_Security.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the ServiceWorker domain.
        /// </summary>
        public ServiceWorker.ServiceWorkerAdapter ServiceWorker
        {
            get { return m_ServiceWorker.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Storage domain.
        /// </summary>
        public Storage.StorageAdapter Storage
        {
            get { return m_Storage.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the SystemInfo domain.
        /// </summary>
        public SystemInfo.SystemInfoAdapter SystemInfo
        {
            get { return m_SystemInfo.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Target domain.
        /// </summary>
        public Target.TargetAdapter Target
        {
            get { return m_Target.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Tethering domain.
        /// </summary>
        public Tethering.TetheringAdapter Tethering
        {
            get { return m_Tethering.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Tracing domain.
        /// </summary>
        public Tracing.TracingAdapter Tracing
        {
            get { return m_Tracing.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Testing domain.
        /// </summary>
        public Testing.TestingAdapter Testing
        {
            get { return m_Testing.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Console domain.
        /// </summary>
        public Console.ConsoleAdapter Console
        {
            get { return m_Console.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Debugger domain.
        /// </summary>
        public Debugger.DebuggerAdapter Debugger
        {
            get { return m_Debugger.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the HeapProfiler domain.
        /// </summary>
        public HeapProfiler.HeapProfilerAdapter HeapProfiler
        {
            get { return m_HeapProfiler.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Profiler domain.
        /// </summary>
        public Profiler.ProfilerAdapter Profiler
        {
            get { return m_Profiler.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Runtime domain.
        /// </summary>
        public Runtime.RuntimeAdapter Runtime
        {
            get { return m_Runtime.Value; }
        }
        
        /// <summary>
        /// Gets the adapter for the Schema domain.
        /// </summary>
        public Schema.SchemaAdapter Schema
        {
            get { return m_Schema.Value; }
        }
        
    }
}
