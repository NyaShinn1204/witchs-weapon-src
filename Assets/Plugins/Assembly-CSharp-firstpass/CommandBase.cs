using System;
using UniRx;

public abstract class CommandBase<TArgument> : ICommandWith<TArgument>, IParameterCommand, ICommand, ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
	private SimpleSubject<TArgument> _executedSubject;

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

	public void OnNext(TArgument value)
	{
	}

	public void OnNext(Unit value)
	{
	}

	public IDisposable Subscribe(IObserver<Unit> observer)
	{
		return null;
	}

	protected virtual void OnOnCommandExecuted()
	{
	}

	protected virtual void OnOnCommandExecuting()
	{
	}

	protected abstract void Execute();

	public abstract bool CanExecute();

	public void Execute(object parameter)
	{
	}

	public bool CanExecute(object parameter)
	{
		return false;
	}

	public IDisposable Subscribe(IObserver<TArgument> observer)
	{
		return null;
	}
}
