using UniRx;

public interface ICommandDispatcher : IObservable<CommandInfo>
{
	void ExecuteCommand(ICommand command, object argument, bool isChained = false);
}
