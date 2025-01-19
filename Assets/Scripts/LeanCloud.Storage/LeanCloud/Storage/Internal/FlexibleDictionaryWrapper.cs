using System.Collections;
using System.Collections.Generic;

namespace LeanCloud.Storage.Internal
{
	[Preserve]
	public class FlexibleDictionaryWrapper<TOut, TIn> : IDictionary<string, TOut>, ICollection<KeyValuePair<string, TOut>>, IEnumerable<KeyValuePair<string, TOut>>, IEnumerable
	{
		private readonly IDictionary<string, TIn> toWrap;

		public ICollection<string> Keys
		{
			get
			{
				return null;
			}
		}

		public ICollection<TOut> Values
		{
			get
			{
				return null;
			}
		}

		public TOut Item
		{
			get
			{
				return default(TOut);
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

		public FlexibleDictionaryWrapper(IDictionary<string, TIn> toWrap)
		{
		}

		public void Add(string key, TOut value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out TOut value)
		{
			value = default(TOut);
			return false;
		}

		public void Add(KeyValuePair<string, TOut> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<string, TOut> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, TOut>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<string, TOut> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<string, TOut>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
