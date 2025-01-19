using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
	public class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class
	{
		private class Reference
		{
			private int hashCode;

			public WeakReference WeakReference { get; private set; }

			public Reference(TKey obj)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}
		}

		public delegate TValue CreateValueCallback(TKey key);

		private IDictionary<Reference, TValue> data;

		private void CleanUp()
		{
		}

		public TValue GetValue(TKey key, CreateValueCallback createValueCallback)
		{
			return null;
		}
	}
}
