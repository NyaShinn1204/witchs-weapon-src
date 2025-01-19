using System;

namespace LeanCloud.Realtime.Internal
{
	public interface IAVTimer
	{
		bool Enabled { get; set; }

		double Interval { get; set; }

		long Executed { get; }

		event EventHandler<TimerEventArgs> Elapsed;

		void Start();

		void Stop();
	}
}
