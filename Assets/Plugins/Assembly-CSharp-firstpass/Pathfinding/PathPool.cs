using System.Collections.Generic;

namespace Pathfinding
{
	public static class PathPool<T> where T : Path, new()
	{
		private static Stack<T> pool;

		private static int totalCreated;

		static PathPool()
		{
		}

		public static void Recycle(T path)
		{
		}

		public static void Warmup(int count, int length)
		{
		}

		public static int GetTotalCreated()
		{
			return 0;
		}

		public static int GetSize()
		{
			return 0;
		}

		public static T GetPath()
		{
			return null;
		}
	}
}
