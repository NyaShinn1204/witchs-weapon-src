using System;

namespace LeanCloud.Realtime
{
	public class AVIMMessageEventArgs : EventArgs
	{
		public IAVIMMessage Message { get; internal set; }

		public AVIMMessageEventArgs(IAVIMMessage iMessage)
		{
		}
	}
}
