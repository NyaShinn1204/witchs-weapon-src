using System;
using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMOnMembersJoinedEventArgs : EventArgs
	{
		public IEnumerable<string> JoinedMembers { get; internal set; }

		public string InvitedBy { get; internal set; }

		public string ConversationId { get; internal set; }
	}
}
