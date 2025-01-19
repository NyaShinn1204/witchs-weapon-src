using System;
using System.ComponentModel;
using UniRx;

public class P<T> : ISubject<T>, IObservableProperty, INotifyPropertyChanged, ISubject<T, T>, IObserver<T>, IObservable<T>
{
	private object _objectValue;

	private object _lastValue;

	public IObservable<T> ChangedObservable
	{
		get
		{
			return null;
		}
	}

	public object ObjectValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PropertyName { get; set; }

	public ViewModel Owner { get; set; }

	public object LastValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IObservable<Unit> AsUnit
	{
		get
		{
			return null;
		}
	}

	public Func<T> Computer { get; set; }

	public Type ValueType
	{
		get
		{
			return null;
		}
	}

	public T Value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public P()
	{
	}

	public P(T value)
	{
	}

	public P(ViewModel owner, string propertyName)
	{
	}

	public IDisposable SubscribeInternal(Action<object> propertyChanged)
	{
		return null;
	}

	public IDisposable Subscribe(IObserver<object> observer)
	{
		return null;
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}

	public IDisposable ToComputed(Func<T> action, params IObservableProperty[] properties)
	{
		return null;
	}

	public IDisposable ToComputed(Func<ViewModel, T> action, params IObservableProperty[] properties)
	{
		return null;
	}

	public IDisposable Subscribe(IObserver<T> observer)
	{
		return null;
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
}
