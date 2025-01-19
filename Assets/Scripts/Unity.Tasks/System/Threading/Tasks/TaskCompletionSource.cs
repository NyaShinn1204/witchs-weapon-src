namespace System.Threading.Tasks
{
	public class TaskCompletionSource<T>
	{
		public Task<T> Task { get; private set; }

		public bool TrySetResult(T result)
		{
			return false;
		}

		public bool TrySetException(AggregateException exception)
		{
			return false;
		}

		public bool TrySetException(Exception exception)
		{
			return false;
		}

		public bool TrySetCanceled()
		{
			return false;
		}

		public void SetResult(T result)
		{
		}

		public void SetException(AggregateException exception)
		{
		}

		public void SetException(Exception exception)
		{
		}

		public void SetCanceled()
		{
		}
	}
}
