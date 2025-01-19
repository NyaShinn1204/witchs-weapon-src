using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	public class AVCurrentUserController : IAVCurrentUserController, IAVObjectCurrentController<AVUser>
	{
		private readonly object mutex;

		private readonly TaskQueue taskQueue;

		private IStorageController storageController;

		private AVUser currentUser;

		public AVUser CurrentUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AVCurrentUserController(IStorageController storageController)
		{
		}

		public Task SetAsync(AVUser user, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<AVUser> GetAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<bool> ExistsAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public bool IsCurrent(AVUser user)
		{
			return false;
		}

		public void ClearFromMemory()
		{
		}

		public void ClearFromDisk()
		{
		}

		public Task<string> GetCurrentSessionTokenAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task LogOutAsync(CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
