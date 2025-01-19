using System;

namespace LeanCloud.Realtime
{
	public class AVIMTextMessageEventArgs : EventArgs
	{
		public AVIMTextMessage TextMessage { get; internal set; }

		public AVIMTextMessageEventArgs(AVIMTextMessage raw)
		{
		}
	}
}
