using System;

namespace LeanCloud.Realtime
{
	public class AVIMReconnectFailedArgs : EventArgs
	{
		public bool IsAuto { get; set; }

		public string ClientId { get; set; }

		public string SessionToken { get; set; }

		public int FailedCode { get; set; }
	}
}
