using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public static class AVIMClientExtensions
	{
		public static Task<AVIMConversation> CreateConversationAsync(this AVIMClient client, IEnumerable<string> members)
		{
			return null;
		}

		public static Task<AVIMConversation> CreateConversationAsync(this AVIMClient client, IEnumerable<string> members, string conversationName)
		{
			return null;
		}

		public static AVIMConversation GetConversation(this AVIMClient client, string conversationId)
		{
			return null;
		}

		public static Task JoinAsync(this AVIMClient client, string conversationId)
		{
			return null;
		}

		public static Task LeaveAsync(this AVIMClient client, string conversationId)
		{
			return null;
		}

		public static Task<IEnumerable<IAVIMMessage>> QueryMessageAsync(this AVIMClient client, AVIMConversation conversation, string beforeMessageId = null, string afterMessageId = null, DateTime? beforeTimeStampPoint = null, DateTime? afterTimeStampPoint = null, int direction = 1, int limit = 20)
		{
			return null;
		}

		public static AVIMConversationQuery GetChatRoomQuery(this AVIMClient client)
		{
			return null;
		}
	}
}
