using System.Collections.Generic;

namespace LeanCloud.Storage.Internal
{
	public class IdentityEqualityComparer<T> : IEqualityComparer<T>
	{
		public bool Equals(T x, T y)
		{
			return false;
		}

		public int GetHashCode(T obj)
		{
			return 0;
		}
	}
}
