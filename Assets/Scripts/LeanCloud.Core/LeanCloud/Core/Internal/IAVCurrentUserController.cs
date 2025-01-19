using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAVCurrentUserController : IAVObjectCurrentController<AVUser>
	{
		Task<string> GetCurrentSessionTokenAsync(CancellationToken cancellationToken);

		Task LogOutAsync(CancellationToken cancellationToken);
	}
}
