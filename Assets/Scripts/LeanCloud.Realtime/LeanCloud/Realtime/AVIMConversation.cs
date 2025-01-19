using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public class AVIMConversation : IEnumerable<KeyValuePair<string, object>>, IEnumerable, IAVObject
	{
		public class AggregatedState
		{
			public UnreadState Unread { get; internal set; }
		}

		public class UnreadState
		{
			public int Count { get; internal set; }

			public IAVIMMessage LastMessage { get; internal set; }

			public long SyncdAt { get; internal set; }

			internal UnreadState MergeReceived(ReceivedState receivedState)
			{
				return null;
			}
		}

		public class ReceivedState
		{
			public int Count { get; internal set; }

			public IAVIMMessage LastMessage { get; internal set; }

			public long SyncdAt { get; internal set; }
		}

		public class ReadState
		{
			public long ReadAt { get; set; }

			public IAVIMMessage LastMessage { get; internal set; }

			public long SyncdAt { get; internal set; }
		}

		private DateTime? updatedAt;

		private DateTime? createdAt;

		private DateTime? lastMessageAt;

		internal DateTime? expiredAt;

		private string name;

		private AVObject convState;

		internal readonly object mutex;

		internal AVIMClient _currentClient;

		private UnreadState _unread;

		private UnreadState _lastUnreadWhenOpenSession;

		private readonly object receivedMutex;

		public virtual object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				return null;
			}
		}

		public AVIMClient CurrentClient
		{
			get
			{
				return null;
			}
		}

		public string ConversationId { get; internal set; }

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IEnumerable<string> MemberIds { get; internal set; }

		public IEnumerable<string> MuteMemberIds { get; internal set; }

		public string Creator { get; private set; }

		public bool IsTransient { get; internal set; }

		public bool IsSystem { get; internal set; }

		public bool IsUnique { get; internal set; }

		public bool IsTemporary { get; internal set; }

		public DateTime? CreatedAt
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DateTime? UpdatedAt
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DateTime? LastMessageAt
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public UnreadState Unread
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ReceivedState Received { get; set; }

		public ReadState Read { get; set; }

		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public T Get<T>(string key)
		{
			return default(T);
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		internal IDictionary<string, object> EncodeAttributes()
		{
			return null;
		}

		internal void MergeFromPushServer(IDictionary<string, object> json)
		{
		}

		public AVIMConversation(string id)
		{
		}

		public AVIMConversation(string id, AVIMClient client)
		{
		}

		internal AVIMConversation(AVIMClient client)
		{
		}

		internal AVIMConversation(AVIMConversation source = null, string name = null, string creator = null, IEnumerable<string> members = null, IEnumerable<string> muteMembers = null, bool isTransient = false, bool isSystem = false, IEnumerable<KeyValuePair<string, object>> attributes = null, AVObject state = null, bool isUnique = true, bool isTemporary = false, int ttl = 86400, AVIMClient client = null)
		{
		}

		public static AVIMConversation CreateWithoutData(string convId, AVIMClient client)
		{
			return null;
		}

		public static AVIMConversation CreateWithData(IEnumerable<KeyValuePair<string, object>> magicFields, AVIMClient client)
		{
			return null;
		}

		public Task SaveAsync()
		{
			return null;
		}

		public Task<IAVIMMessage> SendMessageAsync(IAVIMMessage avMessage, bool receipt = true, bool transient = false, int priority = 1, bool will = false, IDictionary<string, object> pushData = null)
		{
			return null;
		}

		public Task<IAVIMMessage> SendMessageAsync(IAVIMMessage avMessage, AVIMSendOptions options)
		{
			return null;
		}

		public void RegisterListener(IAVIMListener listener)
		{
		}

		internal bool ConversationIdHook(AVIMNotice notice)
		{
			return false;
		}

		public Task MuteAsync()
		{
			return null;
		}

		public Task UnmuteAsync()
		{
			return null;
		}

		public Task JoinAsync()
		{
			return null;
		}

		public Task AddMembersAsync(string clientId = null, IEnumerable<string> clientIds = null)
		{
			return null;
		}

		public Task RemoveMembersAsync(string clientId = null, IEnumerable<string> clientIds = null)
		{
			return null;
		}

		public Task QuitAsync()
		{
			return null;
		}

		public Task<IEnumerable<T>> QueryMessageAsync<T>(string beforeMessageId = null, string afterMessageId = null, DateTime? beforeTimeStampPoint = null, DateTime? afterTimeStampPoint = null, int direction = 1, int limit = 20) where T : IAVIMMessage
		{
			return null;
		}

		public AVIMMessageQuery GetMessageQuery()
		{
			return null;
		}

		public AVIMMessagePager GetMessagePager()
		{
			return null;
		}

		internal virtual void MergeMagicFields(IDictionary<string, object> data)
		{
		}

		public Task<AggregatedState> SyncStateAsync()
		{
			return null;
		}

		private UnreadState GetUnreadStateFromLocal()
		{
			return null;
		}

		internal void OnMessageLoad(IEnumerable<IAVIMMessage> messages)
		{
		}

		public Task ReadAsync(IAVIMMessage message = null, DateTime? readAt = null)
		{
			return null;
		}

		private void CurrentClient_OnMessageReceived(object sender, AVIMMessageEventArgs e)
		{
		}
	}
}
