using System;
using System.Timers;

namespace LeanCloud.Realtime.Internal
{
	public class AVTimer : IAVTimer
	{
		private Timer timer;

		private long executed;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public double Interval
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public long Executed
		{
			get
			{
				return 0L;
			}
			internal set
			{
			}
		}

		public event EventHandler<TimerEventArgs> Elapsed
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}
	}
}
