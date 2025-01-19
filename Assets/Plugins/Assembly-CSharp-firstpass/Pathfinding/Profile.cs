using System.Diagnostics;

namespace Pathfinding
{
	internal class Profile
	{
		private const bool PROFILE_MEM = false;

		public string name;

		private Stopwatch w;

		private int counter;

		private long mem;

		private long smem;

		private int control;

		private bool dontCountFirst;

		public Profile(string name)
		{
		}

		public int ControlValue()
		{
			return 0;
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Log()
		{
		}

		public void ConsoleLog()
		{
		}

		public void Stop(int control)
		{
		}

		public void Control(Profile other)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
