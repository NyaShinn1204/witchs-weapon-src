using System;

namespace LeanCloud.Realtime
{
	public class AVIMReconnectingEventArgs : EventArgs
	{
		public bool IsAuto { get; set; }

		public string ClientId { get; set; }

		public string SessionToken { get; set; }
	}
}
