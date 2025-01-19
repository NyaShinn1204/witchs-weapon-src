using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Timers;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class TimerUtils
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void ElapsedDelegate(object arg);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void CompleteDelegate(object arg);

		public int id;

		public System.Timers.Timer timer;

		private int repeat;

		private int repeatCounter;

		public ElapsedDelegate OnElapsed;

		public CompleteDelegate OnComplete;

		private static Dictionary<int, TimerUtils> TimerList;

		private static int keyID;

		private static TimerUtils instance;

		public static TimerUtils GetInstance()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public static TimerUtils Find(int _key)
		{
			return null;
		}

		public void Start(int _interval, int _repeat = 1)
		{
		}

		public void Stop()
		{
		}

		public void Dispose()
		{
		}

		private void timer_Elapsed(object sender, ElapsedEventArgs e)
		{
		}
	}
}
