using System;

namespace LeanCloud.Realtime
{
	public class AVIMSessionClosedEventArgs : EventArgs
	{
		public int Code { get; internal set; }

		public string Reason { get; internal set; }

		public string Detail { get; internal set; }
	}
}
