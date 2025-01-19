using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public abstract class AVEncoder
	{
		private static readonly bool isCompiledByIL2CPP;

		public static bool IsValidType(object value)
		{
			return false;
		}

		public object Encode(object value)
		{
			return null;
		}

		protected abstract IDictionary<string, object> EncodeParseObject(AVObject value);

		private object EncodeList(IList<object> list)
		{
			return null;
		}
	}
}
