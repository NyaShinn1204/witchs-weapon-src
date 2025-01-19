using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public static class AVQueryExtensions
	{
		public static string GetClassName<T>(this AVQuery<T> query) where T : AVObject
		{
			return null;
		}

		public static IDictionary<string, object> BuildParameters<T>(this AVQuery<T> query) where T : AVObject
		{
			return null;
		}

		public static object GetConstraint<T>(this AVQuery<T> query, string key) where T : AVObject
		{
			return null;
		}
	}
}
