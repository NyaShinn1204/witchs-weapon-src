using System;

namespace LeanCloud.Realtime
{
	public class AVIMReconnectedEventArgs : EventArgs
	{
		public bool IsAuto { get; set; }

		public string ClientId { get; set; }

		public string SessionToken { get; set; }
	}
}
