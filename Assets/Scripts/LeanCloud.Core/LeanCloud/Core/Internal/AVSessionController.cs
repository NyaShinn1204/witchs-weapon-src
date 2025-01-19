using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public class AVSessionController : IAVSessionController
	{
		private readonly IAVCommandRunner commandRunner;

		public AVSessionController(IAVCommandRunner commandRunner)
		{
		}

		public Task<IObjectState> GetSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task RevokeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> UpgradeToRevocableSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public bool IsRevocableSessionToken(string sessionToken)
		{
			return false;
		}
	}
}
