using System;

public class CommandWithSenderAndArgument<TSender, TArgument> : CommandBase<TArgument>
{
	public object Sender { get; set; }

	protected Action<TSender, TArgument> Delegate { get; set; }

	public CommandWithSenderAndArgument(Action<TSender, TArgument> @delegate)
	{
	}

	public CommandWithSenderAndArgument(TSender sender, Action<TSender, TArgument> @delegate)
	{
	}

	protected override void Execute()
	{
	}

	public override bool CanExecute()
	{
		return false;
	}
}
