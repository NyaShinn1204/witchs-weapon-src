using System;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Storage.Internal
{
	public class TaskQueue
	{
		private Task tail;

		private readonly object mutex;

		public object Mutex
		{
			get
			{
				return null;
			}
		}

		private Task GetTaskToAwait(CancellationToken cancellationToken)
		{
			return null;
		}

		public T Enqueue<T>(Func<Task, T> taskStart, CancellationToken cancellationToken) where T : Task
		{
			return null;
		}
	}
}
