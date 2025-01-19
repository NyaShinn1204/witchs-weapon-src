using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	internal class AVConfigController : IAVConfigController
	{
		private readonly IAVCommandRunner commandRunner;

		public IAVCommandRunner CommandRunner { get; internal set; }

		public IAVCurrentConfigController CurrentConfigController { get; internal set; }

		public AVConfigController(IAVCommandRunner commandRunner, IStorageController storageController)
		{
		}

		public Task<AVConfig> FetchConfigAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
