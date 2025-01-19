using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Realtime.Internal
{
	internal class AVRouterController : IAVRouterController
	{
		private const string routerUrl = "http://router.g0.push.leancloud.cn/v1/route?appId={0}";

		private const string routerKey = "LeanCloud_RouterState";

		public Task<PushRouterState> GetAsync(string pushRouter = null, bool secure = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task ClearCache()
		{
			return null;
		}

		private Task<PushRouterState> LoadAysnc(CancellationToken cancellationToken)
		{
			return null;
		}

		private Task<PushRouterState> QueryAsync(string pushRouter, bool secure, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
