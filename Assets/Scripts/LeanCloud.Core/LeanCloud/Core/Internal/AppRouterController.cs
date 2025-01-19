using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public class AppRouterController : IAppRouterController
	{
		private AppRouterState currentState;

		private object mutex;

		public AppRouterState Get()
		{
			return null;
		}

		public Task RefreshAsync()
		{
			return null;
		}

		public Task<AppRouterState> QueryAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private static AppRouterState ParseAppRouterState(IDictionary<string, object> jsonObj)
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
