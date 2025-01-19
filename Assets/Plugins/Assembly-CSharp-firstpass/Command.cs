using System;
using UniRx;

public class Command : ICommand, ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
	public object Sender { get; set; }

	public object Parameter { get; set; }

	protected Action Delegate { get; set; }

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

	public Command(Action @delegate)
	{
	}

	public void Execute()
	{
	}

	public void Execute(object parameter)
	{
	}

	public bool CanExecute(object parameter)
	{
		return false;
	}

	protected virtual void OnOnCommandComplete()
	{
	}

	protected virtual void OnOnCommandExecuting()
	{
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
}
