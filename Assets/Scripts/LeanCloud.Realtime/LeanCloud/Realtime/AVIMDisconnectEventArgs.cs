using System;

namespace LeanCloud.Realtime
{
	public class AVIMDisconnectEventArgs : EventArgs
	{
		public int Code { get; private set; }

		public string Reason { get; private set; }

		public string Detail { get; private set; }

		public AVIMDisconnectEventArgs()
		{
		}

		public AVIMDisconnectEventArgs(int _code, string _reason, string _detail)
		{
		}
	}
}
