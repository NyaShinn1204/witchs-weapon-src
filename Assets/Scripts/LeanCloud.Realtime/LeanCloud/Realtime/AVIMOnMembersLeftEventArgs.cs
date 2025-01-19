using System;
using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMOnMembersLeftEventArgs : EventArgs
	{
		public IEnumerable<string> LeftMembers { get; internal set; }

		public string KickedBy { get; internal set; }

		public string ConversationId { get; internal set; }
	}
}
