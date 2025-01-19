using System;

public abstract class Binding : IBinding, IDisposable
{
	private IObservableProperty _modelProperty;

	private Func<IObservableProperty> _modelPropertySelector;

	public bool CanTwoWayBind
	{
		get
		{
			return false;
		}
	}

	public Func<object> GetTargetValueDelegate { get; set; }

	public bool IsBound { get; set; }

	public bool IsComponent { get; set; }

	public string ModelMemberName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IObservableProperty ModelProperty
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Func<IObservableProperty> ModelPropertySelector
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<object> SetTargetValueDelegate { get; set; }

	public object SourceValue
	{
		get
		{
			return null;
		}
	}

	public bool TwoWay { get; set; }

	public virtual void Bind()
	{
	}

	public virtual void Unbind()
	{
	}

	public void Dispose()
	{
	}
}
