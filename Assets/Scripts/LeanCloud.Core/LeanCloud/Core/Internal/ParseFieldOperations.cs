using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	internal static class ParseFieldOperations
	{
		private static AVObjectIdComparer comparer;

		public static IEqualityComparer<object> ParseObjectComparer
		{
			get
			{
				return null;
			}
		}

		public static IAVFieldOperation Decode(IDictionary<string, object> json)
		{
			return null;
		}
	}
}
