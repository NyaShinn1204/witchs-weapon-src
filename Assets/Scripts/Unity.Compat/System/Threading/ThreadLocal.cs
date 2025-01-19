using System.Collections.Generic;

namespace System.Threading
{
	public class ThreadLocal<T> : IDisposable
	{
		private static long lastId;

		[ThreadStatic]
		private static IDictionary<long, T> threadLocalData;

		private static IList<WeakReference> allDataDictionaries;

		private bool disposed;

		private readonly long id;

		private readonly Func<T> valueFactory;

		private static IDictionary<long, T> ThreadLocalData
		{
			get
			{
				return null;
			}
		}

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public ThreadLocal(Func<T> valueFactory)
		{
		}

		~ThreadLocal()
		{
		}

		private void CheckDisposed()
		{
		}

		public void Dispose()
		{
		}
	}
}
