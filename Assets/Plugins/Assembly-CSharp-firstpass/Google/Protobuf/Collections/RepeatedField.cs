using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Google.Protobuf.Collections
{
	public sealed class RepeatedField<T> : IList<T>, IList, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
	{
		private static readonly T[] EmptyArray;

		private const int MinArraySize = 8;

		private T[] array;

		private int count;

		bool IList.IsFixedSize
		{
			get
			{
				return false;
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

		public RepeatedField<T> Clone()
		{
			return null;
		}

		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec)
		{
		}

		public int CalculateSize(FieldCodec<T> codec)
		{
			return 0;
		}

		private int CalculatePackedDataSize(FieldCodec<T> codec)
		{
			return 0;
		}

		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec)
		{
		}

		private void EnsureSize(int size)
		{
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void AddRange(IEnumerable<T> values)
		{
		}

		public void Add(IEnumerable<T> values)
		{
		}

		[DebuggerHidden]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(RepeatedField<T> other)
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

		public override string ToString()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		int IList.Add(object value)
		{
			return 0;
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
	}
}
