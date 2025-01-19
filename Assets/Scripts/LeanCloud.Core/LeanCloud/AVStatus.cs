using System.Collections.Generic;

namespace LeanCloud
{
	public class AVStatus : AVObject
	{
		private static readonly HashSet<string> readOnlyKeys;

		protected override bool IsKeyMutable(string key)
		{
			return false;
		}
	}
}
