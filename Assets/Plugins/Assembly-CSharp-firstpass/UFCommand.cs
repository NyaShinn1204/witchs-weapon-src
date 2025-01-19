using System;
using UniRx;

public abstract class UFCommand<T> : ICommandWith<T>, IParameterCommand, ICommand, ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
	public object Sender { get; set; }

	public object Parameter { get; set; }

	public event CommandEvent OnCommandExecuted
	{
		add
		{
		}
		remove
		{
		}
	}

	public event CommandEvent OnCommandExecuting
	{
		add
		{
		}
		remove
		{
		}
	}

	public void OnCompleted()
	{
	}

	public void OnError(Exception error)
	{
	}

	public void OnNext(Unit value)
	{
	}

	public IDisposable Subscribe(IObserver<Unit> observer)
	{
		return null;
	}

	protected virtual void OnOnCommandComplete()
	{
	}

	protected virtual void OnOnCommandExecuting()
	{
	}

	protected abstract void Perform(T arg);

	public void Execute()
	{
	}

	public void Execute(object arg)
	{
	}

	public virtual bool CanExecute(object parameter)
	{
		return false;
	}
}
