using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Realtime.Internal;

namespace LeanCloud.Realtime
{
	public class AVRealtime
	{
		public enum Status
		{
			None = -1,
			Connecting = 0,
			Online = 1,
			Offline = 2,
			Reconnecting = 3,
			Opened = 98,
			Closed = 99
		}

		[StructLayout(LayoutKind.Sequential, Size = 4)]
		private struct NetworkStateOptions
		{
			public bool Available { get; set; }
		}

		[StructLayout(LayoutKind.Sequential, Size = 4)]
		private struct WebSocketStateOptions
		{
			public int ClosedCode { get; set; }
		}

		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct AVIMReconnectOptions
		{
			public long Interval { get; set; }

			public int Retry { get; set; }
		}

		public struct Configuration
		{
			public ISignatureFactory SignatureFactory { get; set; }

			public IWebSocketClient WebSocketClient { get; set; }

			public string ApplicationId { get; set; }

			public string ApplicationKey { get; set; }

			public OfflineMessageStrategy OfflineMessageStrategy { get; set; }

			public Uri RealtimeServer { get; set; }

			public Uri RTMRouter { get; set; }
		}

		public enum OfflineMessageStrategy
		{
			Default = 1,
			[Obsolete]
			UnreadNotice = 2,
			UnreadAck = 3
		}

		internal static IDictionary<string, AVIMClient> clients;

		private static readonly object mutex;

		private string _wss;

		private string _secondaryWss;

		private string _sesstionToken;

		private long _sesstionTokenExpire;

		private string _clientId;

		private string _deviceId;

		private bool _secure;

		private string _tag;

		private string subprotocolPrefix;

		private static readonly int RECONNECT_DELAY;

		private static readonly int RECONNECT_USE_SECONDARY_TIMES;

		private static readonly int RECONNECT_FROM_APP_ROUTER;

		private int reconnectTimes;

		private IAVIMCommandRunner avIMCommandRunner;

		private IWebSocketClient webSocketController;

		private Status state;

		private ISignatureFactory _signatureFactory;

		private bool useLeanEngineSignaturFactory;

		private EventHandler<AVIMDisconnectEventArgs> m_OnDisconnected;

		private EventHandler<AVIMReconnectingEventArgs> m_OnReconnecting;

		private EventHandler<AVIMReconnectedEventArgs> m_OnReconnected;

		private EventHandler<AVIMReconnectFailedArgs> m_OnReconnectFailed;

		private EventHandler<AVIMNotice> m_NoticeReceived;

		private bool _listening;

		private string _beatPacket;

		private bool _heartBeatingToggle;

		private IAVTimer _heartBeatingTimer;

		internal bool sessionConflict;

		internal bool loggedOut;

		internal bool useSecondary;

		internal bool reborn;

		private static readonly string versionString;

		public bool IsSesstionTokenExpired
		{
			get
			{
				return false;
			}
		}

		public IAVIMCommandRunner AVIMCommandRunner
		{
			get
			{
				return null;
			}
		}

		internal IWebSocketClient AVWebSocketClient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static IAVRouterController RouterController
		{
			get
			{
				return null;
			}
		}

		internal static IFreeStyleMessageClassingController FreeStyleMessageClassingController
		{
			get
			{
				return null;
			}
		}

		public Status State
		{
			get
			{
				return default(Status);
			}
			private set
			{
			}
		}

		private NetworkStateOptions NetworkState { get; set; }

		private WebSocketStateOptions WebSocketState { get; set; }

		internal string Subprotocol
		{
			get
			{
				return null;
			}
		}

		public AVIMReconnectOptions ReconnectOptions { get; set; }

		public ISignatureFactory SignatureFactory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Configuration CurrentConfiguration { get; internal set; }

		internal static Action<string> LogTracker { get; private set; }

		internal bool CanReconnect
		{
			get
			{
				return false;
			}
		}

		internal static string VersionString
		{
			get
			{
				return null;
			}
		}

		internal static Version Version
		{
			get
			{
				return null;
			}
		}

		public event EventHandler<AVIMMessageEventArgs> OnOfflineMessageReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<AVIMDisconnectEventArgs> OnDisconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMReconnectingEventArgs> OnReconnecting
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMReconnectedEventArgs> OnReconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMReconnectFailedArgs> OnReconnectFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMNotice> NoticeReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public void UseLeanEngineSignatureFactory()
		{
		}

		internal void InvokeNetworkState(bool available = false)
		{
		}

		internal void SetNetworkState(bool available = true)
		{
		}

		private void WebSocketClient_OnMessage(string obj)
		{
		}

		public void SubscribeNoticeReceived(IAVIMListener listener, Func<AVIMNotice, bool> runtimeHook = null)
		{
		}

		public AVRealtime(Configuration config)
		{
		}

		public AVRealtime(string applicationId, string applicationKey)
		{
		}

		public static void WebSocketLog(Action<string> trace)
		{
		}

		public static void PrintLog(string log)
		{
		}

		public Task<AVIMClient> CreateClientAsync(string clientId, string tag = null, string deviceId = null, bool secure = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task<AVIMClient> CreateClientAsync(AVUser user = null, string tag = null, string deviceId = null, bool secure = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal AVIMClient PreLogIn(string clientId, string tag = null, string deviceId = null)
		{
			return null;
		}

		internal void AfterLogIn(AVIMClient client)
		{
		}

		[Obsolete]
		public Task<AVIMClient> CreateClient(string clientId, string tag = null, string deviceId = null, bool secure = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public void ToggleNotification(bool toggle)
		{
		}

		public void ToggleHeartBeating(bool toggle = true, double interval = 60000.0, string beatPacket = "{}")
		{
		}

		private void SendHeartBeatingPacket(object sender, TimerEventArgs e)
		{
		}

		public void KeepAlive()
		{
		}

		public void StartAutoReconnect()
		{
		}

		internal Task LogInAsync(string clientId, string tag = null, string deviceId = null, bool secure = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal Task OpenSessionAsync(string clientId, string tag = null, string deviceId = null, string nonce = null, long timestamp = 0L, string signature = null, bool secure = true)
		{
			return null;
		}

		private Task AutoReconnect()
		{
			return null;
		}

		public void RegisterMessageType<T>() where T : IAVIMMessage
		{
		}

		public Task<bool> OpenAsync(bool secure = true)
		{
			return null;
		}

		public Task<bool> OpenAsync(bool secure, string subprotocol = null, bool enforce = false, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task<bool> OpenAsync(string url, string subprotocol = null, bool enforce = false, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task<Tuple<int, IDictionary<string, object>>> RunCommandAsync(AVIMCommand command)
		{
			return null;
		}

		public void RunCommand(AVIMCommand command)
		{
		}

		internal Task<AVIMCommand> AttachSignature(AVIMCommand command, Task<AVIMSignature> SignatureTask)
		{
			return null;
		}

		private void WebsocketClient_OnClosed(int errorCode, string reason, string detail)
		{
		}

		private void WebsocketClient_OnError(string obj)
		{
		}

		private void PrepareReconnect()
		{
		}

		internal void LogOut()
		{
		}

		internal void Dispose()
		{
		}

		static AVRealtime()
		{
		}
	}
}
