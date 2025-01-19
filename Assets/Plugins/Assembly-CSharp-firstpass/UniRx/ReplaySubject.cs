using System;
using System.Collections.Generic;

namespace UniRx
{
	public sealed class ReplaySubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>
	{
		private bool isStopped;

		private Exception lastError;

		private List<IObserver<T>> observers;

		private readonly int bufferSize;

		private readonly TimeSpan window;

		private readonly DateTimeOffset startTime;

		private readonly IScheduler scheduler;

		private readonly Queue<TimeInterval<T>> queue;

		private readonly object gate;

		public ReplaySubject()
		{
		}

		public ReplaySubject(IScheduler scheduler)
		{
		}

		public ReplaySubject(int bufferSize)
		{
		}

		public ReplaySubject(int bufferSize, IScheduler scheduler)
		{
		}

		public ReplaySubject(TimeSpan window)
		{
		}

		public ReplaySubject(TimeSpan window, IScheduler scheduler)
		{
		}

		public ReplaySubject(int bufferSize, TimeSpan window, IScheduler scheduler)
		{
		}

		private void Trim()
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(T value)
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}
	}
}
