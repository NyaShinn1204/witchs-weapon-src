using System;
using System.Collections;
using System.Collections.Generic;

namespace UniRx
{
	public sealed class CompositeDisposable : ICollection<IDisposable>, IDisposable, ICancelable, IEnumerable<IDisposable>, IEnumerable
	{
		private readonly object _gate;

		private bool _disposed;

		private List<IDisposable> _disposables;

		private int _count;

		private const int SHRINK_THRESHOLD = 64;

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public bool IsDisposed
		{
			get
			{
				return false;
			}
		}

		public CompositeDisposable()
		{
		}

		public CompositeDisposable(int capacity)
		{
		}

		public CompositeDisposable(params IDisposable[] disposables)
		{
		}

		public CompositeDisposable(IEnumerable<IDisposable> disposables)
		{
		}

		public void Add(IDisposable item)
		{
		}

		public bool Remove(IDisposable item)
		{
			return false;
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public bool Contains(IDisposable item)
		{
			return false;
		}

		public void CopyTo(IDisposable[] array, int arrayIndex)
		{
		}

		public IEnumerator<IDisposable> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
