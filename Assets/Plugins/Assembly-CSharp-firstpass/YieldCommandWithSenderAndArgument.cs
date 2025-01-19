using System;
using System.Collections;
using UniRx;

[Obsolete]
public class YieldCommandWithSenderAndArgument<TSender, TArgument> : ICommandWith<TArgument>, IParameterCommand, ICommand, ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
	public object Sender { get; set; }

	public object Parameter { get; set; }

	protected Func<TSender, TArgument, IEnumerator> EnumeratorDelegate { get; set; }

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

	public YieldCommandWithSenderAndArgument(Func<TSender, TArgument, IEnumerator> enumeratorDelegate)
	{
	}

	public YieldCommandWithSenderAndArgument(TSender sender, Func<TSender, TArgument, IEnumerator> enumeratorDelegate)
	{
	}

	public void Execute(object parameter)
	{
	}

	public bool CanExecute(object parameter)
	{
		return false;
	}

	public void Execute()
	{
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
