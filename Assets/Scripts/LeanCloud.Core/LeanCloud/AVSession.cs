using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;

namespace LeanCloud
{
	public class AVSession : AVObject
	{
		private static readonly HashSet<string> readOnlyKeys;

		public string SessionToken
		{
			get
			{
				return null;
			}
		}

		public static AVQuery<AVSession> Query
		{
			get
			{
				return null;
			}
		}

		internal static IAVSessionController SessionController
		{
			get
			{
				return null;
			}
		}

		protected override bool IsKeyMutable(string key)
		{
			return false;
		}

		public static Task<AVSession> GetCurrentSessionAsync()
		{
			return null;
		}

		public static Task<AVSession> GetCurrentSessionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task RevokeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<string> UpgradeToRevocableSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
