using System;
using System.Collections.Generic;

namespace UniRx
{
	public sealed class BehaviorSubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>
	{
		private bool isStopped;

		private T lastValue;

		private Exception lastError;

		private List<IObserver<T>> observers;

		public T Value
		{
			get
			{
				return default(T);
			}
		}

		public BehaviorSubject(T defaultValue)
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
