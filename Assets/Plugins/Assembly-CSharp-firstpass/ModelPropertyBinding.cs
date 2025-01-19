using System;

public class ModelPropertyBinding : Binding, ITwoWayBinding, IBinding
{
	private bool _isImmediate;

	public bool IsImmediate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IDisposable Disposer { get; set; }

	public override void Bind()
	{
	}

	public void BindReverse()
	{
	}

	public override void Unbind()
	{
	}

	private void PropertyChanged(object value)
	{
	}
}
