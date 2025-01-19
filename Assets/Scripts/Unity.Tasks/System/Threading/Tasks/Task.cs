using System.Collections.Generic;

namespace System.Threading.Tasks
{
	public abstract class Task
	{
		private static readonly ThreadLocal<int> executionDepth;

		internal static readonly Action<Action> immediateExecutor;

		internal readonly object mutex;

		internal IList<Action<Task>> continuations;

		internal AggregateException exception;

		internal bool isCanceled;

		internal bool isCompleted;

		public static TaskFactory Factory
		{
			get
			{
				return null;
			}
		}

		public AggregateException Exception
		{
			get
			{
				return null;
			}
		}

		public bool IsCanceled
		{
			get
			{
				return false;
			}
		}

		public bool IsCompleted
		{
			get
			{
				return false;
			}
		}

		public bool IsFaulted
		{
			get
			{
				return false;
			}
		}

		internal Task()
		{
		}

		public void Wait()
		{
		}

		public Task<T> ContinueWith<T>(Func<Task, T> continuation)
		{
			return null;
		}

		public Task<T> ContinueWith<T>(Func<Task, T> continuation, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task ContinueWith(Action<Task> continuation)
		{
			return null;
		}

		public Task ContinueWith(Action<Task> continuation, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task WhenAll(params Task[] tasks)
		{
			return null;
		}

		public static Task WhenAll(IEnumerable<Task> tasks)
		{
			return null;
		}

		public static Task<T[]> WhenAll<T>(IEnumerable<Task<T>> tasks)
		{
			return null;
		}

		public static Task<T> FromResult<T>(T result)
		{
			return null;
		}

		public static Task Delay(TimeSpan timespan)
		{
			return null;
		}

		public static Task Delay(int millisecondsDelay)
		{
			return null;
		}
	}
	public sealed class Task<T> : Task
	{
		private T result;

		public T Result
		{
			get
			{
				return default(T);
			}
		}

		internal Task()
		{
		}

		public Task ContinueWith(Action<Task<T>> continuation)
		{
			return null;
		}

		public Task<TResult> ContinueWith<TResult>(Func<Task<T>, TResult> continuation)
		{
			return null;
		}

		private void RunContinuations()
		{
		}

		internal bool TrySetResult(T result)
		{
			return false;
		}

		internal bool TrySetCanceled()
		{
			return false;
		}

		internal bool TrySetException(AggregateException exception)
		{
			return false;
		}
	}
}
