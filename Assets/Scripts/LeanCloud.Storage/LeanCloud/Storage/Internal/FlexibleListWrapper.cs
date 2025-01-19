using System.Collections;
using System.Collections.Generic;

namespace LeanCloud.Storage.Internal
{
	[Preserve]
	public class FlexibleListWrapper<TOut, TIn> : IList<TOut>, ICollection<TOut>, IEnumerable<TOut>, IEnumerable
	{
		private IList<TIn> toWrap;

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

		public FlexibleListWrapper(IList<TIn> toWrap)
		{
		}

		public int IndexOf(TOut item)
		{
			return 0;
		}

		public void Insert(int index, TOut item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Add(TOut item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TOut item)
		{
			return false;
		}

		public void CopyTo(TOut[] array, int arrayIndex)
		{
		}

		public bool Remove(TOut item)
		{
			return false;
		}

		public IEnumerator<TOut> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
