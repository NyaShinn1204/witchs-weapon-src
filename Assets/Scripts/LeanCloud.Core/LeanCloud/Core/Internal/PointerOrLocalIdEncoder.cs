using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public class PointerOrLocalIdEncoder : AVEncoder
	{
		private static readonly PointerOrLocalIdEncoder instance;

		public static PointerOrLocalIdEncoder Instance
		{
			get
			{
				return null;
			}
		}

		protected override IDictionary<string, object> EncodeParseObject(AVObject value)
		{
			return null;
		}

		public IDictionary<string, object> EncodeParseObject(AVObject value, bool isPointer)
		{
			return null;
		}
	}
}
