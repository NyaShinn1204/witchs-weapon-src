using System;

namespace UniRx
{
	public sealed class Subject<T> : ISubject<T>, IDisposable, ISubject<T, T>, IObserver<T>, IObservable<T>
	{
		private class Subscription : IDisposable
		{
			private readonly object gate;

			private Subject<T> parent;

			private IObserver<T> unsubscribeTarget;

			public Subscription(Subject<T> parent, IObserver<T> unsubscribeTarget)
			{
			}

			public void Dispose()
			{
			}
		}

		private object observerLock;

		private bool isStopped;

		private bool isDisposed;

		private Exception lastError;

		private IObserver<T> outObserver;

		public bool HasObservers
		{
			get
			{
				return false;
			}
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

		public void Dispose()
		{
		}

		private void ThrowIfDisposed()
		{
		}
	}
}
