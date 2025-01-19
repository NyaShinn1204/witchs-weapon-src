using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAVAuthenticationProvider
	{
		string AuthType { get; }

		Task<IDictionary<string, object>> AuthenticateAsync(CancellationToken cancellationToken);

		void Deauthenticate();

		bool RestoreAuthentication(IDictionary<string, object> authData);
	}
}
