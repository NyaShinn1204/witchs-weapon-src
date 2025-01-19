using System;
using System.Collections.Generic;

namespace Mono.Data.Sqlite
{
	internal static class SqliteConnectionPool
	{
		internal class Pool
		{
			internal readonly Queue<WeakReference> Queue;

			internal int PoolVersion;

			internal int MaxPoolSize;

			internal Pool(int version, int maxSize)
			{
			}
		}

		private static SortedList<string, Pool> _connections;

		private static int _poolVersion;

		internal static SqliteConnectionHandle Remove(string fileName, int maxPoolSize, out int version)
		{
			version = default(int);
			return null;
		}

		internal static void Add(string fileName, SqliteConnectionHandle hdl, int version)
		{
		}

		private static void ResizePool(Pool queue, bool forAdding)
		{
		}
	}
}
