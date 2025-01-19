using System;
using System.Threading.Tasks;
using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	public class InstallationIdController : IInstallationIdController
	{
		private const string InstallationIdKey = "InstallationId";

		private readonly object mutex;

		private Guid? installationId;

		private readonly IStorageController storageController;

		public InstallationIdController(IStorageController storageController)
		{
		}

		public Task SetAsync(Guid? installationId)
		{
			return null;
		}

		public Task<Guid?> GetAsync()
		{
			return null;
		}

		public Task ClearAsync()
		{
			return null;
		}
	}
}
