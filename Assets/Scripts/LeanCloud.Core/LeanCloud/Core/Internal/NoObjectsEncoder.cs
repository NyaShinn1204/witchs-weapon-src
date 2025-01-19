using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public class NoObjectsEncoder : AVEncoder
	{
		private static readonly NoObjectsEncoder instance;

		public static NoObjectsEncoder Instance
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
	}
}
