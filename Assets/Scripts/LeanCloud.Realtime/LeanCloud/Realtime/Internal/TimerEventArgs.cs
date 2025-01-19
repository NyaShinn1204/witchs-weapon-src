using System;

namespace LeanCloud.Realtime.Internal
{
	public class TimerEventArgs : EventArgs
	{
		public DateTime SignalTime { get; private set; }

		public TimerEventArgs(DateTime signalTime)
		{
		}
	}
}
