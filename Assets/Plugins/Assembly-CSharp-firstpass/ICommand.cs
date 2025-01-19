using UniRx;

public interface ICommand : ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
	event CommandEvent OnCommandExecuted;

	event CommandEvent OnCommandExecuting;

	void Execute(object parameter);

	bool CanExecute(object parameter);
}
