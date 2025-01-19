using System;

namespace LeanCloud.Realtime
{
	public class AVIMOnInvitedEventArgs : EventArgs
	{
		public string InvitedBy { get; internal set; }

		public string ConversationId { get; internal set; }
	}
}
