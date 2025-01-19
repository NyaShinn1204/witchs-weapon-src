using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMConversationBuilder : IAVIMConversatioBuilder
	{
		private bool isUnique;

		private Dictionary<string, object> properties;

		private string name;

		private bool isTransient;

		private bool isSystem;

		private List<string> members;

		public AVIMClient Client { get; internal set; }

		internal static AVIMConversationBuilder CreateDefaultBuilder()
		{
			return null;
		}

		public AVIMConversation Build()
		{
			return null;
		}

		public AVIMConversationBuilder SetUnique(bool toggle = true)
		{
			return null;
		}

		public AVIMConversationBuilder SetSystem(bool toggle = true)
		{
			return null;
		}

		public AVIMConversationBuilder SetTransient(bool toggle = true)
		{
			return null;
		}

		public AVIMConversationBuilder SetName(string name)
		{
			return null;
		}

		public AVIMConversationBuilder SetMembers(IEnumerable<string> memberClientIds)
		{
			return null;
		}

		public AVIMConversationBuilder AddMember(string memberClientId)
		{
			return null;
		}

		public AVIMConversationBuilder AddMembers(IEnumerable<string> memberClientIds)
		{
			return null;
		}

		public AVIMConversationBuilder SetProperty(string key, object value)
		{
			return null;
		}
	}
}
