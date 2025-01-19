using System;

namespace LeanCloud.Realtime
{
	public class AVIMOnKickedEventArgs : EventArgs
	{
		public string KickedBy { get; internal set; }

		public string ConversationId { get; internal set; }
	}
}
