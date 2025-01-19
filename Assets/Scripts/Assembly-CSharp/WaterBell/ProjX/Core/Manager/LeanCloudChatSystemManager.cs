using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Realtime;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.Core.Manager
{
	public class LeanCloudChatSystemManager
	{
		private static bool _isCanAutoConnect;

		private static float _autoConnectTime;

		private static bool isLCDebug;

		private static LeanCloudChatSystemManager _instance;

		private bool _finishiInit;

		private Queue<string> msgQueue;

		private Queue<ChatMessage> userMsgQueue;

		private AVRealtime avRealtime;

		private bool isInit;

		private AVIMClient client;

		private AVIMConversation worldConversation;

		private AVIMConversation guildConversation;

		private AVIMConversation sysConversation;

		private AVIMConversation notifyConversation;

		private string worldConversationID;

		private string guildConversationID;

		private CancellationTokenSource tokenSource;

		private CancellationToken token;

		private Task<AVIMClient> task;

		private bool _isReConnect;

		public bool finishiInit
		{
			get
			{
				return false;
			}
		}

		public Queue<string> MsgQueue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Queue<ChatMessage> UserMsgQueue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsOffline
		{
			get
			{
				return false;
			}
		}

		private void Update()
		{
		}

		public static LeanCloudChatSystemManager GetInstance()
		{
			return null;
		}

		public void Init()
		{
		}

		private void AVRealtime_OnDisconnected(object sender, AVIMDisconnectEventArgs e)
		{
		}

		private void AVRealtime_NoticeReceived(object sender, AVIMNotice e)
		{
		}

		private void AVRealtime_OnOfflineMessageReceived(object sender, AVIMMessageEventArgs e)
		{
		}

		private void AVRealtime_OnReconnected(object sender, AVIMReconnectedEventArgs e)
		{
		}

		private void AVRealtime_OnReconnectFailed(object sender, AVIMReconnectFailedArgs e)
		{
		}

		private void AVRealtime_OnReconnecting(object sender, AVIMReconnectingEventArgs e)
		{
		}

		public void SendMsg(string content, ServerDataChatMngr.ServerDataChatType channel)
		{
		}

		private void Client_OnMessageReceived(object sender, AVIMMessageEventArgs e)
		{
		}

		private ChatMessage AVIMMessage_2_ChatMessage(AVIMMessage sAVIMsg)
		{
			return null;
		}

		private void Client_OnInvited(object sender, AVIMOnInvitedEventArgs e)
		{
		}

		private void Client_OnSessionClosed(object sender, AVIMSessionClosedEventArgs e)
		{
		}

		public void StartConversation()
		{
		}

		public void TryOpenGuildConversation()
		{
		}

		public void SubscribeGuildChange()
		{
		}

		private void UpdateGuild(PropertyChangeedObservable target)
		{
		}

		public void LoginUser(string name)
		{
		}

		public void Dispose()
		{
		}
	}
}
