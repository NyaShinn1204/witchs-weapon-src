using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAVObjectCurrentController<T> where T : AVObject
	{
		Task SetAsync(T obj, CancellationToken cancellationToken);

		Task<T> GetAsync(CancellationToken cancellationToken);

		Task<bool> ExistsAsync(CancellationToken cancellationToken);

		bool IsCurrent(T obj);

		void ClearFromMemory();

		void ClearFromDisk();
	}
}
