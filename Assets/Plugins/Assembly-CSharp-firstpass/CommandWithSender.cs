using System;

public class CommandWithSender<TSender> : CommandBase<TSender>
{
	protected Action<TSender> Delegate { get; set; }

	public TSender Sender { get; set; }

	public CommandWithSender(Action<TSender> @delegate)
	{
	}

	public CommandWithSender(TSender sender, Action<TSender> @delegate)
	{
	}

	public override bool CanExecute()
	{
		return false;
	}

	protected override void Execute()
	{
	}
}
