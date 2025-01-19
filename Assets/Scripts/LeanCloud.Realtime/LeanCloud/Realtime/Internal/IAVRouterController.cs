using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Realtime.Internal
{
	internal interface IAVRouterController
	{
		Task<PushRouterState> GetAsync(string pushRouter, bool secure, CancellationToken cancellationToken = default(CancellationToken));

		Task ClearCache();
	}
}
