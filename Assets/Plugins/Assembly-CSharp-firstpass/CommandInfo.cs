public class CommandInfo
{
	public ICommand Command { get; set; }

	public object Argument { get; set; }

	public bool IsChained { get; set; }

	public CommandInfo(ICommand command, object argument, bool isChained)
	{
	}
}
