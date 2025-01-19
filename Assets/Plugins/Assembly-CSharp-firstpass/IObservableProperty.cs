using System;
using UniRx;

public interface IObservableProperty
{
	object ObjectValue { get; set; }

	string PropertyName { get; }

	ViewModel Owner { get; set; }

	Type ValueType { get; }

	IObservable<Unit> AsUnit { get; }

	IDisposable SubscribeInternal(Action<object> propertyChanged);
}
