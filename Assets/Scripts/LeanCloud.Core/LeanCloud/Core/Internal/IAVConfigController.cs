using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAVConfigController
	{
		IAVCurrentConfigController CurrentConfigController { get; }

		Task<AVConfig> FetchConfigAsync(string sessionToken, CancellationToken cancellationToken);
	}
}
