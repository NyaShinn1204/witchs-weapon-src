using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	internal class ConversationCommand : AVIMCommand
	{
		protected IList<string> members;

		public ConversationCommand()
		{
		}

		public ConversationCommand(AVIMCommand source)
		{
		}

		public ConversationCommand Member(string clientId)
		{
			return null;
		}

		public ConversationCommand Members(IEnumerable<string> members)
		{
			return null;
		}

		public ConversationCommand Transient(bool isTransient)
		{
			return null;
		}

		public ConversationCommand Unique(bool isUnique)
		{
			return null;
		}

		public ConversationCommand Temporary(bool isTemporary)
		{
			return null;
		}

		public ConversationCommand TempConvTTL(double tempConvTTL)
		{
			return null;
		}

		public ConversationCommand Attr(IDictionary<string, object> attr)
		{
			return null;
		}

		public ConversationCommand Set(string key, object value)
		{
			return null;
		}

		public ConversationCommand ConversationId(string conversationId)
		{
			return null;
		}

		public ConversationCommand Generate(AVIMConversation conversation)
		{
			return null;
		}

		public ConversationCommand Where(object encodedQueryString)
		{
			return null;
		}

		public ConversationCommand Limit(int limit)
		{
			return null;
		}

		public ConversationCommand Skip(int skip)
		{
			return null;
		}

		public ConversationCommand Count()
		{
			return null;
		}

		public ConversationCommand Sort(string sort)
		{
			return null;
		}

		public ConversationCommand TargetClientId(string targetClientId)
		{
			return null;
		}

		public ConversationCommand QueryAllMembers(bool queryAllMembers)
		{
			return null;
		}
	}
}
