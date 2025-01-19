using System.Collections.Generic;

namespace Pathfinding.Util
{
	public static class ObjectPool<T> where T : class, IAstarPooledObject, new()
	{
		private static List<T> pool;

		static ObjectPool()
		{
		}

		public static T Claim()
		{
			return null;
		}

		public static void Warmup(int count)
		{
		}

		public static void Release(T obj)
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
