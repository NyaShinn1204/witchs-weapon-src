using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public class AVUserController : IAVUserController
	{
		private readonly IAVCommandRunner commandRunner;

		public AVUserController(IAVCommandRunner commandRunner)
		{
		}

		public Task<IObjectState> SignUpAsync(IObjectState state, IDictionary<string, IAVFieldOperation> operations, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> LogInAsync(string username, string email, string password, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> LogInAsync(string authType, IDictionary<string, object> data, bool failOnNotExist, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> GetUserAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task RequestPasswordResetAsync(string email, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> LogInWithParametersAsync(string relativeUrl, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task UpdatePasswordAsync(string userId, string sessionToken, string oldPassword, string newPassword, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> RefreshSessionTokenAsync(string userId, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
