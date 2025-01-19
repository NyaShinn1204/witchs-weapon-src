using System.Collections.Generic;

namespace TwitterKit.Unity
{
	public class TwitterSession
	{
		public long id { get; private set; }

		public string userName { get; private set; }

		public AuthToken authToken { get; private set; }

		internal TwitterSession(long id, string userName, AuthToken authToken)
		{
		}

		internal Dictionary<string, object> ToDictionary()
		{
			return null;
		}

		internal static string Serialize(TwitterSession session)
		{
			return null;
		}

		internal static TwitterSession Deserialize(string session)
		{
			return null;
		}
	}
}
