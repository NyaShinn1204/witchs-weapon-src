using System;
using System.Threading.Tasks;

namespace Unity.Tasks.Internal
{
	internal static class InternalExtensions
	{
		internal static Task<TResult> OnSuccess<TIn, TResult>(this Task<TIn> task, Func<Task<TIn>, TResult> continuation)
		{
			return null;
		}

		internal static Task<TResult> OnSuccess<TResult>(this Task task, Func<Task, TResult> continuation)
		{
			return null;
		}

		internal static Task OnSuccess(this Task task, Action<Task> continuation)
		{
			return null;
		}

		internal static Task WhileAsync(Func<Task<bool>> predicate, Func<Task> body)
		{
			return null;
		}
	}
}
