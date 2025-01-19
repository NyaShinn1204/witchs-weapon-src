using System.Collections.Generic;

namespace Pathfinding.Util
{
	public static class ListPool<T>
	{
		private static List<List<T>> pool;

		private const int MaxCapacitySearchLength = 8;

		static ListPool()
		{
		}

		public static List<T> Claim()
		{
			return null;
		}

		public static List<T> Claim(int capacity)
		{
			return null;
		}

		public static void Warmup(int count, int size)
		{
		}

		public static void Release(List<T> list)
		{
		}

		public static void Clear()
		{
		}

		public static int GetSize()
		{
			return 0;
		}
	}
}
