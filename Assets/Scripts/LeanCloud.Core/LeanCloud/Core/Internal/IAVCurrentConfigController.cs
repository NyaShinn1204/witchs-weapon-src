using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAVCurrentConfigController
	{
		Task<AVConfig> GetCurrentConfigAsync();

		Task SetCurrentConfigAsync(AVConfig config);

		Task ClearCurrentConfigAsync();

		Task ClearCurrentConfigInMemoryAsync();
	}
}
