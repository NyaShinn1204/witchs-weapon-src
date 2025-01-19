using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public static class AVSessionExtensions
	{
		public static Task<string> UpgradeToRevocableSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task RevokeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
