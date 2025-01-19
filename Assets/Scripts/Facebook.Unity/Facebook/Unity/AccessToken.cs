using System;
using System.Collections.Generic;

namespace Facebook.Unity
{
	public class AccessToken
	{
		public static AccessToken CurrentAccessToken { get; internal set; }

		public string TokenString { get; private set; }

		public DateTime ExpirationTime { get; private set; }

		public IEnumerable<string> Permissions { get; private set; }

		public string UserId { get; private set; }

		public DateTime? LastRefresh { get; private set; }

		internal AccessToken(string tokenString, string userId, DateTime expirationTime, IEnumerable<string> permissions, DateTime? lastRefresh)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal string ToJson()
		{
			return null;
		}
	}
}
