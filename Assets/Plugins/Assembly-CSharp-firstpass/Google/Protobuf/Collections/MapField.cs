using System;
using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.Collections
{
	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, IEquatable<MapField<TKey, TValue>>, IDictionary, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, ICollection
	{
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;

			public object Current
			{
				get
				{
					return null;
				}
			}

			public DictionaryEntry Entry
			{
				get
				{
					return default(DictionaryEntry);
				}
			}

			public object Key
			{
				get
				{
					return null;
				}
			}

			public object Value
			{
				get
				{
					return null;
				}
			}

			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		public sealed class Codec
		{
			internal class MessageAdapter : IMessage
			{
				private static readonly byte[] ZeroLengthMessageStreamData;

				private readonly Codec codec;

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				internal TKey Key { get; set; }

				internal TValue Value { get; set; }

				internal MessageAdapter(Codec codec)
				{
				}

				internal void Reset()
				{
				}

				public void MergeFrom(CodedInputStream input)
				{
				}

				public void WriteTo(CodedOutputStream output)
				{
				}

				public int CalculateSize()
				{
					return 0;
				}
			}

			private readonly FieldCodec<TKey> keyCodec;

			private readonly FieldCodec<TValue> valueCodec;

			private readonly uint mapTag;

			internal uint MapTag
			{
				get
				{
					return 0u;
				}
			}

			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag)
			{
			}
		}

		private class MapView<T> : ICollection<T>, ICollection, IEnumerable<T>, IEnumerable
		{
			private readonly MapField<TKey, TValue> parent;

			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;

			private readonly Func<T, bool> containsCheck;

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

			public bool IsSynchronized
			{
				get
				{
					return false;
				}
			}

			public object SyncRoot
			{
				get
				{
					return null;
				}
			}

			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck)
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

			public IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			public bool Remove(T item)
			{
				return false;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public void CopyTo(Array array, int index)
			{
			}
		}

		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;

		private readonly LinkedList<KeyValuePair<TKey, TValue>> list;

		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		ICollection IDictionary.Keys
		{
			get
			{
				return null;
			}
		}

		ICollection IDictionary.Values
		{
			get
			{
				return null;
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

		object IDictionary.Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TValue Item
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public ICollection<TKey> Keys
		{
			get
			{
				return null;
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				return null;
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

		public MapField<TKey, TValue> Clone()
		{
			return null;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		private bool ContainsValue(TValue value)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Add(IDictionary<TKey, TValue> entries)
		{
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		public void Clear()
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(MapField<TKey, TValue> other)
		{
			return false;
		}

		public void AddEntriesFrom(CodedInputStream input, Codec codec)
		{
		}

		public void WriteTo(CodedOutputStream output, Codec codec)
		{
		}

		public int CalculateSize(Codec codec)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
