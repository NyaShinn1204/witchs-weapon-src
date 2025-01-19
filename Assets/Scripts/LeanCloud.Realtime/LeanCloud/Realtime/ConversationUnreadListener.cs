using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	internal class ConversationUnreadListener : IAVIMListener
	{
		internal class UnreadConversationNotice : IEqualityComparer<UnreadConversationNotice>
		{
			internal readonly object mutex;

			internal IAVIMMessage LastUnreadMessage { get; set; }

			internal string ConvId { get; set; }

			internal int UnreadCount { get; set; }

			public bool Equals(UnreadConversationNotice x, UnreadConversationNotice y)
			{
				return false;
			}

			public int GetHashCode(UnreadConversationNotice obj)
			{
				return 0;
			}

			internal void AutomicIncrement()
			{
			}
		}

		internal static readonly object sMutex;

		internal static long NotifTime;

		internal static HashSet<UnreadConversationNotice> UnreadConversations;

		static ConversationUnreadListener()
		{
		}

		internal static void UpdateNotice(IAVIMMessage message)
		{
		}

		internal static void ClearUnread(string convId)
		{
		}

		internal static IEnumerable<string> FindAllConvIds()
		{
			return null;
		}

		internal static UnreadConversationNotice Get(string convId)
		{
			return null;
		}

		public void OnNoticeReceived(AVIMNotice notice)
		{
		}

		public bool ProtocolHook(AVIMNotice notice)
		{
			return false;
		}
	}
}
