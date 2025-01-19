using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAppRouterController
	{
		AppRouterState Get();

		Task RefreshAsync();

		void Clear();

		Task<AppRouterState> QueryAsync(CancellationToken cancellationToken);
	}
}
