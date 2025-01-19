using System;
using System.Collections;
using System.Collections.Generic;

namespace Mono.Collections.Generic
{
	public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
	{
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private Collection<T> collection;

			private T current;

			private int next;

			private readonly int version;

			public T Current
			{
				get
				{
					return default(T);
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			internal Enumerator(Collection<T> collection)
			{
				this.collection = null;
				current = default(T);
				next = 0;
				version = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			private void CheckState()
			{
			}

			public void Dispose()
			{
			}
		}

		internal T[] items;

		internal int size;

		private int version;

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		bool ICollection<T>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		object IList.Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		int ICollection.Count
		{
			get
			{
				return 0;
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		public Collection()
		{
		}

		public Collection(int capacity)
		{
		}

		public Collection(ICollection<T> items)
		{
		}

		public void Add(T item)
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		private void CheckIndex(int index)
		{
		}

		private void Shift(int start, int delta)
		{
		}

		protected virtual void OnAdd(T item, int index)
		{
		}

		protected virtual void OnInsert(T item, int index)
		{
		}

		protected virtual void OnSet(T item, int index)
		{
		}

		protected virtual void OnRemove(T item, int index)
		{
		}

		protected virtual void OnClear()
		{
		}

		internal virtual void Grow(int desired)
		{
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
}
