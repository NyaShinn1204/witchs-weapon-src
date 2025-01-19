using System;

namespace LeanCloud.Realtime
{
	public class AVIMTextMessage : AVIMTypedMessage
	{
		[Obsolete]
		public int LCType { get; set; }

		public AVIMTextMessage()
		{
		}

		public AVIMTextMessage(string textContent)
		{
		}
	}
}
