using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using UniRx;

public class ModelCollection<T> : ObservableCollection<T>, IObservable<NotifyCollectionChangedEventArgs>, IObservableProperty
{
	[Obsolete]
	public delegate void ModelCollectionChangedWith(ModelCollectionChangeEventWith<T> changeArgs);

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

	public Type ValueType
	{
		get
		{
			return null;
		}
	}

	public IObservable<Unit> AsUnit
	{
		get
		{
			return null;
		}
	}

	[Obsolete]
	public event ModelCollectionChangedWith CollectionChangedWith
	{
		add
		{
		}
		remove
		{
		}
	}

	public ModelCollection(ViewModel owner, string propertyName)
	{
	}

	public ModelCollection()
	{
	}

	public IDisposable Subscribe(IObserver<NotifyCollectionChangedEventArgs> observer)
	{
		return null;
	}

	public IDisposable SubscribeInternal(Action<object> propertyChanged)
	{
		return null;
	}

	public void AddRange(IEnumerable<T> enumerable)
	{
	}
}
