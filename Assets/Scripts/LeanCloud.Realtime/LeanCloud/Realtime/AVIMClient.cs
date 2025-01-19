using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using LeanCloud.Realtime.Internal;

namespace LeanCloud.Realtime
{
	public class AVIMClient
	{
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		public struct Configuration
		{
			public bool AutoRead { get; set; }
		}

		private readonly string clientId;

		private readonly AVRealtime _realtime;

		internal readonly object mutex;

		internal readonly object patchMutex;

		private int onMessageReceivedCount;

		private EventHandler<AVIMMessageEventArgs> m_OnMessageReceived;

		private EventHandler<AVIMSessionClosedEventArgs> m_OnSessionClosed;

		internal EventHandler<AVIMMessagePatchEventArgs> m_OnMessageRecalled;

		internal EventHandler<AVIMMessagePatchEventArgs> m_OnMessageUpdated;

		public Configuration CurrentConfiguration { get; set; }

		internal AVRealtime LinkedRealtime
		{
			get
			{
				return null;
			}
		}

		public string Tag { get; private set; }

		public string ClientId
		{
			get
			{
				return null;
			}
		}

		public event EventHandler<AVIMMessageEventArgs> OnMessageReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMOnMembersJoinedEventArgs> OnMembersJoined
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

		public event EventHandler<AVIMOnMembersLeftEventArgs> OnMembersLeft
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

		public event EventHandler<AVIMOnKickedEventArgs> OnKicked
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

		public event EventHandler<AVIMOnInvitedEventArgs> OnInvited
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

		internal event EventHandler<AVIMMessageEventArgs> OnOfflineMessageReceived
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

		public event EventHandler<AVIMSessionClosedEventArgs> OnSessionClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMMessagePatchEventArgs> OnMessageRecalled
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AVIMMessagePatchEventArgs> OnMessageUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		internal AVIMClient(string clientId, AVRealtime realtime)
		{
		}

		internal AVIMClient(string clientId, string tag, AVRealtime realtime)
		{
		}

		private void OfflineMessageListener_OnOfflineMessageReceived(object sender, AVIMMessageEventArgs e)
		{
		}

		private void KickedListener_OnKicked(object sender, AVIMOnKickedEventArgs e)
		{
		}

		private void InvitedListener_OnInvited(object sender, AVIMOnInvitedEventArgs e)
		{
		}

		private void MembersLeftListener_OnMembersLeft(object sender, AVIMOnMembersLeftEventArgs e)
		{
		}

		private void MembersJoinedListener_OnMembersJoined(object sender, AVIMOnMembersJoinedEventArgs e)
		{
		}

		private void SessionListener_OnSessionClosed(int arg1, string arg2, string arg3)
		{
		}

		private void MessageListener_OnMessageReceived(object sender, AVIMMessageEventArgs e)
		{
		}

		private void AckListener_OnMessageReceieved(object sender, AVIMMessageEventArgs e)
		{
		}

		private void UpdateUnreadNotice(object sender, AVIMMessageEventArgs e)
		{
		}

		public void RegisterListener(IAVIMListener listener, Func<AVIMNotice, bool> runtimeHook = null)
		{
		}

		public static AVIMClient Get(string clientId)
		{
			return null;
		}

		internal Task<AVIMConversation> CreateConversationAsync(AVIMConversation conversation, bool isUnique = true)
		{
			return null;
		}

		public Task<AVIMConversation> CreateConversationAsync(string member = null, IEnumerable<string> members = null, string name = "", bool isSystem = false, bool isTransient = false, bool isUnique = true, bool isTemporary = false, int ttl = 86400, IDictionary<string, object> options = null)
		{
			return null;
		}

		public Task<AVIMConversation> CreateConversationAsync(IAVIMConversatioBuilder builder)
		{
			return null;
		}

		public AVIMConversationBuilder GetConversationBuilder()
		{
			return null;
		}

		public Task<AVIMConversation> CreateTemporaryConversationAsync(string member = null, IEnumerable<string> members = null, int ttl = 86400)
		{
			return null;
		}

		public Task<AVIMConversation> CreateChatRoomAsync(string chatroomName)
		{
			return null;
		}

		public Task<AVIMConversation> GetConversationAsync(string id, bool noCache = true)
		{
			return null;
		}

		public Task<IAVIMMessage> SendMessageAsync(AVIMConversation conversation, IAVIMMessage message)
		{
			return null;
		}

		public Task<IAVIMMessage> SendMessageAsync(AVIMConversation conversation, IAVIMMessage message, AVIMSendOptions options)
		{
			return null;
		}

		public Task MuteConversationAsync(AVIMConversation conversation)
		{
			return null;
		}

		public Task UnmuteConversationAsync(AVIMConversation conversation)
		{
			return null;
		}

		internal Task OperateMembersAsync(AVIMConversation conversation, string action, string member = null, IEnumerable<string> members = null)
		{
			return null;
		}

		internal IEnumerable<T> Concat<T>(T single, IEnumerable<T> collection, string exString = null)
		{
			return null;
		}

		public Task JoinAsync(AVIMConversation conversation)
		{
			return null;
		}

		public Task InviteAsync(AVIMConversation conversation, string member = null, IEnumerable<string> members = null)
		{
			return null;
		}

		[Obsolete]
		public Task LeftAsync(AVIMConversation conversation)
		{
			return null;
		}

		public Task LeaveAsync(AVIMConversation conversation)
		{
			return null;
		}

		public Task KickAsync(AVIMConversation conversation, string member = null, IEnumerable<string> members = null)
		{
			return null;
		}

		public AVIMConversationQuery GetQuery()
		{
			return null;
		}

		public AVIMConversationQuery GetConversationQuery()
		{
			return null;
		}

		public Task<IEnumerable<T>> QueryMessageAsync<T>(AVIMConversation conversation, string beforeMessageId = null, string afterMessageId = null, DateTime? beforeTimeStampPoint = null, DateTime? afterTimeStampPoint = null, int direction = 1, int limit = 20) where T : IAVIMMessage
		{
			return null;
		}

		private Task<Tuple<long, long>> FetchAllReceiptTimestampsAsync(string targetClientId = null, string conversationId = null, AVIMConversation conversation = null, bool queryAllMembers = false)
		{
			return null;
		}

		public Task<IEnumerable<Tuple<string, bool>>> PingAsync(string targetClientId = null, IEnumerable<string> targetClientIds = null)
		{
			return null;
		}

		public Task<int> CountOnlineClientsAsync(string chatroomId)
		{
			return null;
		}

		public Task ReadAsync(AVIMConversation conversation, IAVIMMessage message = null, DateTime? readAt = null)
		{
			return null;
		}

		public Task ReadAsync(string conversationId)
		{
			return null;
		}

		public Task ReadAllAsync()
		{
			return null;
		}

		public Task<AVIMRecalledMessage> RecallAsync(IAVIMMessage message)
		{
			return null;
		}

		public Task<IAVIMMessage> UpdateAsync(IAVIMMessage oldMessage, IAVIMMessage newMessage)
		{
			return null;
		}

		public Task CloseAsync()
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
	}
}
