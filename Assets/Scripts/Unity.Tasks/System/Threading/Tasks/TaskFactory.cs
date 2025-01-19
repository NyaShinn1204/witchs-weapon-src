namespace System.Threading.Tasks
{
	public class TaskFactory
	{
		private readonly TaskScheduler scheduler;

		private readonly CancellationToken cancellationToken;

		public TaskScheduler Scheduler
		{
			get
			{
				return null;
			}
		}

		internal TaskFactory(TaskScheduler scheduler, CancellationToken cancellationToken)
		{
		}

		public TaskFactory()
		{
		}

		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
		}

		public Task<T> StartNew<T>(Func<T> func)
		{
			return null;
		}

		public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return null;
		}

		public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return null;
		}

		public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state)
		{
			return null;
		}

		public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			return null;
		}

		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction)
		{
			return null;
		}
	}
}
