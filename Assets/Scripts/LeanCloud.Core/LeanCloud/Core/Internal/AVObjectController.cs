using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public class AVObjectController : IAVObjectController
	{
		private readonly IAVCommandRunner commandRunner;

		private const int MaximumBatchSize = 50;

		public AVObjectController(IAVCommandRunner commandRunner)
		{
		}

		public Task<IObjectState> FetchAsync(IObjectState state, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> FetchAsync(IObjectState state, IDictionary<string, object> queryString, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> SaveAsync(IObjectState state, IDictionary<string, IAVFieldOperation> operations, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public IList<Task<IObjectState>> SaveAllAsync(IList<IObjectState> states, IList<IDictionary<string, IAVFieldOperation>> operationsList, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task DeleteAsync(IObjectState state, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public IList<Task> DeleteAllAsync(IList<IObjectState> states, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal IList<Task<IDictionary<string, object>>> ExecuteBatchRequests(IList<AVCommand> requests, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		private IList<Task<IDictionary<string, object>>> ExecuteBatchRequest(IList<AVCommand> requests, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
