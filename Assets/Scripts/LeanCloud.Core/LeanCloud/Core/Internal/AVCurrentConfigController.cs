using System.Threading.Tasks;
using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	internal class AVCurrentConfigController : IAVCurrentConfigController
	{
		private const string CurrentConfigKey = "CurrentConfig";

		private readonly TaskQueue taskQueue;

		private AVConfig currentConfig;

		private IStorageController storageController;

		public AVCurrentConfigController(IStorageController storageController)
		{
		}

		public Task<AVConfig> GetCurrentConfigAsync()
		{
			return null;
		}

		public Task SetCurrentConfigAsync(AVConfig config)
		{
			return null;
		}

		public Task ClearCurrentConfigAsync()
		{
			return null;
		}

		public Task ClearCurrentConfigInMemoryAsync()
		{
			return null;
		}
	}
}
