using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace UniRx
{
	public abstract class LazyTask
	{
		public enum TaskStatus
		{
			WaitingToRun = 0,
			Running = 1,
			Completed = 2,
			Canceled = 3,
			Faulted = 4
		}

		protected readonly BooleanDisposable cancellation;

		public TaskStatus Status { get; protected set; }

		public abstract Coroutine Start();

		public void Cancel()
		{
		}

		public static LazyTask<T> FromResult<T>(T value)
		{
			return null;
		}

		public static Coroutine WhenAll(params LazyTask[] tasks)
		{
			return null;
		}

		public static Coroutine WhenAll(IEnumerable<LazyTask> tasks)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator WhenAllCore(Coroutine[] coroutines)
		{
			return null;
		}
	}
	public class LazyTask<T> : LazyTask
	{
		private readonly IObservable<T> source;

		private T result;

		public T Result
		{
			get
			{
				return default(T);
			}
		}

		public Exception Exception { get; private set; }

		public LazyTask(IObservable<T> source)
		{
		}

		public override Coroutine Start()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static LazyTask<T> FromResult(T value)
		{
			return null;
		}
	}
}
