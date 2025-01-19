using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public class AVCloudCodeController : IAVCloudCodeController
	{
		private readonly IAVCommandRunner commandRunner;

		public AVCloudCodeController(IAVCommandRunner commandRunner)
		{
		}

		public Task<T> CallFunctionAsync<T>(string name, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<T> RPCFunction<T>(string name, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
