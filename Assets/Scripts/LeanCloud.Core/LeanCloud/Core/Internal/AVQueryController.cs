using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	internal class AVQueryController : IAVQueryController
	{
		private readonly IAVCommandRunner commandRunner;

		public AVQueryController(IAVCommandRunner commandRunner)
		{
		}

		public Task<IEnumerable<IObjectState>> FindAsync<T>(AVQuery<T> query, AVUser user, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public Task<int> CountAsync<T>(AVQuery<T> query, AVUser user, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public Task<IObjectState> FirstAsync<T>(AVQuery<T> query, AVUser user, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		private Task<IDictionary<string, object>> FindAsync(string relativeUri, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
