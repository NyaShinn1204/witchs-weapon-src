using System;
using System.Collections.Generic;
using UniRx;

public class SimpleSubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>
{
	private List<IObserver<T>> _observers;

	public List<IObserver<T>> Observers
	{
		get
		{
			return null;
		}
		set
		{
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
}
