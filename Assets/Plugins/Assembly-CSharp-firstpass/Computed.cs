using System;

public class Computed<T> : P<T>
{
	private Func<ViewModel, T> _calculator;

	public Func<ViewModel, T> Calculator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Computed(ViewModel owner, string propertyName, params IObservableProperty[] dependantProperties)
	{
	}

	public Computed(ViewModel owner, string propertyName, Func<ViewModel, T> calculator, params IObservableProperty[] dependantProperties)
	{
	}

	public virtual bool CanSetValue(T value)
	{
		return false;
	}

	private void DependantPropertyOnValueChanged(object value)
	{
	}

	public ModelPropertyBinding Subscribe(Action<T> listener, bool immediate = true)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
