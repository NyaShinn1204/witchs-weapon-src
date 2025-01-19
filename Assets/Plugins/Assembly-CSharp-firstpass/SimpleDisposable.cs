using System;

public class SimpleDisposable : IDisposable
{
	public Action DisposeAction;

	public SimpleDisposable(Action disposeAction)
	{
	}

	public void Dispose()
	{
	}
}
