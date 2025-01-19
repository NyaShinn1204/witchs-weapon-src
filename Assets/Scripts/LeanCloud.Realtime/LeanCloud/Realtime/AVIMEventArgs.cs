using System;

namespace LeanCloud.Realtime
{
	public class AVIMEventArgs : EventArgs
	{
		public AVIMException.ErrorCode ErrorCode { get; internal set; }

		public string Message { get; set; }
	}
}
