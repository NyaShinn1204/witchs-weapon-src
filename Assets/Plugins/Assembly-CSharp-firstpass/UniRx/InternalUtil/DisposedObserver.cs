using System;

namespace UniRx.InternalUtil
{
	public class DisposedObserver<T> : IObserver<T>
	{
		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(T value)
		{
		}
	}
}
