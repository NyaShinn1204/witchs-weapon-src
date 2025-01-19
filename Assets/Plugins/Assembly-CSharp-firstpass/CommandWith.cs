using System;

[Obsolete]
public class CommandWith<TArgument> : CommandBase<TArgument>
{
	public CommandWith()
	{
	}

	public CommandWith(Action<TArgument> argument)
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
