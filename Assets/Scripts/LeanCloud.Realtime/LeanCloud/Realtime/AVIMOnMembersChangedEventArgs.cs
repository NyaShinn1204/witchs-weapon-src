using System;
using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMOnMembersChangedEventArgs : EventArgs
	{
		public AVIMConversation Conversation { get; set; }

		public AVIMConversationEventType AffectedType { get; internal set; }

		public IList<string> AffectedMembers { get; set; }

		public string Oprator { get; set; }

		public DateTime OpratedTime { get; set; }
	}
}
